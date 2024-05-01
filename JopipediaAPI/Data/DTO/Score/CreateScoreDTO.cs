namespace JopipediaAPI.Data.DTO;

public class CreateScoreDTO
{
    public Guid? QuizId { get; set; }
    public int? Value { get; set; }
    public int? SecondsTaken { get; set; }
}