using System.ComponentModel.DataAnnotations.Schema;

namespace JopipediaAPI.Data.Model;

public class Topic: BaseModel
{
    public Guid Id { get; set; }
    public String Title { get; set; }
    public String? Description { get; set; }
    public List<Quiz>? Quizzes { get; set; }
    [NotMapped]
    public int? QuizCount { get; set; }
}