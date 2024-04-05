using JopipediaAPI.Data.DTO.Answer;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IAnswerService
{
    Task<ServiceResponse<List<AnswerDTO>>> GetAll();
    Task<ServiceResponse<AnswerDTO>> GetById(Guid id);
    Task<ServiceResponse<AnswerDTO>> Create(AnswerDTO answer);
    Task<ServiceResponse<AnswerDTO>> Update(Guid id, AnswerDTO answer);
    Task<ServiceResponse<AnswerDTO>> Delete(Guid id);
}