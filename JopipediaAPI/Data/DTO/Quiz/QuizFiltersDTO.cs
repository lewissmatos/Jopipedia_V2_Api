using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.Quiz;

public class QuizFiltersDTO: PaginationParamsDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    
    public Guid? TopicId { get; set; }
}