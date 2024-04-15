using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.StopGame;

public class StopGameRoundFiltersDTO: PaginationParamsDTO
{
    public Guid? GameId { get; set; }
}