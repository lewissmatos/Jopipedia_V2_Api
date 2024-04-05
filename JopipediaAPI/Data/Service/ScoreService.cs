using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class ScoreService: IScoreService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    public ScoreService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }


    async public Task<ServiceResponse<List<ScoreDTO>>> GetAll()
    {
        var scores = await _context.Scores.ToListAsync();
        
        return ServiceResponse<List<ScoreDTO>>.Success(scores.Select(s => _mapper.Map<ScoreDTO>(s)).ToList());
    }

    async public Task<ServiceResponse<ScoreDTO>> GetById(Guid id)
    {
        var score = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (score == null)
        {
            return ServiceResponse<ScoreDTO>.NotFound("notFound","Score not found");
        }
        return ServiceResponse<ScoreDTO>.Success(_mapper.Map<ScoreDTO>(score));
    }

    async public Task<ServiceResponse<ScoreDTO>> Create(ScoreDTO score)
    {
        var newScore = _mapper.Map<Score>(score);
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == score.UserId);
        if (user == null)
        {
            return ServiceResponse<ScoreDTO>.NotFound("notFound","User not found");
        }
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == score.QuizId);
        if (quiz == null)
        {
            return ServiceResponse<ScoreDTO>.NotFound("notFound","Quiz not found");
        }
        
        newScore.User = user;
        newScore.Quiz = quiz;
        
        await _context.Scores.AddAsync(newScore);
        await _context.SaveChangesAsync();
        return ServiceResponse<ScoreDTO>.Success(_mapper.Map<ScoreDTO>(newScore));
    }

   async public Task<ServiceResponse<ScoreDTO>> Update(Guid id, ScoreDTO score)
    {
        var foundScore = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (foundScore == null)
        {
            return ServiceResponse<ScoreDTO>.NotFound("notFound","Score not found");
        }
        foundScore = _mapper.Map<Score>(score);
        _context.Scores.Update(foundScore);
        await _context.SaveChangesAsync();
        return ServiceResponse<ScoreDTO>.Success(_mapper.Map<ScoreDTO>(foundScore));
    }

    async public Task<ServiceResponse<ScoreDTO>> Delete(Guid id)
    {
        var score = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (score == null)
        {
            return ServiceResponse<ScoreDTO>.NotFound("notFound","Score not found");
        }
        _context.Scores.Remove(score);
        await _context.SaveChangesAsync();
        return ServiceResponse<ScoreDTO>.Success(_mapper.Map<ScoreDTO>(score));
    }
}