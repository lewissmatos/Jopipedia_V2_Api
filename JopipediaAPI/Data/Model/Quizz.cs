using System.ComponentModel.DataAnnotations;

namespace JopipediaAPI.Data.Model;

public class Quizz
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    [MaxLength(400)]
    public string? Description { get; set; }
    public string? Color { get; set; }
    public string? Emoji { get; set; }
    public string? Tags { get; set; }
    public bool IsPrivate { get; set; }
    public string? Keyword { get; set; }
}