using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class UserRankService: IUserRankService
{
      
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    
    public UserRankService(AppDbContext dbContext,  IMapper mapper, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _configuration = configuration;
    }

    
    async public Task<ServiceResponse<List<UserRankDTO>>> GetAll()
    {
        var userRanks = await _dbContext.UserRanks.ToListAsync();
        return ServiceResponse<List<UserRankDTO>>.Success(_mapper.Map<List<UserRankDTO>>(userRanks));
    }
    

    async public Task<ServiceResponse<UserRankDTO>> GetById(Guid id)
    {
        var userRank = await _dbContext.UserRanks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRank == null)
            return ServiceResponse<UserRankDTO>.NotFound("userRankNotFound", "User Rank not found");
        return ServiceResponse<UserRankDTO>.Success(_mapper.Map<UserRankDTO>(userRank));
    }

    async public Task<ServiceResponse<UserRankDTO>> Create(UserRankDTO userRank)
    {
        var newUserRank = _mapper.Map<UserRank>(userRank);
        await _dbContext.UserRanks.AddAsync(newUserRank);
        await _dbContext.SaveChangesAsync();
        return ServiceResponse<UserRankDTO>.Success(_mapper.Map<UserRankDTO>(newUserRank));
    }

    async public Task<ServiceResponse<UserRankDTO>> Update(Guid id, UserRankDTO userRank)
    {
        
        var userRankToUpdate = await _dbContext.UserRanks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRankToUpdate == null)
            return ServiceResponse<UserRankDTO>.NotFound("userRankNotFound", "User Rank not found");
        
        userRankToUpdate.Name = userRank.Name ?? RankName.rookie;
        
        _dbContext.UserRanks.Update(userRankToUpdate);
        await _dbContext.SaveChangesAsync();
        return ServiceResponse<UserRankDTO>.Success(_mapper.Map<UserRankDTO>(userRankToUpdate));
    }

   async public Task<ServiceResponse<UserRankDTO>> Delete(Guid id)
    {
        var userRankToDelete = await _dbContext.UserRanks.FirstOrDefaultAsync(u => u.Id == id);
        if (userRankToDelete == null)
            return ServiceResponse<UserRankDTO>.NotFound("userRankNotFound", "User Rank not found");
        
        _dbContext.UserRanks.Remove(userRankToDelete);
        await _dbContext.SaveChangesAsync();
        return ServiceResponse<UserRankDTO>.Success(_mapper.Map<UserRankDTO>(userRankToDelete));
    }
}