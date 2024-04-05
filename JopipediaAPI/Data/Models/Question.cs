namespace JopipediaAPI.Data.Model;


public class QuestionType
{
    public static string unique = "unique";
    public static string multiple = "multiple";
    public static string tof = "tof";
}
public class Question: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public Quiz? Quiz { get; set; }
    public Guid? QuizId { get; set; }
    public double? Value { get; set; } = 1;
    public string? Type { get; set; } = QuestionType.unique;
}