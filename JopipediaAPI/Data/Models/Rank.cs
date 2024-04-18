namespace JopipediaAPI.Data.Model;

public class RankName
{
    public static readonly string rookie = "rookie";
    public static readonly string beginner = "beginner";
    public static readonly string intermediate = "intermediate";
    public static readonly string advanced = "advanced";
    public static readonly string expert = "expert";
    public static readonly string legend = "legend";
    
}
public class Rank: BaseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = RankName.rookie;
    
    public int Index { get; set; }
    
    public int? TopPoints { get; set; }
}