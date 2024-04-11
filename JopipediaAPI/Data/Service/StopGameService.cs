using System.Text;
using JopipediaAPI.Data.Service.Interface;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using Microsoft.IdentityModel.Tokens;

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
public class StopGameService : IStopGameService
{
    private readonly IConfiguration _configuration;
    
    public StopGameService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    async public Task<ServiceResponse<dynamic>> CheckWord(StopGameCheckResultsDTO results)
    {
        
        if (results.Category.IsNullOrEmpty() || results.Word.IsNullOrEmpty())
        {
            return ServiceResponse<dynamic>.BadRequest("badRequest", "Invalid input");
        }

        if (!results.Word.ToLower().Contains(results.Letter.ToLower()))
        {
            return ServiceResponse<dynamic>.Success(false);
        }

        // using (var _httpClient = new HttpClient() )
        // {
        //     _httpClient.DefaultRequestHeaders.Add("Authorization",
        //         $"Bearer {_configuration["OpenAI:Key"]}");
        //
        //     var prompt = $"Is {results.Word} a kind of {results.Category}? Just Answer 'Yes' or 'No'"; 
        //
        //     var requestBody = new
        //     {
        //         model = "gpt-3.5-turbo",
        //         max_tokens = 5,
        //         messages = new[] { new { role = "user", content = prompt } }
        //     };
        //
        //     var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
        //     var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        //
        //     var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", httpContent);
        //
        //     var responseContent = await response.Content.ReadAsStringAsync();
        //
        //     var result =  JsonConvert.DeserializeObject<Root>(responseContent);
        //
        //     var answer = result.Choices?[0]?.Message?.Content
        //         .ToLower().Contains("yes");
        //
        //     return ServiceResponse<dynamic>.Success(answer);
        //    
        // }
    }
}

