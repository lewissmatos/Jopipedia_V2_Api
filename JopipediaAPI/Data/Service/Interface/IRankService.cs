using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IRankService
{
    Task<ServiceResponse<List<RankDTO>>> GetAll();
    Task<ServiceResponse<RankDTO>> GetById(Guid id);
    Task<ServiceResponse<RankDTO>> Create(RankDTO rank);
    Task<ServiceResponse<RankDTO>> Update(Guid id, RankDTO rank);
    
    Task<ServiceResponse<RankDTO>> Delete(Guid id);
    Task<ServiceResponse<List<UserDTO>>> Top20Users();
}