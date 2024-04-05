namespace JopipediaAPI.Data.Model;

public class UserLevel: BaseModel
{
    public Guid Id { get; set; }
    public int Value { get; set; } = 1;
    public double Percentage { get; set; }
}