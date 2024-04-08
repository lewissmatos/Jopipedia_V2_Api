using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.Answer;

public class AnswerFiltersDTO: PaginationParamsDTO
{
    public Guid? QuestionId { get; set; }
    
    public bool? IsCorrect { get; set; }
    
}