namespace JopipediaAPI.Data.Model;

public class StopGameCategory
{
    public static readonly string country = "country";
    public static readonly string famous = "famous";
    public static readonly string animal = "animal";
    public static readonly string color = "color";
    public static readonly string thing = "thing";
    public static readonly string sport = "sport";
    public static readonly string occupation = "occupation";
}
public class StopGameAnswer: BaseModel
{
    public Guid Id { get; set; }
    public string Answer { get; set; }
    public double Score { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; }
    public StopGameRound Round { get; set; }
    public Guid RoundId { get; set; }
    public string Category { get; set; }
    public bool IsCorrect { get; set; }
}