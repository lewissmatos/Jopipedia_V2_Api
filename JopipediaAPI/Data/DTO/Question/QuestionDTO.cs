using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Question;

public class QuestionDTO
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public QuizDTO? Quiz { get; set; }
    public Guid? QuizId { get; set; }
    public double? Value { get; set; } = 1;
    public string? Type { get; set; } = QuestionType.unique;
}