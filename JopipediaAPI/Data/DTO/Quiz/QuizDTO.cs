namespace JopipediaAPI.Data.DTO.Quiz;

public class QuizDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public string? Emoji { get; set; }
    public bool IsPrivate { get; set; } 
    public string? Passcode { get; set; }
    public Guid? TopicId { get; set; }
    public Model.Topic? Topic { get; set; }
}