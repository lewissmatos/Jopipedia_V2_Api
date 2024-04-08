using JopipediaAPI.Data.DTO.Topic;

namespace JopipediaAPI.Data.Model;

public class Award: BaseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<User>? Users { get; set; }
    public Topic Topic { get; set; }
    public Guid TopicId { get; set; }
    
}