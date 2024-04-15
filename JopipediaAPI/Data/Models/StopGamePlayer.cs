namespace JopipediaAPI.Data.Model;

public class StopGamePlayer: BaseModel
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; }
    public StopGame StopGame { get; set; }
    public Guid StopGameId { get; set; }
    public double? FinalScore { get; set; }
}