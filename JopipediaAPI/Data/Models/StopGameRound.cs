namespace JopipediaAPI.Data.Model;

public class StopGameRound: BaseModel
{
    public Guid Id { get; set; }
    public string Letter { get; set; }
    public List<StopGameAnswer>? Answers { get; set; }
    public List<Guid>? AnswerIds { get; set; }
    public StopGame StopGame { get; set; }
    public Guid StopGameId { get; set; }
}