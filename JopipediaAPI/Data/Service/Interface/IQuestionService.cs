using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Question;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IQuestionService
{
    Task<ServiceResponse<List<QuestionDTO>>> GetAll(QuestionFitlersDTO? filters);
    Task<ServiceResponse<QuestionDTO>> GetById(Guid id);
    Task<ServiceResponse<QuestionDTO>> Create(QuestionDTO question);
    Task<ServiceResponse<QuestionDTO>> Update(Guid id, QuestionDTO question);
    Task<ServiceResponse<QuestionDTO>> Delete(Guid id);
}