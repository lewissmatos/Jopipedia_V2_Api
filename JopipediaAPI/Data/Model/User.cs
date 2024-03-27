using System.ComponentModel.DataAnnotations;

namespace JopipediaAPI.Data.Model;

public class User
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }   
    [MaxLength(30)]
    public string Username { get; set; }
    [MaxLength(100)]
    public string Email { get; set; }
    public string? Password { get; set; }
    public UserLevel Level { get; set; }
    public List<User> Followers { get; set; }
    public List<UserRole> Roles { get; set; }
}