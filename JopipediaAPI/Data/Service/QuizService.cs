using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
    
    async public Task<ServiceResponse<List<QuizDTO>>> GetAll(QuizFiltersDTO filters)
    {
        
        var queryableResponse = _context.Quizzes
            .Include( q => q.Topics)
            .OrderByDescending( q => q.CreatedAt)
            .GroupJoin(_context.Questions, // the source to join with
                quiz => quiz.Id, // key selector for the outer type
                question => question.QuizId, // key selector for the inner type
                (quiz, questions) => new // result selector
                {
                    Quiz = quiz,
                    QuestionCount = questions.Count()
                })
            .Select(q => new Quiz()
            {
                Id = q.Quiz.Id,
                Title = q.Quiz.Title,
                Description = q.Quiz.Description,
                Color = q.Quiz.Color,
                Emoji = q.Quiz.Emoji,
                CreatedAt = q.Quiz.CreatedAt,
                CreatedBy = _context.Users.FirstOrDefault(user => user.Id == q.Quiz.CreatedById),
                Topics = _context.Topics.Where(top => q.Quiz.TopicIds.Contains(top.Id)).ToList(),
                TopicIds = q.Quiz.TopicIds,
                IsPrivate = q.Quiz.IsPrivate,
                Passcode = q.Quiz.Passcode,
                QuestionsCount = q.QuestionCount,
                Difficulty = q.Quiz.Difficulty
            })
    .AsQueryable();

        if (!string.IsNullOrEmpty(filters.Search))
        {
            string searchLower = filters.Search.ToLower().Trim();

            queryableResponse = queryableResponse
                .Where(q => q.Title.ToLower().Trim().Contains(searchLower) 
                            || q.Topics.Any(t => t.Title.ToLower().Trim().Contains(searchLower))
                            || q.Description.ToLower().Trim().Contains(searchLower)
                            );
        }
       
        if (!filters.TopicIds.IsNullOrEmpty() )
        {
            queryableResponse = queryableResponse.Where(q => q.TopicIds.Any(topicId => filters.TopicIds.Contains(topicId)));
        } if (!filters.Difficulties.IsNullOrEmpty() )
        {
            queryableResponse = queryableResponse.Where(q =>filters.Difficulties.Contains(q.Difficulty) );
        }
        
        if (filters.IsPrivate != null)
        {
            queryableResponse = queryableResponse.Where(q => q.IsPrivate == filters.IsPrivate);
        }
        if (filters.CreatedById != null)
        {
            queryableResponse = queryableResponse.Where(q => q.CreatedBy.Id == filters.CreatedById);
        }
       
        var paginatedQuizzes = await PaginatedResponse<Quiz>
            .CreateAsync(queryableResponse, filters.Page, filters.Take);
        
        var data = _mapper.Map<List<QuizDTO>>(paginatedQuizzes.Data);
        
        return ServiceResponse<List<QuizDTO>>
            .Success(data, new MessageResponse(){IsSuccess = true}, paginatedQuizzes.Meta);
        
    }
   

   async public Task<ServiceResponse<QuizDTO>> GetById(Guid id)
    {
        var quiz = await _context.Quizzes
            .Where(q => q.Id == id)
            .Include(q => q.Topics)
            .Include(q => q.CreatedBy)
            .GroupJoin(_context.Questions, // the source to join with
                quiz => quiz.Id, // key selector for the outer type
                question => question.QuizId, // key selector for the inner type
                (quiz, questions) => new // result selector
                {
                    Quiz = quiz,
                    QuestionCount = questions.Count()
                })
            .FirstOrDefaultAsync();

        if (quiz == null)
        {
            return ServiceResponse<QuizDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });
        }

        var quizDto = _mapper.Map<QuizDTO>(quiz.Quiz);
        quizDto.QuestionsCount = quiz.QuestionCount;

        return ServiceResponse<QuizDTO>.Success(quizDto, new MessageResponse(){IsSuccess = true});
    }

   async public Task<ServiceResponse<QuizDTO>> Create(QuizDTO quiz)
    {
        var newQuiz = _mapper.Map<Quiz>(quiz);
        
        var topics = await _context.Topics.Where(t => quiz.TopicIds.Contains(t.Id)).ToListAsync();
        if (topics == null)
        {
            return ServiceResponse<QuizDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Topics not found" });
        }
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == quiz.CreatedById);

        newQuiz.CreatedBy = _mapper.Map<User>(user);
        _mapper.Map(quiz, newQuiz);
        newQuiz.Topics = topics;
        await _context.Quizzes.AddAsync(newQuiz);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>
                .Success(_mapper.Map<QuizDTO>(newQuiz), new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

    async public Task<ServiceResponse<QuizDTO>> Update(Guid id, QuizDTO quiz)
    {
        var foundQuiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        if (foundQuiz == null)
        {
            return ServiceResponse<QuizDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });
        }
        quiz.Id = id;
        _mapper.Map(quiz, foundQuiz);
        _context.Quizzes.Update(foundQuiz);

        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>.Success(_mapper.Map<QuizDTO>(foundQuiz), new MessageResponse(){IsSuccess = true});
    }

    async public Task<ServiceResponse<QuizDTO>> Delete(Guid id)
    {
        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == id);
        if (quiz == null)
        {
            return ServiceResponse<QuizDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });
        }
        _context.Quizzes.Remove(quiz);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuizDTO>
                .Success(null, new MessageResponse() { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });
        
    }
}