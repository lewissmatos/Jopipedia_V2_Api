using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Data.Service;

public class AuthService: IAuthService
{
    
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    
    public AuthService(AppDbContext dbContext,  IMapper mapper, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _configuration = configuration;
    }
    
    async public Task<ServiceResponse<LoginResponseDTO>> Login(LoginPayloadDTO loginPayload)
    {
        //Get User
        var user = await _dbContext.Users
            .Include(u => u.Roles)
            .Include(u => u.Rank)
            .Include(u => u.Level)
            .FirstOrDefaultAsync(u => u.Username == loginPayload.Username);
        
        //Check if User Exists
        if (user == null)
            return ServiceResponse<LoginResponseDTO>.BadRequest( "userNotFound","User not found" );

        //Check if User is Active
        if (!user.Status)
            return ServiceResponse<LoginResponseDTO>.BadRequest( "inactiveUser","User Not Active");


        //Check if Password is Correct
        if (!PasswordHasher.VerifyPassword(loginPayload.Password, user.Password))
        {
            return ServiceResponse<LoginResponseDTO>.BadRequest( "wrongPassword","Wrong Password");
        }

        //Get User Data and Token from Helper
        var (data, token) = await GetUserDataAndToken(user);

        return ServiceResponse<LoginResponseDTO>.Success(new LoginResponseDTO() { Token = token, User = data });
    }

    //Create user
    async public Task<ServiceResponse<UserDTO>> SignUp(SignUpPayloadDTO signUpPayload)
    {
        //Check if Email is already in use
        if (await IsEmailInUse(signUpPayload.Email))
            return ServiceResponse<UserDTO>.BadRequest("emailInUse", "Email is already in use");

        //Check if Username is already in use
        if (await IsUserNameInUser(signUpPayload.Username))
            return ServiceResponse<UserDTO>.BadRequest("usernameInUse", "Username is already in use");
        //Create User Object
        var user = _mapper.Map<User>(signUpPayload);
        
        //Hash Password
        user.Password = PasswordHasher.HashPassword(signUpPayload.Password);
        
        //Set First User Rank to Rookie
        var rookieRank = await _dbContext.UserRanks.FirstOrDefaultAsync(r => r.Name == RankName.rookie);
        user.Rank = rookieRank;
        user.RankId = rookieRank.Id;
        //Set User Role
        var role = await _dbContext.UserRoles.FirstOrDefaultAsync(r => r.Name == "common");
        user.Roles = new List<UserRole> { role };
        user.RoleIds = new List<Guid> { role.Id };
        
        //Set User Level
        var userLevel = new UserLevel();
        user.Level = userLevel;

        //Save User Status
        await _dbContext.Users.AddAsync(user);
        // Save Changes
        await _dbContext.SaveChangesAsync();

        var data = _mapper.Map<UserDTO>(user);
        return ServiceResponse<UserDTO>.Success(data);
    }
    

    // Check if Email is already in use
    private async Task<bool> IsEmailInUse(string email)
    {
        return await _dbContext.Users.AnyAsync(x => x.Email == email);
    }
    
    //Check if Username is already in use
    private async Task<bool> IsUserNameInUser(string userName)
    {
        return await _dbContext.Users.AnyAsync(x => x.Username == userName);
    }
    
    //Get User Data and Token
    private async Task<(UserDTO Data, string Token)> GetUserDataAndToken(User user)
    {
        var data = _mapper.Map<UserDTO>(user);
        var token = AuthManager.GenerateToken(_configuration, user);
        return (data, token);
    }
}