using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
            .Include(u => u.Awards)
            .Include(u => u.Interests)
            .FirstOrDefaultAsync(u => u.Username == loginPayload.Username || u.Email == loginPayload.Username);
        
        //Check if User Exists
        if (user == null)
            return ServiceResponse<LoginResponseDTO>
                    .Success(null,
                        new MessageResponse() { Key = "error", IsSuccess = false, Value = "User not found" });

        //Check if User is Active
        if (!user.Status)
            return ServiceResponse<LoginResponseDTO>
                    .Success(null,
                        new MessageResponse() { Key = "error", IsSuccess = false, Value = "User Not Active" });
        
        if(user.Password.IsNullOrEmpty() && !loginPayload.Password.IsNullOrEmpty())
        {
            var (usr, tk) = await GetUserDataAndToken(user);

            return ServiceResponse<LoginResponseDTO>
                .Success( new LoginResponseDTO() { Token = tk, User = usr }, new MessageResponse
                {
                    IsSuccess = false,
                    Key = "noPassword", 
                    Value = "You've not Generated a Password Yet. Please Use Google Sign In to Login and Generate a Password.",
                }, null);
        }
        // Login with Password
        if (!user.Password.IsNullOrEmpty() && !loginPayload.Password.IsNullOrEmpty())
        {
            
            if (!PasswordHasher.VerifyPassword(loginPayload.Password, user.Password))
            {
                return ServiceResponse<LoginResponseDTO>
                        .Success(null,
                            new MessageResponse() { Key = "wrongPassword", IsSuccess = false, Value = "Wrong Password" });
            }
            user.Password = PasswordHasher.HashPassword(user.Password);
        } 
        // Login with GooglePasscodeId
        else if (!user.GooglePasscodeId.IsNullOrEmpty()) {
            //Verify GooglePasscodeId

            if (!PasswordHasher.VerifyPassword(loginPayload.GooglePasscodeId, user.GooglePasscodeId))
            {
                return ServiceResponse<LoginResponseDTO>
                        .Success(null,
                            new MessageResponse() { Key = "wrongPasscode", IsSuccess = false, Value = "Wrong Google Passcode" });
            }
            user.GooglePasscodeId = PasswordHasher.HashPassword(user.GooglePasscodeId);
        }
        user.HasPassword = user.CheckPassword();
        //Get User Data and Token from Helper
        var (data, token) = await GetUserDataAndToken(user);

        return ServiceResponse<LoginResponseDTO>.Success(new LoginResponseDTO() { Token = token, User = data }, 
            new MessageResponse
            {
                Key = "succesfully", 
                Value = "Login Successfully",
                IsSuccess = true
            }, 
            null);
    }

    //Create user
    async public Task<ServiceResponse<UserDTO>> SignUp(SignUpPayloadDTO signUpPayload)
    {
        
        //Check if Email is already in use
        if (await IsEmailInUse(signUpPayload.Email))
        {
            if (!signUpPayload.GooglePasscodeId.IsNullOrEmpty())
            {
                return await AddGoogleAuthData(new AddGoogleAuthDataDTO()
                {
                    Email = signUpPayload.Email,
                    GooglePasscodeId = signUpPayload.GooglePasscodeId,
                    IsVerified = signUpPayload.IsVerified ?? false,
                    ProfilePicture = signUpPayload.ProfilePicture,
                });
            }
            return ServiceResponse<UserDTO>
                .Success(null,
                    new MessageResponse() { Key = "emailInUse", IsSuccess = false, Value = "Email is already in use" });
        }
        //Check if Username is already in use
        if (await IsUserNameInUser(signUpPayload.Username))
        {
            
            if (!signUpPayload.GooglePasscodeId.IsNullOrEmpty())
            {
                return await AddGoogleAuthData(new AddGoogleAuthDataDTO()
                {
                    Email = signUpPayload.Email,
                    GooglePasscodeId = signUpPayload.GooglePasscodeId,
                    IsVerified = signUpPayload.IsVerified ?? false,
                    ProfilePicture = signUpPayload.ProfilePicture,
                });
            }
            return ServiceResponse<UserDTO>
                    .Success(null,
                        new MessageResponse() { Key = "usernameInUse", IsSuccess = false, Value = "Username is already in use" });
        }
            //Create User Object
        var user = _mapper.Map<User>(signUpPayload);
        
        //Check if it's a basic sign up
        if (!signUpPayload.Password.IsNullOrEmpty())
        {
            //Hash Password
            user.Password = PasswordHasher.HashPassword(signUpPayload.Password);
        } else
        {
            //Hash GooglePasscodeId
            user.GooglePasscodeId = PasswordHasher.HashPassword(signUpPayload.GooglePasscodeId);
        }

        //Set First User Rank to Rookie
        var rookieRank = await _dbContext.Ranks.FirstOrDefaultAsync(r => r.Name == RankName.rookie);
        user.Rank = rookieRank;
        user.RankId = rookieRank.Id;
        //Set User Role
        var role = await _dbContext.UserRoles.FirstOrDefaultAsync(r => r.Name == "common");
        user.Roles = new List<UserRole> { role };
        user.RoleIds = new List<Guid> { role.Id };
        
        //Set User Level
        var userLevel = new UserLevel();
        user.Level = userLevel;
        user.HasPassword = user.CheckPassword();
        //Save User Status
        await _dbContext.Users.AddAsync(user);
        // Save Changes
        await _dbContext.SaveChangesAsync();

        var data = _mapper.Map<UserDTO>(user);
        return ServiceResponse<UserDTO>.Success(data,
                new MessageResponse() { Key = "signUpSuccessfully", IsSuccess = true, Value = "Sign Up Successfully " });
    }

    public async Task<ServiceResponse<UserDTO>> AddGoogleAuthData(AddGoogleAuthDataDTO googleData)
    {
        
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == googleData.Email);
        
        if (user == null)
            return ServiceResponse<UserDTO>
                .Success(null,
                    new MessageResponse
                    {
                        Key = "error",
                        IsSuccess = false,
                        Value = "User not found"
                    });
        
        user.GooglePasscodeId = PasswordHasher.HashPassword(googleData.GooglePasscodeId);
        user.IsVerified = googleData.IsVerified;
        user.ProfilePicture = googleData.ProfilePicture;
        
        await _dbContext.SaveChangesAsync();
        var data = _mapper.Map<UserDTO>(user);
        return ServiceResponse<UserDTO>.Success(data,
            new MessageResponse() { Key = "signUpSuccessfully", IsSuccess = true, Value = "Sign Up Successfully, you've also verified your user" });
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