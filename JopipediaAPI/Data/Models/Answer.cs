namespace JopipediaAPI.Data.Model;

public class Answer: BaseModel
{
    public Guid Id { get; set; }
    public string title { get; set; }
    public bool isCorrect { get; set; }
    public Question Question { get; set; }
    public Guid QuestionId { get; set; }
    public string? Explanation { get; set; }
}