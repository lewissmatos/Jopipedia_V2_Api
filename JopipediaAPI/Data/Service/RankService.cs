using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class RankService: IRankService
{
      
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    
    public RankService(AppDbContext context,  IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }

    
    async public Task<ServiceResponse<List<RankDTO>>> GetAll()
    {
        var queryableResponse = _context.Ranks
            .OrderBy(r => r.Index)
            .AsQueryable();

        var paginatedUserRanks = await PaginatedResponse<Rank>.CreateAsync(queryableResponse);

        var data = paginatedUserRanks.Data;
        
        return ServiceResponse<List<RankDTO>>
            .Success(_mapper.Map<List<RankDTO>>(data),new MessageResponse(){IsSuccess = true}, paginatedUserRanks.Meta);
    }
    

    async public Task<ServiceResponse<RankDTO>> GetById(Guid id)
    {
        var userRank = await _context.Ranks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRank == null)
            return ServiceResponse<RankDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User Rank not found" });
        return ServiceResponse<RankDTO>
                .Success(_mapper.Map<RankDTO>(userRank));
    }

    async public Task<ServiceResponse<RankDTO>> Create(RankDTO rank)
    {
        var newUserRank = _mapper.Map<Rank>(rank);
        await _context.Ranks.AddAsync(newUserRank);
        await _context.SaveChangesAsync();
        return ServiceResponse<RankDTO>
                .Success(_mapper.Map<RankDTO>(newUserRank), new MessageResponse() { Key = "createdSuccessfully", IsSuccess = true, Value = "Created Successfully" });
    }

    async public Task<ServiceResponse<RankDTO>> Update(Guid id, RankDTO rank)
    {
        
        var userRankToUpdate = await _context.Ranks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRankToUpdate == null)
            return ServiceResponse<RankDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User Rank not found" });
        
        userRankToUpdate.Name = rank.Name ?? RankName.rookie;
        
        _context.Ranks.Update(userRankToUpdate);
        await _context.SaveChangesAsync();
        return ServiceResponse<RankDTO>
            
                .Success(_mapper.Map<RankDTO>(userRankToUpdate), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

   async public Task<ServiceResponse<RankDTO>> Delete(Guid id)
    {
        var userRankToDelete = await _context.Ranks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRankToDelete == null)
            return ServiceResponse<RankDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User Rank not found" });
        
        _context.Ranks.Remove(userRankToDelete);
        await _context.SaveChangesAsync();
        return ServiceResponse<RankDTO>
                .Success(_mapper.Map<RankDTO>(userRankToDelete), new MessageResponse() { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });
    }

    async public Task<ServiceResponse<List<UserDTO>>> Top20Users()
    {
       var topUsers = await _context.Users
            .OrderByDescending(u => u.RankingValue)
            .ToListAsync();
        return ServiceResponse<List<UserDTO>>
            .Success(_mapper.Map<List<UserDTO>>(topUsers), new MessageResponse() { Key = "topUsers", IsSuccess = true, Value = "Top Users" });
    }
}