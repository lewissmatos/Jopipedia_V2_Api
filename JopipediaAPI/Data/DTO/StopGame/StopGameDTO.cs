using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.Model;

public class StopGameDTO
{
    public Guid? Id { get; set; }
    public List<StopGamePlayerDTO>? Players { get; set; }
    public List<Guid>? PlayerIds { get; set; }
    public List<StopGameRound>? Rounds { get; set; }
    public List<Guid>? RoundIds { get; set; }
    public StopGamePlayerDTO? Winner { get; set; }
    public Guid? WinnerId { get; set; }
    public string? Code { get; set; }

}