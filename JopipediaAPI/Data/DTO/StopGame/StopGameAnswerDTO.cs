using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO.StopGame;

public class StopGameAnswerDTO
{
    public Guid Id { get; set; }
    public string Answer { get; set; }
    public double Score { get; set; }
    public UserDTO User { get; set; }
    public Guid UserId { get; set; }
    public StopGameRoundDTO? Round { get; set; }
    public Guid? RoundId { get; set; }
    
    public string? Category { get; set; }
    public bool? IsCorrect { get; set; }
}
