namespace JopipediaAPI.Data.Model;

public enum QuestionType {unique, multiple, tof};    

public class Question: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Tescription { get; set; }
    public List<Quiz> Quizzes { get; set; }
    public double Value { get; set; } = 1;
    public QuestionType Type { get; set; } = QuestionType.unique;
}