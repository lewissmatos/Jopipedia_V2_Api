using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Rank;

public class UserRankDTO
{
    public Guid? Id { get; set; }
    public string? Name { get; set; } = RankName.rookie;
}