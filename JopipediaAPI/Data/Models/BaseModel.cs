namespace JopipediaAPI.Data.Model;

public class BaseModel
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool Status { get; set; } = true;
}