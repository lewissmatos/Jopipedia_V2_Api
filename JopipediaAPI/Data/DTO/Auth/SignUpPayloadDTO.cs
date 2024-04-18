namespace JopipediaAPI.Data.DTO;

public class SignUpPayloadDTO
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }
    
    public string? ProfilePicture { get; set; }
    public string? GooglePasscodeId { get; set; }
    
    public bool? IsVerified { get; set; }
}