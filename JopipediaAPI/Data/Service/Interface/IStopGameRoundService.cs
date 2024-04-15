using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IStopGameRoundService
{
    Task<ServiceResponse<List<StopGameRoundDTO>>> GetRounds(StopGameRoundFiltersDTO filters);
    Task<ServiceResponse<StopGameRoundDTO>> AddRound(AddStopGameRountDTO round);
    Task<ServiceResponse<StopGameRoundDTO>> GetRound(Guid id);
    Task<ServiceResponse<List<StopGameRoundDTO>>> GetRoundsByStopGameId(Guid stopGameId);
}