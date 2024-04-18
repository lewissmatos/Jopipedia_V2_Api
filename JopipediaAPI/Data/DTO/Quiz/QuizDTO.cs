using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Quiz;

public class QuizDTO: BaseModel
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public string? Emoji { get; set; }
    public bool IsPrivate { get; set; }  = false;
    public string? Passcode { get; set; }
    public List<Guid>? TopicIds { get; set; }
    public List<TopicDTO>? Topics { get; set; }
    public UserDTO? createdBy { get; set; }
    public Guid? createdById { get; set; }
    public int? QuestionsCount { get; set; }
    
    public string Difficulty { get; set; }
}