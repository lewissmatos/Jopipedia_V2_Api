using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JopipediaAPI.Data.Model;

public class QuizDificulty: BaseModel
{
    public static readonly string Easy  = "easy";
    public static readonly string Medium  = "medium";
    public static readonly string Hard  = "hard";
    public static readonly string GodLevel  = "godLevel";
}
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
    public List<Topic> Topics { get; set; }
    public List<Guid> TopicIds { get; set; }
    public User? createdBy { get; set; }
    public Guid? createdById { get; set; }
    [NotMapped]
    public int? QuestionsCount { get; set; }
    public string Difficulty { get; set; }

}