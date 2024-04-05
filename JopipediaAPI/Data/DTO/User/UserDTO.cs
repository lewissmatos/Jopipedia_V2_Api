using JopipediaAPI.Data.DTO.Award;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.DTO.UserLevel;
using JopipediaAPI.Data.DTO.UserRole;

namespace JopipediaAPI.Data.DTO.User;

public class UserDTO
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }   
    public string Username { get; set; }
    public string Email { get; set; }
    public UserLevelDTO? Level { get; set; }
    public List<UserDTO>? Followers { get; set; }
    public List<UserRoleDTO>? Roles { get; set; }
    public UserRankDTO? Rank { get; set; }
    public double RankingValue { get; set; } = 1;
    public List<AwardDTO>? Awards { get; set; }
}