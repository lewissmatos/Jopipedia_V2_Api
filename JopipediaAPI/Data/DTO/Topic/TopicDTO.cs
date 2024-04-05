using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.DTO.Topic;

public class TopicDTO
{
    public Guid? Id { get; set; }
    public String? Title { get; set; }
    public String? Description { get; set; }
}