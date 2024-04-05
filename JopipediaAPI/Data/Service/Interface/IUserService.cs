using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface IUserService
{
    Task<ServiceResponse<List<UserDTO>>> GetAllUsers();
    Task<ServiceResponse<UserDTO>> GetUserById(Guid id);
    Task<ServiceResponse<UserDTO>> UpdateUser(Guid id, UpdateUserPayloadDTO updateUserPayload);
    Task<ServiceResponse<UserDTO>> DisableUser(Guid id);
    Task<ServiceResponse<UserDTO>> DeleteUser(Guid id);
    Task<ServiceResponse<UserDTO>> UpdateUserLevel(Guid id, double value);
    Task<ServiceResponse<UserDTO> > UpdateUserRank(Guid id, double value);
}
