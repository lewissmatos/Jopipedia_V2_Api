using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Question;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace JopipediaAPI.Data.Service;

public class QuestionService : IQuestionService
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

    async public Task<ServiceResponse<List<QuestionDTO>>> GetAll(QuestionFitlersDTO? filters)
    {
        var queryableResponse = _context.Questions
            .Include(q => q.Quiz)
            .Include(q => q.Answers)
            .AsQueryable();


        if (!filters.Title.IsNullOrEmpty())
        {
            queryableResponse = queryableResponse.Where(q => q.Title.Contains(filters.Title));
        }

        if (!filters.Description.IsNullOrEmpty())
        {
            queryableResponse = queryableResponse.Where(q => q.Description.Contains(filters.Description));
        }

        if (filters.QuizId != Guid.Empty && filters.QuizId != null)
        {
            queryableResponse = queryableResponse.Where(q => q.QuizId == filters.QuizId);
        }

        if (!filters.Type.IsNullOrEmpty())
        {
            queryableResponse = queryableResponse.Where(q => q.Type == filters.Type);
        }

        var paginatedQuestions = await PaginatedResponse<Question>
            .CreateAsync(queryableResponse, filters.Page, filters.Take);

        var data = _mapper.Map<List<QuestionDTO>>(paginatedQuestions.Data);

        return ServiceResponse<List<QuestionDTO>>
            .Success(data, new MessageResponse() { IsSuccess = true }, paginatedQuestions.Meta);
    }

    async public Task<ServiceResponse<QuestionDTO>> GetById(Guid id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (question == null)
        {
            return ServiceResponse<QuestionDTO>
                .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });

        }

        return ServiceResponse<QuestionDTO>.Success(_mapper.Map<QuestionDTO>(question),
            new MessageResponse() { IsSuccess = true });
    }

    async public Task<ServiceResponse<QuestionDTO>> Create(QuestionDTO question)
    {
        var newQuestion = _mapper.Map<Question>(question);

        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == question.QuizId);
        if (quiz == null)
        {
            return ServiceResponse<QuestionDTO>
                .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });
        }

        newQuestion.Quiz = quiz;
        _mapper.Map(question, newQuestion);
        await _context.Questions.AddAsync(newQuestion);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>
            .Success(_mapper.Map<QuestionDTO>(newQuestion),
                new MessageResponse()
                    { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

    async public Task<ServiceResponse<QuestionDTO>> Update(Guid id, QuestionDTO question)
    {
        var questionToUpdate = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (questionToUpdate == null)
        {
            return ServiceResponse<QuestionDTO>
                .Success(null,
                    new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Question not found" });
        }

        question.Id = id;
        _mapper.Map(question, questionToUpdate);
        _context.Questions.Update(questionToUpdate);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>
            .Success(_mapper.Map<QuestionDTO>(questionToUpdate),
                new MessageResponse()
                    { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    async public Task<ServiceResponse<QuestionDTO>> Delete(Guid id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        if (question == null)
        {
            return ServiceResponse<QuestionDTO>
                .Success(null,
                    new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Question not found" });
        }

        _context.Questions.Remove(question);
        await _context.SaveChangesAsync();
        return ServiceResponse<QuestionDTO>
            .Success(_mapper.Map<QuestionDTO>(question),
                new MessageResponse()
                    { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });
    }

    async public Task<ServiceResponse<List<QuestionDTO>>> SaveQuestionsAndAnswers(List<QuestionDTO> questions)
    {

        var quiz = await _context.Quizzes.FirstOrDefaultAsync(q => q.Id == questions[0].QuizId);
        if (quiz == null)
        {
            return ServiceResponse<List<QuestionDTO>>
                .Success(null,
                    new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Quiz not found" });
        }
        
        // Remove unwanted questions
        var questionsIds = questions.Select(q => q.Id).ToList();
        var questionsToDelete = await _context.Questions
            .Where(q => q.QuizId == quiz.Id && !questionsIds.Contains(q.Id))
            .ToListAsync();
        _context.Questions.RemoveRange(questionsToDelete);
            
        quiz.questions = _mapper.Map<List<Question>>(questions);
       
        
        await _context.SaveChangesAsync();

        return ServiceResponse<List<QuestionDTO>>
            .Success(questions,
                new MessageResponse()
                    { Key = "savedSuccessfully", IsSuccess = true, Value = "Saved Successfully" });

    }
    
}