using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IUserService
{
    Task<ServiceResponse<List<UserDTO>>> GetAll(UserFiltersDTO filters);
    Task<ServiceResponse<UserDTO>> GetById(Guid id);
    Task<ServiceResponse<UserDTO>> Update(Guid id, UpdateUserPayloadDTO updateUserPayload);
    Task<ServiceResponse<UserDTO>> Disable(Guid id);
    Task<ServiceResponse<UserDTO>> Delete(Guid id);
    Task<ServiceResponse<UserDTO>> UpdateUserLevel(Guid id, double value);
    Task<ServiceResponse<UserDTO>> UpdateUserRank(Guid id, double value);
    Task<ServiceResponse<UserDTO>> UpdatePassword(Guid userId, UpdatePasswordDTO updatePasswordDTO);
    Task<ServiceResponse<UserDTO>> GeneratePassword(Guid userId, string password);
    Task<ServiceResponse<UserDTO>> UpdateMyIntrerests(Guid userId, UpdateUserInterestsDTO interestDTO);
    
    
}
