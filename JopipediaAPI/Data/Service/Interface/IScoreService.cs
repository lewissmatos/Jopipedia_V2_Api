using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IScoreService
{
    Task<ServiceResponse<List<ScoreDTO> >> GetAll(PaginationParamsDTO pagination);
    Task<ServiceResponse<ScoreDTO>> GetById(Guid id);
    Task<ServiceResponse<ScoreDTO>> Create(ScoreDTO scoreDTO);
    Task<ServiceResponse<ScoreDTO>> Update(Guid id, ScoreDTO scoreDTO);
    Task<ServiceResponse<ScoreDTO>> Delete(Guid id);
    Task<ServiceResponse<ScoreDTO>> GetSpecific(GetSpecificScoreDTO getSpecificScoreDto);
}