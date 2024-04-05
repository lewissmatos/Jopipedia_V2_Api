using JopipediaAPI.Data.DTO.Question;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IQuestionService
{
    Task<ServiceResponse<List<QuestionDTO>>> GetAll();
    Task<ServiceResponse<QuestionDTO>> GetById(Guid id);
    Task<ServiceResponse<QuestionDTO>> Create(QuestionDTO question);
    Task<ServiceResponse<QuestionDTO>> Update(Guid id, QuestionDTO question);
    Task<ServiceResponse<QuestionDTO>> Delete(Guid id);
}