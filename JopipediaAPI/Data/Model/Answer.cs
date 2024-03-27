namespace JopipediaAPI.Data.Model;

public class Answer
{
    public Guid Id { get; set; }
    public string title { get; set; }
    public bool isCorrect { get; set; }
    public Question Question { get; set; }
    public string? Explanation { get; set; }
}