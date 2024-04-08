using JopipediaAPI.Data.DTO.Award;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IAwardService
{
    Task<ServiceResponse<List<AwardDTO>>> GetAll(AwardFiltersDTO filters);
    Task<ServiceResponse<AwardDTO>> GetById(Guid id);
    Task<ServiceResponse<AwardDTO>> Create(AwardDTO award);
    Task<ServiceResponse<AwardDTO>> Update(Guid id, AwardDTO award);
    Task<ServiceResponse<AwardDTO>> Delete(Guid id);
}