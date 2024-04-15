using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class StopGameRoundService: IStopGameRoundService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public StopGameRoundService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    public async Task<ServiceResponse<List<StopGameRoundDTO>>> GetRounds(StopGameRoundFiltersDTO filters)
    {
        var queryableResponse =  _context.StopGameRounds
            .Include(r => r.StopGame)
            .AsQueryable();
        
        if (filters.GameId != null)
        {
            queryableResponse = queryableResponse.Where(r => r.StopGameId == filters.GameId);
        }

        var paginatedGameRounds = await PaginatedResponse<StopGameRound>
            .CreateAsync(queryableResponse, filters.Page, filters.Take);
        
        var data = _mapper.Map<List<StopGameRoundDTO>>(paginatedGameRounds.Data);
        
        return ServiceResponse<List<StopGameRoundDTO>>.Success(data, paginatedGameRounds.Meta);
    }

    async public Task<ServiceResponse<StopGameRoundDTO>> AddRound(AddStopGameRountDTO addStopGameRoundDto)
    {
        var stopGame = await _context.StopGames
            .Include(g => g.Rounds)
            .FirstOrDefaultAsync(g => g.Id == addStopGameRoundDto.StopGameId);

        if (stopGame.IsFinished)
        {
            return ServiceResponse<StopGameRoundDTO>.BadRequest("gameFinished", "The game has finished");
        }
        
        var round = new StopGameRound(){
            StopGame = stopGame,
            StopGameId = addStopGameRoundDto.StopGameId,
            Letter = addStopGameRoundDto.Letter,
        };
        
        await _context.StopGameRounds.AddAsync(round);
        stopGame.Rounds.Add(round);
        
        var data = _mapper.Map<StopGameRoundDTO>(round);
        await _context.SaveChangesAsync();
        return ServiceResponse<StopGameRoundDTO>.Success(data);
    }

    async public Task<ServiceResponse<StopGameRoundDTO>> GetRound(Guid id)
    {
        var round = await _context.StopGameRounds
            .Include(r => r.StopGame)
            .FirstOrDefaultAsync(r => r.Id == id);
        
        if (round == null)
        {
            return ServiceResponse<StopGameRoundDTO>.NotFound("notFound", "Round not found");
        }
        
        var data = _mapper.Map<StopGameRoundDTO>(round);
        return ServiceResponse<StopGameRoundDTO>.Success(data);
    }

    async public  Task<ServiceResponse<List<StopGameRoundDTO>>> GetRoundsByStopGameId(Guid stopGameId)
    {
        var queryableResponse =  _context.StopGameRounds
            .Include(r => r.StopGame)
            .Where(r => r.StopGame.Id == stopGameId)
            .AsQueryable();

        var paginatedGameRounds = await PaginatedResponse<StopGameRound>
            .CreateAsync(queryableResponse);
        
        var data = _mapper.Map<List<StopGameRoundDTO>>(paginatedGameRounds.Data);
        
        return ServiceResponse<List<StopGameRoundDTO>>.Success(data, paginatedGameRounds.Meta);
    }
}