using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public double RankingValue { get; set; } = 1;
    public UserLevel? Level { get; set; }
    public Guid? LevelId { get; set; }
    public List<User>? Followers { get; set; }
    public List<Guid>? FollowerIds { get; set; }
    public List<UserRole>? Roles { get; set; }
    public List<Guid>? RoleIds { get; set; }
    public UserRank? Rank { get; set; }
    public Guid? RankId { get; set; }
    public List<Award>? Awards { get; set; }
    public List<Topic> Interests { get; set; }
}