using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.StopGame;

public class StopGamePlayerDTO
{
    public Guid? Id { get; set; }
    public UserDTO? User { get; set; }
    public Guid? UserId { get; set; }
    public StopGameDTO? StopGame { get; set; }
    public Guid? StopGameId { get; set; }
    public double? FinalScore { get; set; }
}