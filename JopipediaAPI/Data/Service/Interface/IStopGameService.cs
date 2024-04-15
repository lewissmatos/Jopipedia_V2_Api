using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.Service.Interface;

public interface IStopGameService
{
    Task<ServiceResponse<List<StopGameDTO>>> GetAll(PaginationParamsDTO paginationParams);
    Task<ServiceResponse<StopGameDTO>> GetById(Guid id);
    Task<ServiceResponse<StopGameDTO>> Create();
    Task<ServiceResponse<StopGameDTO>> Join(JoinStopGameDTO joinStopGame);
    Task<ServiceResponse<StopGameDTO>> End(Guid id);
    Task<ServiceResponse<StopGameDTO>> Delete(Guid id);

}