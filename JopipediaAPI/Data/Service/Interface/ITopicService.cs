using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service.Interface;

public interface ITopicService
{
    Task<ServiceResponse<List<TopicDTO>>> GetAll();
    Task<ServiceResponse<TopicDTO>> GetById(Guid id);
    Task<ServiceResponse<TopicDTO>> Create(TopicDTO topicDTO);
    Task<ServiceResponse<TopicDTO>> Update(Guid id, TopicDTO topicDTO);
    Task<ServiceResponse<TopicDTO>> Delete(Guid id);
}