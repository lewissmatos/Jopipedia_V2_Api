using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IStopGameService
{
    Task<ServiceResponse<dynamic>> CheckWord(StopGameCheckResultsDTO results);
}