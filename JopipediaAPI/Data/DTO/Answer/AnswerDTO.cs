using JopipediaAPI.Data.DTO.Question;

namespace JopipediaAPI.Data.DTO.Answer;

public class AnswerDTO
{
    public Guid? Id { get; set; }
    public string? title { get; set; }
    public bool? isCorrect { get; set; }
    public QuestionDTO? Question { get; set; }
    public Guid? QuestionId { get; set; }
    public string? Explanation { get; set; }
}