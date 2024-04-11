namespace JopipediaAPI.Data.Model;

public class Topic: BaseModel
{
    public Guid Id { get; set; }
    public String Title { get; set; }
    public String? Description { get; set; }
    public List<Quiz>? Quizzes { get; set; }
}