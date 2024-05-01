using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.Pagination;
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

    async public Task<ServiceResponse<List<ScoreDTO>>> GetAll(PaginationParamsDTO pagination)
    {
        var queryableResult = _context.Scores.AsQueryable();
        
        var paginatedScores = await PaginatedResponse<Score>
            .CreateAsync(queryableResult, pagination.Page, pagination.Take);
        
        var data = _mapper.Map<List<ScoreDTO>>(paginatedScores.Data);
        
        return ServiceResponse<List<ScoreDTO>>
            .Success(data, new MessageResponse(){IsSuccess = true}, paginatedScores.Meta);
    }

    async public Task<ServiceResponse<ScoreDTO>> GetById(Guid id)
    {
        var score = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (score == null)
        {
            return ServiceResponse<ScoreDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Score not found" });
        }
        return ServiceResponse<ScoreDTO>
            
            .Success(_mapper.Map<ScoreDTO>(score),new MessageResponse(){IsSuccess = true});
    }

    async public Task<ServiceResponse<ScoreDTO>> Create(ScoreDTO score)
    {
        
        var foundScore = await _context.Scores.FirstOrDefaultAsync(s => s.UserId == score.UserId && s.QuizId == score.QuizId);
        
        if (foundScore is not null && foundScore.Value < score.Value)
        {
            foundScore.Value = score.Value ?? 0;
            foundScore.SecondsTaken = score.SecondsTaken ?? 0;
            foundScore.UpdatedAt =  DateTime.UtcNow;
            _context.Scores.Update(foundScore); 
            await _context.SaveChangesAsync();
           return ServiceResponse<ScoreDTO>
                .Success(_mapper.Map<ScoreDTO>(foundScore), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });

        }
        var newScore = _mapper.Map<Score>(score);
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == score.UserId);
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == score.QuizId);
        if (quiz == null)
        {
            return ServiceResponse<ScoreDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Score not found" });
        }

        var mappedUser =  _mapper.Map<User>(user);

        newScore.User = mappedUser;
        newScore.Quiz = quiz;
        
        await _context.Scores.AddAsync(newScore);
        await _context.SaveChangesAsync();
        return ServiceResponse<ScoreDTO>
                .Success(_mapper.Map<ScoreDTO>(newScore), new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

   async public Task<ServiceResponse<ScoreDTO>> Update(Guid id, ScoreDTO score)
    {
        var foundScore = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (foundScore == null)
        {
            return ServiceResponse<ScoreDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Score not found" });
        }
        _context.Scores.Update(foundScore);
        await _context.SaveChangesAsync();
        foundScore = _mapper.Map<Score>(score);
        return ServiceResponse<ScoreDTO>
                .Success(_mapper.Map<ScoreDTO>(foundScore), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    async public Task<ServiceResponse<ScoreDTO>> Delete(Guid id)
    {
        var score = await _context.Scores.FirstOrDefaultAsync(s => s.Id == id);
        if (score == null)
        {
            return ServiceResponse<ScoreDTO>.Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Score not found" });
                
        }
        _context.Scores.Remove(score);
        await _context.SaveChangesAsync();
        return ServiceResponse<ScoreDTO>
                .Success(_mapper.Map<ScoreDTO>(score), new MessageResponse() { Key = "deleted Successfully", IsSuccess = true, Value = "Deleted Successfully" });
    }

    async public Task<ServiceResponse<ScoreDTO>> GetSpecific(GetSpecificScoreDTO getSpecificScoreDto)
    {
        var score = await _context.Scores.FirstOrDefaultAsync(s => s.UserId == getSpecificScoreDto.UserId && s.QuizId == getSpecificScoreDto.QuizId);
        if (score == null)
        {
            return ServiceResponse<ScoreDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Score not found" });
        }
        return ServiceResponse<ScoreDTO>
                .Success(_mapper.Map<ScoreDTO>(score), new MessageResponse() { IsSuccess = true });
    }
}