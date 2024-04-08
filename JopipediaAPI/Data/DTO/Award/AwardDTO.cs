using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.DTO.User;

namespace JopipediaAPI.Data.DTO.Award;

public class AwardDTO
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public List<UserDTO>? Users { get; set; }
    public TopicDTO? Topic { get; set; }
    public Guid? TopicId { get; set; }
}