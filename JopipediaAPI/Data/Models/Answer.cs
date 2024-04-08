namespace JopipediaAPI.Data.Model;

public class Answer: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCorrect { get; set; }
    public Question Question { get; set; }
    public Guid QuestionId { get; set; }
    public string? Explanation { get; set; }
}