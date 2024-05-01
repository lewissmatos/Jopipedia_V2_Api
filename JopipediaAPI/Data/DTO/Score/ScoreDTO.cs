using JopipediaAPI.Data.DTO.Quiz;
using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO;

public class ScoreDTO
{
    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public UserDTO? User { get; set; }
    public Guid? QuizId { get; set; }
    public QuizDTO? Quiz { get; set; }
    public int? Value { get; set; }
    public int? SecondsTaken { get; set; }

}