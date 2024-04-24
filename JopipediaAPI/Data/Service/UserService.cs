using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service;

public class UserService: IUserService
{
    
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    
    
    // Constructor
    public UserService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public  Task<ServiceResponse<List<UserDTO>>> GetAll(UserFiltersDTO filters)
    {
        var queryableResponse = _context.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Awards)
            .Include(u => u.Level)
            .AsQueryable();

        var paginatedUsers = await PaginatedResponse<User>
            .CreateAsync(queryableResponse, filters.Page, filters.Take);
        
        var data  = _mapper.Map<List<UserDTO>>(paginatedUsers.Data);
        return ServiceResponse<List<UserDTO>>.Success(data, new MessageResponse(){IsSuccess = true}, paginatedUsers.Meta);
    }

    async public Task<ServiceResponse<UserDTO>> GetById(Guid id)
    {
        //Get user by id
        var user = await  _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        user.HasPassword = user.CheckPassword();
        return ServiceResponse<UserDTO>.Success(_mapper.Map<UserDTO>(user), 
            new MessageResponse() { Key = "succcess", IsSuccess = true, Value = "User found successfully" });
    }

    async public Task<ServiceResponse<UserDTO>> Update(Guid id, UpdateUserPayloadDTO updateUserPayload)
    {
        // Get user to update
        var user = await _context.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Level)
            .Include(u => u.Awards)
            .Include(u => u.Interests)
            .FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "found not found" });
        }
        
        if (await IsEmailInUse(updateUserPayload.Email, user.Id))
        {
            return ServiceResponse<UserDTO>
                .Success(null,
                    new MessageResponse() { Key = "emailInUse", IsSuccess = false, Value = "Email is already in use" });
        }
        //Check if Username is already in use
        if (await IsUserNameInUser(updateUserPayload.Username, user.Id))
        {
            return ServiceResponse<UserDTO>
                .Success(null,
                    new MessageResponse() { Key = "usernameInUse", IsSuccess = false, Value = "Username is already in use" });
        }
        
        
        //Initialize user roles and awards
        var userRoles = new List<UserRole>();
        var userAwards = new List<Award>();
        var userInterests = new List<Topic>();
        // Get user roles, awards and rank
        if(updateUserPayload.RoleIds != null)
        {
            userRoles = await _context.UserRoles.Where(ur => updateUserPayload.RoleIds.Contains(ur.Id)).ToListAsync();
        }
        else
        {
            userRoles = user.Roles;
        }
        
        if(updateUserPayload.AwardIds != null)
        {
            userAwards = await _context.Awards.Where(a => updateUserPayload.AwardIds.Contains(a.Id)).ToListAsync();
        }
        else
        {
            userAwards = user.Awards;
        }

        if (updateUserPayload.InterestIds != null)
        {
            userInterests = await _context.Topics.Where(t => updateUserPayload.InterestIds.Contains(t.Id)).ToListAsync();
        }
        else
        {
            userInterests = user.Interests;
        }
        
        updateUserPayload.Id = user.Id;
        // Map update payload to user
        _mapper.Map(updateUserPayload, user);
        var userRank = await _context.Ranks.FirstOrDefaultAsync(r => r.Id == updateUserPayload.RankId);
        var userLevel = await _context.UserLevels.FirstOrDefaultAsync(l => l.Id == updateUserPayload.LevelId);
        
        // Update user roles, awards, rank level, and interests 
        user.Awards = userAwards;
        user.Rank = userRank;
        user.Roles = userRoles;
        user.Level = userLevel;
        user.Interests = userInterests;
        user.HasPassword = user.CheckPassword();

        // Save changes
        await _context.SaveChangesAsync();

        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }
    
    async public Task<ServiceResponse<UserDTO>> Disable(Guid id)
    {
        //Get user to disable
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        // Disable user
        user.Status = false;
        //Save changes
        await _context.SaveChangesAsync();
        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "disabledSuccessfully", IsSuccess = true, Value = "Disabled Successfully" });
    }

    async public Task<ServiceResponse<UserDTO>> Delete(Guid id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        // Delete user
        _context.Users.Remove(user);
        // Save changes
        await _context.SaveChangesAsync();
        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "deletedSuccessfully", IsSuccess = true, Value = "Deleted Successfully" });
    }

    async public Task<ServiceResponse<UserDTO>> UpdateUserLevel(Guid id, double value)
    {
        var user = await _context.Users
            .Include(u => u.Level)
            .FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        // Update user level
        double currentUserLevelPercentage = user.Level.Percentage;
        if (currentUserLevelPercentage + value >= 100)
        {
            // Increase user level
            user.Level.Value += 1;
            // Reset user level percentage
            user.Level.Percentage = 0;
        }
        else
        {
            // Increase user level percentage
            user.Level.Percentage += value;
        }
        await _context.SaveChangesAsync();

        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });

    }
    
    async public Task<ServiceResponse<UserDTO>> UpdateUserRank(Guid id, double value)
    {
       
        var user = await _context.Users
            .Include(u => u.Rank)
            
            .FirstOrDefaultAsync(u => u.Id == id);
        
        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        
        // Update user ranking value
        user.RankingValue += value;
        
        
        // Update user rank
        
        /*
           From 1 to 500: rookie
           From 501 to 1500: beginner
           From 1501 to 3000: intermediate
           From 3001 to 5000: advanced
           From 5001 to 10000: expert
           + 10001: legend
       */

        if (user.RankingValue >= 10000)
        {
            user.Rank.Name = RankName.legend;
        }
        else if (user.RankingValue >= 5001)
        {
            user.Rank.Name = RankName.expert;
        }
        else if (user.RankingValue >= 3001)
        {
            user.Rank.Name = RankName.advanced;
        }
        else if (user.RankingValue >= 1501)
        {
            user.Rank.Name = RankName.intermediate;
        }
        else if (user.RankingValue >= 501)
        {
            user.Rank.Name = RankName.beginner;
        }
        else
        {
            user.Rank.Name = RankName.rookie;
        }
        
        await _context.SaveChangesAsync();
        
        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    public async Task<ServiceResponse<UserDTO>> UpdatePassword(Guid userId, UpdatePasswordDTO updatePasswordDTO)
    {
        var user = await _context.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Level)
            .Include(u => u.Awards)
            .Include(u => u.Interests)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        
        // Check if current password is correct
        if (!PasswordHasher.VerifyPassword(updatePasswordDTO.CurrentPassword, user.Password))
        {
            return ServiceResponse<UserDTO>
                    .Success(null, new MessageResponse() { Key = "incorrectPassword", IsSuccess = false, Value = "Incorrect Current Password" });
        }
        
        // Hash new password
        user.Password = PasswordHasher.HashPassword(updatePasswordDTO.NewPassword);
        user.HasPassword = user.CheckPassword();
        var data = _mapper.Map<UserDTO>(user);
        await _context.SaveChangesAsync();
        return ServiceResponse<UserDTO>
                .Success(data, new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });

    }

    public async Task<ServiceResponse<UserDTO>> GeneratePassword(Guid userId, string password)
    {
        var user = await _context.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Level)
            .Include(u => u.Awards)
            .Include(u => u.Interests)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return ServiceResponse<UserDTO>
                .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        
        // Hash  password
        user.Password = PasswordHasher.HashPassword(password);
        user.HasPassword = user.CheckPassword();
        
        var data = _mapper.Map<UserDTO>(user);
        await _context.SaveChangesAsync();

        return ServiceResponse<UserDTO>
                .Success(data, new MessageResponse() { Key = "generatedSuccessfully", IsSuccess = true, Value = "Generated Successfully" });
        
    }

    public async Task<ServiceResponse<UserDTO>> UpdateMyIntrerests(Guid userId, UpdateUserInterestsDTO interestDTO)
    {
        var user = await _context.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Level)
            .Include(u => u.Awards)
            .Include(u => u.Interests)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return ServiceResponse<UserDTO>
                .Success(null, new MessageResponse() { Key = "notFound", IsSuccess = false, Value = "User not found" });
        }
        
        var interests = await _context.Topics.Where(t => interestDTO.InterestIds.Contains(t.Id)).ToListAsync();
        user.Interests = interests;
        user.HasPassword = user.CheckPassword();
        await _context.SaveChangesAsync();
        return ServiceResponse<UserDTO>
                .Success(_mapper.Map<UserDTO>(user), new MessageResponse() { Key = "updatedSuccessfully", IsSuccess = true, Value = "Updated Successfully" });
    }

    private async Task<bool> IsEmailInUse(string email, Guid userId)
    {
        return await _context.Users.AnyAsync(x => x.Email == email && x.Id != userId);
    }
    
    //Check if Username is already in use
    private async Task<bool> IsUserNameInUser(string userName, Guid userId)
    {
        return await _context.Users.AnyAsync(x => x.Username == userName&& x.Id != userId);
    }
}