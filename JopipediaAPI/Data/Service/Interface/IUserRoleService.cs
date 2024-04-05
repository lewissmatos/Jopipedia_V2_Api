using JopipediaAPI.Data.DTO.UserRole;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface
{
    public interface IUserRoleService
    {
        Task<ServiceResponse<List<UserRoleDTO>>> GetAll();
        Task<ServiceResponse<UserRoleDTO>> GetById(Guid id);
        Task<ServiceResponse<UserRoleDTO>> Create(UserRoleDTO userRole);
        Task<ServiceResponse<UserRoleDTO>> Update(Guid id, UserRoleDTO userRole);
    }
}
