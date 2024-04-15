using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IStopGameAnswerService
{
    Task<ServiceResponse<List<StopGameAnswerDTO>>> GetAnswers(Guid roundId);
    Task<ServiceResponse<StopGameAnswerDTO>> Create(CreateStopGameAnswerDTO answer);
    
    Task<ServiceResponse<dynamic>> CheckResult(StopGameCheckResultDTO stopGameResult);
    Task<bool> CheckAnswer(StopGameCheckResultDTO stopGameResult);

}