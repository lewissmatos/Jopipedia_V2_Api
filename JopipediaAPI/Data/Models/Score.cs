namespace JopipediaAPI.Data.Model;

public class Score
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid QuizId { get; set; }
    public Quiz Quiz { get; set; }
    public int Value { get; set; }
}