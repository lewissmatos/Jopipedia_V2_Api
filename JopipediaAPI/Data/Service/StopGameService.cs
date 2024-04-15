using System.Text;
using JopipediaAPI.Data.Service.Interface;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace JopipediaAPI.Data.Service;

public class StopGameService : IStopGameService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public StopGameService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }

    async public Task<ServiceResponse<List<StopGameDTO>>> GetAll(PaginationParamsDTO paginationParams)
    {
        
        var queryableResponse = _context.StopGames
            .Include(g => g.Rounds)
            .AsQueryable();
        
        var paginatedStopGames = await PaginatedResponse<StopGame>
            .CreateAsync(queryableResponse, paginationParams.Page, paginationParams.Take);

        var data = _mapper.Map<List<StopGameDTO>>(paginatedStopGames.Data);
        
        return ServiceResponse<List<StopGameDTO>>.Success(data, paginatedStopGames.Meta);
    }

    async public Task<ServiceResponse<StopGameDTO>> GetById(Guid id)
    {
        var stopGame = await _context.StopGames.FindAsync(id);

        if (stopGame == null)
        {
            return ServiceResponse<StopGameDTO>.NotFound("notFound", "StopGame not found");
        }

        var data = _mapper.Map<StopGameDTO>(stopGame);

        return ServiceResponse<StopGameDTO>.Success(data);
    }

    async public Task<ServiceResponse<StopGameDTO>> Create()
    {
        var stopGameModel = new StopGame()
        {
            Code = await GenerateGameCode()
        };
        
        await _context.StopGames.AddAsync(stopGameModel);
        await _context.SaveChangesAsync();
        var data = _mapper.Map<StopGameDTO>(stopGameModel);

        return ServiceResponse<StopGameDTO>.Success(data);
    }

    async public Task<ServiceResponse<StopGameDTO>> Join(JoinStopGameDTO joinStopGame)
    {
        var stopGame = await _context.StopGames
            .Include(g => g.Players)
            .FirstOrDefaultAsync(g => g.Code == joinStopGame.Code);

        if (stopGame == null)
        {
            return ServiceResponse<StopGameDTO>.NotFound("notFound", "StopGame not found");
        }
        
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == joinStopGame.UserId);

        var joiningPlayer = new StopGamePlayer(){ User = user, StopGame = stopGame, StopGameId = stopGame.Id};
        await _context.StopGamePlayers.AddAsync(joiningPlayer);
        
        stopGame.Players.Add(joiningPlayer);

        var data = _mapper.Map<StopGameDTO>(stopGame);
        await _context.SaveChangesAsync();
        return ServiceResponse<StopGameDTO>.Success(data);
    }

    async public Task<ServiceResponse<StopGameDTO>> End(Guid gameId)
    {
        var stopGame = await _context.StopGames.FindAsync(gameId);

        if (stopGame == null)
        {
            return ServiceResponse<StopGameDTO>.NotFound("notFound", "StopGame not found");
        }
        
        var players = await _context.StopGamePlayers
            .Where(p => p.StopGameId == gameId)
            .Include(p => p.User)
            .ToListAsync();
        
        var gameAnswers = await _context.StopGameAnswers
            .Include(a => a.Round)
            .Where(a => a.Round.StopGameId == gameId)
            .ToListAsync();

        var playersWithScores = new List<StopGamePlayer>();
        
        playersWithScores.AddRange(
            players.Select(p => {
                p.FinalScore = gameAnswers
                    .Where(a => a.UserId == p.UserId)
                    .Sum(a => a.Score);
                return p;
            }));

        var winner = playersWithScores
            .OrderByDescending(p => p.FinalScore)
            .FirstOrDefault();
        stopGame.Players = playersWithScores;
        stopGame.Winner = winner;
        stopGame.IsFinished = true;
        stopGame.FinishedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        var data = _mapper.Map<StopGameDTO>(stopGame);

        return ServiceResponse<StopGameDTO>.Success(data);
    }

    
    public Task<ServiceResponse<StopGameDTO>> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
    
    async Task<string> GenerateGameCode()
    {
        
        //Generate a random code with numbers and letters with 8 characters
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[8];
        var random = new Random();
        
        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        
        var foundGame = await _context.StopGames.FirstOrDefaultAsync(g => g.Code == new string(stringChars));
        
        if (foundGame != null)
        {
             await GenerateGameCode();
        }
        return new String(stringChars);
    }
}

