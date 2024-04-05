using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service.Interface;

internal class QuizService: IQuizService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public QuizService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<List<QuizDTO>>> GetAll(string? title, string? description)
    {
        var quizzes = _context.Quizzes.AsQueryable();

        if (!string.IsNullOrEmpty(title))
        {
            quizzes = quizzes.Where(q => q.Title.Contains(title));
        }

        if (!string.IsNullOrEmpty(description))
        {
            quizzes = quizzes.Where(q => q.Description.Contains(description));
        }

        var result = await quizzes.ToListAsync();

        return ServiceResponse<List<QuizDTO>>.Success(result.Select(u => _mapper.Map<QuizDTO>(u)).ToList());
    }

    async public Task<ServiceResponse<QuizDTO>> GetById(Guid id)
    {
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        if (quiz == null)
        {
            return ServiceResponse<QuizDTO>.NotFound("notFound","Quiz not found");
        }
        return ServiceResponse<QuizDTO>.Success(_mapper.Map<QuizDTO>(quiz));
    }

   async public Task<ServiceResponse<QuizDTO>> Create(QuizDTO quiz)
    {
        var newQuiz = _mapper.Map<Quiz>(quiz);
        
        var topic = await _context.Topics.FirstOrDefaultAsync(t => t.Id == quiz.TopicId);
        
        if (topic == null)
        {
            return ServiceResponse<QuizDTO>.NotFound("notFound","Topic not found");
        }
        
        newQuiz.Topic = topic;
        _mapper.Map(quiz, newQuiz);
        await _context.Quizzes.AddAsync(newQuiz);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>.Success(_mapper.Map<QuizDTO>(newQuiz));
        
    }

    async public Task<ServiceResponse<QuizDTO>> Update(Guid id, QuizDTO quiz)
    {
        var foundQuiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        if (foundQuiz == null)
        {
            return ServiceResponse<QuizDTO>.NotFound("notFound","Quiz not found");
        }
        quiz.Id = id;
        _mapper.Map(quiz, foundQuiz);
        _context.Quizzes.Update(foundQuiz);

        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>.Success(_mapper.Map<QuizDTO>(foundQuiz));
    }

    async public Task<ServiceResponse<QuizDTO>> Delete(Guid id)
    {
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        if (quiz == null)
        {
            return ServiceResponse<QuizDTO>.NotFound("notFound","Quiz not found");
        }
        _context.Quizzes.Remove(quiz);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>.Success(_mapper.Map<QuizDTO>(quiz));
        
    }
}