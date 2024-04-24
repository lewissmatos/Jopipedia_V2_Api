using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Award;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace JopipediaAPI.Data.Service;

public class AwardService: IAwardService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    public AwardService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<List<AwardDTO>>> GetAll(AwardFiltersDTO filters)
    {
        var paginatedResponse = _context.Awards
            .Include(a => a.Users)
            .AsQueryable();
        
        if (!filters.Title.IsNullOrEmpty())
        {
            paginatedResponse = paginatedResponse
                .Where(a => a.Title.Contains(filters.Title));
        }
        
        if (filters.UserId != Guid.Empty && filters.UserId != null)
        {
            paginatedResponse = paginatedResponse
                .Where(
                    a => a.Users
                        .Select(u => u.Id
                            .ToString())
                        .Contains(filters.UserId.ToString())
                    );
        }
        
        if (filters.TopicId != Guid.Empty && filters.TopicId != null)
        {
            paginatedResponse = paginatedResponse
                .Where(a => a.TopicId == filters.TopicId);
        }
        
        var paginatedAwards = await PaginatedResponse<Award>
            .CreateAsync(paginatedResponse, filters.Page, filters.Take);
        
        var data = _mapper.Map<List<AwardDTO>>(paginatedAwards.Data);
        
        return ServiceResponse<List<AwardDTO>>
                .Success(data, new MessageResponse(){IsSuccess = true}, paginatedAwards.Meta);
    }

    async public Task<ServiceResponse<AwardDTO>> GetById(Guid id)
    {
        var award = await _context.Awards
            .Include(a => a.Users)
            .FirstOrDefaultAsync(a => a.Id == id);
        if (award == null)
        {
            return ServiceResponse<AwardDTO>
                    .Success(null,
                        new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Award not found" });
        }
        award.Id = id;
        return ServiceResponse<AwardDTO>.Success(_mapper.Map<AwardDTO>(award), new MessageResponse(){IsSuccess = true});
    }

    async public Task<ServiceResponse<AwardDTO>> Create(AwardDTO award)
    {
        var newAward = _mapper.Map<Award>(award);
        
        var topic = await _context.Topics.FirstOrDefaultAsync(t => t.Id == award.TopicId);
        if (topic == null)
        {
            return ServiceResponse<AwardDTO>
                .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Topic not found" });
        }
        newAward.Topic = topic;
        await _context.Awards.AddAsync(newAward);
        await _context.SaveChangesAsync();
        return ServiceResponse<AwardDTO>
            .Success(_mapper.Map<AwardDTO>(newAward), new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

    async public Task<ServiceResponse<AwardDTO>> Update(Guid id, AwardDTO award)
    {
        var awardToUpdate = await _context.Awards.FirstOrDefaultAsync(a => a.Id == id);
        if (awardToUpdate == null)
        {
            return ServiceResponse<AwardDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Award not found" });
        }
        award.Id = id;
        _mapper.Map(award, awardToUpdate);
        _context.Awards.Update(awardToUpdate);
        await _context.SaveChangesAsync();
        return ServiceResponse<AwardDTO>
                .Success(_mapper.Map<AwardDTO>(_mapper.Map<AwardDTO>(awardToUpdate)),
                    new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    async public Task<ServiceResponse<AwardDTO>> Delete(Guid id)
    {
        var award = await _context.Awards.FirstOrDefaultAsync(a => a.Id == id);
        if (award == null)
        {
            return ServiceResponse<AwardDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "Award not found" });
        }
        _context.Awards.Remove(award);
        await _context.SaveChangesAsync();
        return ServiceResponse<AwardDTO>
                .Success(_mapper.Map<AwardDTO>(_mapper.Map<AwardDTO>(award)),
                    new MessageResponse() { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });
    }
}