namespace JopipediaAPI.Data.Model;

public enum QuestionType {unique, multiple, tof};    

public class Question
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Tescription { get; set; }
    public List<Quizz> Quizzes { get; set; }
    public double Value { get; set; }
    public QuestionType Type { get; set; }
}