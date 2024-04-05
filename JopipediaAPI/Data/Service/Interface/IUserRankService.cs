using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IUserRankService
{
    Task<ServiceResponse<List<UserRankDTO>>> GetAll();
    Task<ServiceResponse<UserRankDTO>> GetById(Guid id);
    Task<ServiceResponse<UserRankDTO>> Create(UserRankDTO userRank);
    Task<ServiceResponse<UserRankDTO>> Update(Guid id, UserRankDTO userRank);
    
    Task<ServiceResponse<UserRankDTO>> Delete(Guid id);
}