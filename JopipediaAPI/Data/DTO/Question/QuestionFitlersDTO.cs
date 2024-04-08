using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.Question;

public class QuestionFitlersDTO: PaginationParamsDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Guid? QuizId { get; set; }
    public double? Value { get; set; }
    public string? Type { get; set; }
}