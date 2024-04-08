using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IQuizService
{
   Task<ServiceResponse<List<QuizDTO>>> GetAll(QuizFiltersDTO filters);
   Task<ServiceResponse<QuizDTO>> GetById(Guid id);
   Task<ServiceResponse<QuizDTO>> Create(QuizDTO quizDTO);
   Task<ServiceResponse<QuizDTO>> Update(Guid id, QuizDTO quiz);
   Task<ServiceResponse<QuizDTO>> Delete(Guid id);
}