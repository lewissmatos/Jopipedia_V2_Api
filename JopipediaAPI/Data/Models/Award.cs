namespace JopipediaAPI.Data.Model;

public class Award: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<User>? Users { get; set; }
}