namespace JopipediaAPI.Data.DTO;

public class LoginPayloadDTO
{
    public string Username { get; set; }
    public string? Password { get; set; }
    public string? GooglePasscodeId { get; set; }
    
}