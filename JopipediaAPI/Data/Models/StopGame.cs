using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Model;

[Index(nameof(Code), IsUnique = true)]

public class StopGame : BaseModel
{
    public Guid Id { get; set; }
    public List<StopGamePlayer>? Players { get; set; }
    public List<Guid>? PlayerIds { get; set; }
    public List<StopGameRound>? Rounds { get; set; }
    public List<Guid>? RoundIds { get; set; }
    [NotMapped]
    public StopGamePlayer? Winner { get; set; }
    public Guid? WinnerId { get; set; }
    [MaxLength(10)]
    public string? Code { get; set; }

    public bool IsFinished { get; set; } = false;
    public DateTime FinishedAt { get; set; }
}