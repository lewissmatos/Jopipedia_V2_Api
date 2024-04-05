using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO;

public class LoginResponseDTO
{
    public string Token { get; set; }
    public UserDTO User { get; set; }
}