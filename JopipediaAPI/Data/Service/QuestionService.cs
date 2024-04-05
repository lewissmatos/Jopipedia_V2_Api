using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Question;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class QuestionService: IQuestionService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public QuestionService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<List<QuestionDTO>>> GetAll()
    {
        var questions = await _context.Questions.ToListAsync();
            
        return ServiceResponse<List<QuestionDTO>>.Success(_mapper.Map<List<QuestionDTO>>(questions));
    }

    async public Task<ServiceResponse<QuestionDTO>> GetById(Guid id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (question == null)
        {
            return ServiceResponse<QuestionDTO>.NotFound("notFound","Question not found");
        }
        return ServiceResponse<QuestionDTO>.Success(_mapper.Map<QuestionDTO>(question));
    }

    async public Task<ServiceResponse<QuestionDTO>> Create(QuestionDTO question)
    {
        var newQuestion = _mapper.Map<Question>(question);
        
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == question.QuizId);
        if (quiz == null)
        {
            return ServiceResponse<QuestionDTO>.NotFound("notFound","Quiz not found");
        }
        newQuestion.Quiz = quiz;
        _mapper.Map(question, newQuestion);
        await _context.Questions.AddAsync(newQuestion);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>.Success(_mapper.Map<QuestionDTO>(newQuestion));
    }

    async public Task<ServiceResponse<QuestionDTO>> Update(Guid id, QuestionDTO question)
    {
        var questionToUpdate = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (questionToUpdate == null)
        {
            return ServiceResponse<QuestionDTO>.NotFound("notFound","Question not found");
        }
        question.Id = id;
        _mapper.Map(question, questionToUpdate);
        _context.Questions.Update(questionToUpdate);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>.Success(_mapper.Map<QuestionDTO>(questionToUpdate));
    }

    async public Task<ServiceResponse<QuestionDTO>> Delete(Guid id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (question == null)
        {
            return ServiceResponse<QuestionDTO>.NotFound("notFound","Question not found");
        }
        _context.Questions.Remove(question);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>.Success(_mapper.Map<QuestionDTO>(question));
    }
}