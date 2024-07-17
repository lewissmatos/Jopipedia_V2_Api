using System.Text;
using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace JopipediaAPI.Data.Service;

public class Message
{
    public string Role { get; set; }
    public string Content { get; set; }
}

public class Choice
{
    public int Index { get; set; }
    public Message Message { get; set; }
    public object Logprobs { get; set; }
    public string FinishReason { get; set; }
}

public class Usage
{
    public int PromptTokens { get; set; }
    public int CompletionTokens { get; set; }
    public int TotalTokens { get; set; }
}

public class Root
{
    public string Id { get; set; }
    public string Object { get; set; }
    public int Created { get; set; }
    public string Model { get; set; }
    public List<Choice> Choices { get; set; }
    public Usage Usage { get; set; }
    public string SystemFingerprint { get; set; }
}

public class StopGameAnswerService: IStopGameAnswerService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public StopGameAnswerService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<List<StopGameAnswerDTO>>> GetAnswers(Guid roundId)
    {
        var answers = await _context.StopGameAnswers
            .Include(x => x.User)
            .Where(x => x.RoundId == roundId)
            .ToListAsync();
        return ServiceResponse<List<StopGameAnswerDTO>>.Success(_mapper.Map<List<StopGameAnswerDTO>>(answers),new MessageResponse(){IsSuccess = true});
    }

    async public Task<ServiceResponse<StopGameAnswerDTO>> Create(CreateStopGameAnswerDTO answer)
    {
        
       
        var stopGameAnswer = _mapper.Map<StopGameAnswer>(answer);
        await _context.StopGameAnswers.AddAsync(stopGameAnswer);
        var round = await _context.StopGameRounds.
            Include(r => r.StopGame)
            .FirstOrDefaultAsync(x => x.Id == answer.RoundId);
       
        //Check if the Game is finished
        if (round.StopGame.IsFinished)
        {
            return ServiceResponse<StopGameAnswerDTO>
                .Success(null, new MessageResponse() { Key = "gameFinished", IsSuccess = false, Value = "The game is finished" });
        }
        
        //Check if the user already joined the game
        var isJoinedToGame = await _context.StopGames
            .AnyAsync(game => game.Id == round.StopGameId 
                              && game.Players.Any(p => p.UserId == answer.UserId )
            );
        if (!isJoinedToGame)
        {
            return ServiceResponse<StopGameAnswerDTO>
                    .Success(null, new MessageResponse() { Key = "notJoined", IsSuccess = false, Value = "You haven't joined the game" });
            
        }
        
        // Check if the answer has already been answered
        var matchingAnswers = await _context.StopGameAnswers
            .Where(a => a.RoundId == answer.RoundId && a.Answer.ToLower() == answer.Word.ToLower())
            .ToListAsync();
        
        var resultDTO = new StopGameCheckResultDTO()
        {
            Category = answer.Category,
            Letter = round.Letter,
            Word = answer.Word
        };
        stopGameAnswer.IsCorrect = await CheckAnswer(resultDTO);
        stopGameAnswer.UserId = answer.UserId;
        stopGameAnswer.RoundId = answer.RoundId;
        stopGameAnswer.Answer = answer.Word;
        if (!stopGameAnswer.IsCorrect)
        {
            stopGameAnswer.Score = 0;
        }
        else if(matchingAnswers.Count > 0)
        {
            stopGameAnswer.Score = Math.Floor( 100.0 / ( matchingAnswers.Count + 1 ) );
        }
        else
        {
            stopGameAnswer.Score = 100;
        }

        await _context.StopGameAnswers.AddAsync(stopGameAnswer);
        await _context.SaveChangesAsync();
        return ServiceResponse<StopGameAnswerDTO>.Success(_mapper.Map<StopGameAnswerDTO>(stopGameAnswer),
            new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }
    
    async public Task<ServiceResponse<dynamic>> CheckResult(StopGameCheckResultDTO stopGameResult)
    {
        
        if (stopGameResult.Category.IsNullOrEmpty() || stopGameResult.Word.IsNullOrEmpty())
        {
            return ServiceResponse<dynamic>
                    .Success(false, new MessageResponse() { Key = "badRequest", IsSuccess = false, Value = "Invalid input" });
        }

        if (!stopGameResult.Word.ToLower().Contains(stopGameResult.Letter.ToLower()))
        {
            return ServiceResponse<dynamic>
                    .Success(false, new MessageResponse() { Key = "incorrectAnswer", IsSuccess = true, Value = "Incorrec Answer" });
        }

        var answer = await CheckAnswer(stopGameResult);
        
        return ServiceResponse<dynamic>
                .Success(answer);
    }
    
    async public Task<bool> CheckAnswer(StopGameCheckResultDTO stopGameResult)
    {
        if (stopGameResult.Category.IsNullOrEmpty() || stopGameResult.Word.IsNullOrEmpty() || !stopGameResult.Word.ToLower().StartsWith(stopGameResult.Letter.ToLower()))
        {
            return false;
        }

        using (var _httpClient = new HttpClient())
        {
            
            _httpClient.DefaultRequestHeaders.Add("Authorization",
                $"Bearer {_configuration["OpenAI:Key"]}");

            var prompt = $"Is {stopGameResult.Word} a kind of {stopGameResult.Category}? " +
                         $"(If the word is misspelled say 'No'," +
                         $" but if the typo is just an accent you have to ignore the typo)." +
                         $"Just Answer 'Yes' or 'No'"; 

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                max_tokens = 5,
                messages = new[] { new { role = "user", content = prompt } }
            };

            var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", httpContent);

            var responseContent = await response.Content.ReadAsStringAsync();

            var openAiRes =  JsonConvert.DeserializeObject<Root>(responseContent);

            var isAnswerValid = openAiRes.Choices?[0]?.Message?.Content
                .ToLower().Contains("yes") ?? false;

            return isAnswerValid;
        }
    }

}