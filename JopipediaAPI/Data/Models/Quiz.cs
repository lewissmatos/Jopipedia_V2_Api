using System.ComponentModel.DataAnnotations;

namespace JopipediaAPI.Data.Model;

public class Quiz: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    [MaxLength(400)]
    public string? Description { get; set; }
    public string? Color { get; set; }
    public string? Emoji { get; set; }
    public bool IsPrivate { get; set; } = false;
    public string? Passcode { get; set; }
    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }
}