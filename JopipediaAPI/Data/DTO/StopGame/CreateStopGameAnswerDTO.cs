using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO.StopGame;

public class CreateStopGameAnswerDTO
{
    public String Category { get; set; }
    public String Word { get; set; }
    public Guid UserId { get; set; }
    public Guid RoundId { get; set; }
}