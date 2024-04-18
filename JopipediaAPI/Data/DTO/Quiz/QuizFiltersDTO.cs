using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.Quiz;

public class QuizFiltersDTO: PaginationParamsDTO
{
    public string? Search { get; set; }
    public bool? IsPrivate { get; set; }
    
    public List<string>? Difficulties { get; set; }
    public List<Guid>? TopicIds { get; set; }
}