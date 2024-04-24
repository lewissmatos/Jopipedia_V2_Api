using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface

{
    public interface IAuthService
    {
        Task<ServiceResponse<LoginResponseDTO>> Login(LoginPayloadDTO loginPayload);
        Task<ServiceResponse<UserDTO>> SignUp(SignUpPayloadDTO signUpPayload);
        
        Task<ServiceResponse<UserDTO>> AddGoogleAuthData(AddGoogleAuthDataDTO googleData);
    }
}