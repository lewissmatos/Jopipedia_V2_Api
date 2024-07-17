using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO;

public class TopScorersResponseDTO
{
    public ScoreDTO Score { get; set; }
    public UserDTO User { get; set; }
}