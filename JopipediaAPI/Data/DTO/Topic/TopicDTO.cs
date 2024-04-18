using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Topic;

public class TopicDTO
{
    public Guid? Id { get; set; }
    public String? Title { get; set; }
    public String? Description { get; set; }
    public List<QuizDTO>? Quizzes { get; set; }
    public int? QuizzesCount { get; set; }
}