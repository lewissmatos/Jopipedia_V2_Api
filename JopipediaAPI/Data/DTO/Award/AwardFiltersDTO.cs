using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.Award;

public class AwardFiltersDTO: PaginationParamsDTO
{
    public string? Title { get; set; }
    public Guid? UserId { get; set; }
    public Guid? TopicId { get; set; }
}