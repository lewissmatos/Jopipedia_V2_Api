using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Model;

[Index(nameof(Email), IsUnique = true)]
[Index(nameof(Username), IsUnique = true)]
public class User: BaseModel
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }   
    [MaxLength(30)]
    public string Username { get; set; }
    [MaxLength(100)]
    public string Email { get; set; }
    public string? Password { get; set; }
    
    public string? ProfilePicture { get; set; }
    
    public string? GooglePasscodeId { get; set; }
    public double RankingValue { get; set; } = 1.0;
    public UserLevel? Level { get; set; }
    public Guid? LevelId { get; set; }
    public List<User>? Followers { get; set; }
    public List<Guid>? FollowerIds { get; set; }
    public List<UserRole>? Roles { get; set; }
    public List<Guid>? RoleIds { get; set; }
    public Rank? Rank { get; set; }
    public Guid? RankId { get; set; }
    public List<Award>? Awards { get; set; }
    public List<Topic>? Interests { get; set; }
    
    public bool IsVerified { get; set; } = false;
    
    [NotMapped]
    public bool HasPassword { get; set; }
    public bool CheckPassword()
    {
        return !string.IsNullOrEmpty(Password);
    }
}