using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Answer;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class AnswerService: IAnswerService
{

    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public AnswerService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<List<AnswerDTO>>> GetAll(AnswerFiltersDTO? filters)
    {
        var queryableAnswers = _context.Answers
            .Include(a => a.Question)
            .Where(a => a.Status == true)
            .AsQueryable();
        
        if(filters.QuestionId != Guid.Empty && filters.QuestionId.HasValue)
        {
            queryableAnswers = queryableAnswers.Where(a => a.QuestionId == filters.QuestionId);
        }
        if(filters.IsCorrect != null)
        {
            queryableAnswers = queryableAnswers.Where(a => a.IsCorrect == filters.IsCorrect);
        }
        
        var paginatedAnswers = await PaginatedResponse<Answer>
            .CreateAsync(queryableAnswers, filters.Page, filters.Take);
        
        var data = _mapper.Map<List<AnswerDTO>>(paginatedAnswers.Data);
        
        return ServiceResponse<List<AnswerDTO>>
            .Success(data, paginatedAnswers.Meta);
    }

    async public Task<ServiceResponse<AnswerDTO>> GetById(Guid id)
    {
        var answer = await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
        if (answer == null)
        {
            return ServiceResponse<AnswerDTO>.NotFound("notFound","Answer not found");
        }
        return ServiceResponse<AnswerDTO>.Success(_mapper.Map<AnswerDTO>(answer));
    }

   async public Task<ServiceResponse<AnswerDTO>> Create(AnswerDTO answer)
    {
        var newAnswer = _mapper.Map<Model.Answer>(answer);
        
        var question = await _context.Questions.FirstOrDefaultAsync(x => x.Id == answer.QuestionId);
        
        if (question == null)
        {
            return ServiceResponse<AnswerDTO>.NotFound("notFound","Question not found");
        }
        newAnswer.Question = question;
        _mapper.Map(answer, newAnswer);
        await _context.Answers.AddAsync(newAnswer);
        await _context.SaveChangesAsync();
        return ServiceResponse<AnswerDTO>.Success(_mapper.Map<AnswerDTO>(newAnswer));
    }

    async public Task<ServiceResponse<AnswerDTO>> Update(Guid id, AnswerDTO answer)
    {
        var foundAnswer = await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
        if (foundAnswer == null)
        {
            return ServiceResponse<AnswerDTO>.NotFound("notFound","Answer not found");
        }
        _mapper.Map(answer, foundAnswer);
        _context.Answers.Update(foundAnswer);
        await _context.SaveChangesAsync();
        return ServiceResponse<AnswerDTO>.Success(_mapper.Map<AnswerDTO>(foundAnswer));
    }

    async public Task<ServiceResponse<AnswerDTO>> Delete(Guid id)
    {
        var foundAnswer = await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
        if (foundAnswer == null)
        {
            return ServiceResponse<AnswerDTO>.NotFound("notFound","Answer not found");
        }
        _context.Answers.Remove(foundAnswer);
        await _context.SaveChangesAsync();
        return ServiceResponse<AnswerDTO>.Success(_mapper.Map<AnswerDTO>(foundAnswer));
    }
}