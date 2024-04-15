using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.StopGame;

public class StopGameRoundDTO
{
    public Guid? Id { get; set; }
    public string? Letter { get; set; }
    public List<StopGameAnswerDTO> Answers { get; set; }
    public List<Guid> AnswerIds { get; set; }
    public StopGameDTO? StopGame { get; set; }
    public Guid? StopGameId { get; set; }
}