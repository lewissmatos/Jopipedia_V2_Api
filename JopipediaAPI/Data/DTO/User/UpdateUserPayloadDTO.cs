using JopipediaAPI.Data.DTO.Award;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.DTO.UserLevel;
using JopipediaAPI.Data.DTO.UserRole;

namespace JopipediaAPI.Data.DTO.User;

public class UpdateUserPayloadDTO
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }   
    public List<UserRoleDTO>? Roles { get; set; }
    public List<Guid>? RoleIds { get; set; }
    public RankDTO? Rank { get; set; }
    public Guid? RankId { get; set; }
    public UserLevelDTO? Level { get; set; }
    public Guid? LevelId { get; set; }

    public List<AwardDTO>? Awards { get; set; }
    public List<Guid>? AwardIds { get; set; }
    
    public List<UserDTO>? Followers { get; set; }
    public List<Guid>? FollowerIds { get; set; }
    
    public List<TopicDTO>? Interests { get; set; }
    public List<Guid>? InterestIds { get; set; }
}