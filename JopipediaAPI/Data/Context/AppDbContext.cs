using JopipediaAPI.Data.Model;
using Microsoft.EntityFrameworkCore;
namespace JopipediaAPI.Data.Context;

public class AppDbContext: DbContext
{ 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Answer> Answers { get; set; }
    public DbSet<Award> Awards { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<UserRank> UserRanks { get; set; }
    public DbSet<Score> Scores { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserLevel> UserLevels { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Award>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Question>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Quiz>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<UserRank>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Score>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Topic>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<User>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<UserLevel>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<UserRole>().HasQueryFilter(e => e.Status == true);
    }
}