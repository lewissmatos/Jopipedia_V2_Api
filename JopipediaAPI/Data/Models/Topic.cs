namespace JopipediaAPI.Data.Model;

public class Topic
{
    public Guid Id { get; set; }
    public String Title { get; set; }
    public String? Description { get; set; }
    public List<Quiz>? Quizzes { get; set; }
}