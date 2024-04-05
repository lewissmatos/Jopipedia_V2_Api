using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Model;

namespace JopipediaAPI.Data.Framework.Helpers
{
	public class AuthManager
	{
        public static string GenerateToken(IConfiguration _config, User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Email", user.Email),
                new Claim("UserId", user.Id.ToString()),
                //new Claim(ClaimTypes.Role, user.Role.Name),
            };

            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddDays(1), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static string GenerateToken(IConfiguration _config, UserDTO user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Email", user.Email),
                new Claim("Username", user.Username),
                new Claim("UserId", user.Id.ToString()),
            };

            var token = new JwtSecurityToken(claims: claims, /*expires: DateTime.Now.AddDays(1),*/ signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static UserDTO? GetCurrentUser(HttpContext _context)
        {
            var identity = _context.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                string userId = userClaims.FirstOrDefault(o => o.Type == "UserId")?.Value;
                string username = userClaims.FirstOrDefault(o => o.Type == "Username")?.Value;
                string email = userClaims.FirstOrDefault(o => o.Type == "Email")?.Value;

                return new UserDTO
                {
                    Id = new Guid(userId),
                    Username = username,
                    Email = email,
                };
            }

            return null;
        }
    }
}

