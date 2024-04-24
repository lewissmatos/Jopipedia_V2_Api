namespace JopipediaAPI.Data.DTO.User;

public class UpdatePasswordDTO
{
    public string CurrentPassword { get; set; }
    public string NewPassword { get; set; }
}