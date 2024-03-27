using System.ComponentModel.DataAnnotations;

namespace JopipediaAPI.Data.Model;

public class UserRole
{
    public Guid Id { get; set; }
    [MaxLength(80)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    public List<User> Users { get; set; }
}

