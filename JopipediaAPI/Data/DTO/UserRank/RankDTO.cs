using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Rank;

public class RankDTO
{
    public Guid? Id { get; set; }
    public string? Name { get; set; } = RankName.rookie;
    
    public int Index { get; set; }
    
    public int? TopPoints { get; set; }
}