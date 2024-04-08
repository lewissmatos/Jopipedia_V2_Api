using JopipediaAPI.Data.DTO.Pagination;

namespace JopipediaAPI.Data.DTO.User;

public class UserFiltersDTO: PaginationParamsDTO
{
    public string? Name {get;set;}
    public string? RoleIds {get;set;}
    public string? RankId {get;set;}
    public string? LevelId {get;set;}
}