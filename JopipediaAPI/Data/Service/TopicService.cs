using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;


internal class TopicService: ITopicService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public TopicService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public  Task<ServiceResponse<List<TopicDTO>>> GetAll(PaginationParamsDTO pagination)
    {

        var queryableResponse = _context.Topics
            .OrderBy( t => t.Title)
            .Select( t => new Topic()
            {
                Id =  t.Id,
                Title = t.Title,
                Description = t.Description,
                Quizzes = t.Quizzes,
                QuizzesCount = t.Quizzes.Count
            })
            .AsQueryable();

        var paginatedTopics = await PaginatedResponse<Topic>
            .CreateAsync(queryableResponse, pagination.Page,pagination.Take);
        
        var data = _mapper.Map<List<TopicDTO>>(paginatedTopics.Data);
        
        return ServiceResponse<List<TopicDTO>>.Success(data, new MessageResponse(){IsSuccess = true}, paginatedTopics.Meta);
    }

    async public Task<ServiceResponse<TopicDTO>> GetById(Guid id)
    {
        var topic = await  _context.Topics.
            Include(t => t.Quizzes)
            .FirstOrDefaultAsync(t => t.Id == id);
        // var QuizCount = _context.Quizzes.Where(q => q.TopicIds.Contains(id)).Count();

        var data = _mapper.Map<TopicDTO>(topic);
        data.QuizzesCount = topic.Quizzes.Count();
        return ServiceResponse<TopicDTO>.Success(data, new MessageResponse(){IsSuccess = true});
    }

    async public Task<ServiceResponse<TopicDTO>> Create(TopicDTO topicDTO)
    {
        var topic = _mapper.Map<Topic>(topicDTO);
        await _context.Topics.AddAsync(topic);
        await _context.SaveChangesAsync();
        return ServiceResponse<TopicDTO>
                .Success(_mapper.Map<TopicDTO>(topic), new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

    async public Task<ServiceResponse<TopicDTO>> Update(Guid id, TopicDTO topic)
    {
        var foundTopic = await _context.Topics.FirstOrDefaultAsync(t=>t.Id == id);
        
        if (foundTopic == null)
        {
            return ServiceResponse<TopicDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Topic not found" });
        }
        
        var titleExists = await _context.Topics.AnyAsync(t => t.Title == topic.Title && t.Id != id);

        if (titleExists)
        {
            return ServiceResponse<TopicDTO>
                    .Success(null, new MessageResponse() { Key = "titleExists", IsSuccess = false, Value = "Topic with the same title already exists" });
        }
        topic.Id = id;
        _mapper.Map(topic, foundTopic);
        
        _context.Topics.Update(foundTopic);
        await _context.SaveChangesAsync();
        return ServiceResponse<TopicDTO>
                .Success(_mapper.Map<TopicDTO>(foundTopic), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    async public Task<ServiceResponse<TopicDTO>> Delete(Guid id)
    {
        var foundTopic = await _context.Topics.FirstOrDefaultAsync(t=>t.Id == id);
        
        if (foundTopic == null)
        {
            return ServiceResponse<TopicDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Topic not found" });
        }
        
        _context.Topics.Remove(foundTopic);
        await _context.SaveChangesAsync();
        return ServiceResponse<TopicDTO>
                .Success(_mapper.Map<TopicDTO>(foundTopic), new MessageResponse() { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });

    }
}