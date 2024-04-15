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
    public DbSet<Score> Scores { get; set; }
    public DbSet<Topic> Topics { get; set; }
    
    public DbSet<User> Users { get; set; }

    public DbSet<UserLevel> UserLevels { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UserRank> UserRanks { get; set; }
    public DbSet<StopGame> StopGames { get; set; }
    public DbSet<StopGameRound> StopGameRounds { get; set; }
    public DbSet<StopGamePlayer> StopGamePlayers { get; set; }
    public DbSet<StopGameAnswer> StopGameAnswers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Seed data
        var astrology = new Topic { Id = new  Guid("167219a1-5934-4352-b710-2267cc06a702"), Title = "Astrology", Description = "Astrology Quizzes", Status = true };
        var biology = new Topic { Id = new  Guid("ba339907-d44c-4c30-88ad-478a6b93134a"), Title = "Biology", Description = "Biology Quizzes", Status = true };
        var chemistry = new Topic { Id = new  Guid("01eaf4a0-72c2-4195-a415-d069c8eb9380"), Title = "Chemistry", Description = "Chemistry Quizzes", Status = true };
        var computerScience = new Topic { Id = new  Guid("57d53668-25dc-481d-b24c-9fa454e20d31"), Title = "Computer-Science", Description = "Computer Science Quizzes", Status = true };
        var generalKnowledge = new Topic { Id = new  Guid("0315d1cb-cf1f-4c19-82ca-c8060e1ec265"), Title = "General-Knowledge", Description = "General Knowledge Quizzes", Status = true };
        var geography = new Topic { Id = new  Guid("f141d671-969f-4d7b-b114-53ee325e691a"), Title = "Geography", Description = "Geography Quizzes", Status = true };
        var history = new Topic { Id = new  Guid("12c211b7-4604-4a2d-9d19-8a4b84162d8c"), Title = "History", Description = "History Quizzes", Status = true };
        var mathematics = new Topic { Id = new  Guid("dac47999-47fa-413b-bc26-df7744aacbfe"), Title = "Mathematics", Description = "Mathematics Quizzes", Status = true };
        var movies = new Topic { Id = new  Guid("d5f8620b-c9b4-461b-b417-7b13d461731b"), Title = "Movies", Description = "Movies Quizzes", Status = true };
        var music = new Topic { Id = new  Guid("f72ac747-c9f8-4a13-ab99-1f559ef9a417"), Title = "Music", Description = "Music Quizzes", Status = true };
        var physics = new Topic { Id = new  Guid("9869f417-39c3-449c-8250-1aefe0a7444b"), Title = "Physics", Description = "Physics Quizzes", Status = true };
        var sports = new Topic { Id = new  Guid("ed240c36-6781-4db9-9cd0-514f92d2594e"), Title = "Sports", Description = "Sports Quizzes", Status = true };
   
        var rookie = new UserRank { Id = new  Guid("be247d3a-d360-48e8-965d-6d2179a0020c"), Name = RankName.rookie };
        var beginner = new UserRank { Id  = new Guid("61ffef2e-5dbe-4d5d-80c9-ca3081fd821f"), Name = RankName.beginner };
        var intermediate = new UserRank { Id  = new Guid("486771e2-cd07-4892-a35f-996e2731bd20"), Name = RankName.intermediate };
        var advanced = new UserRank { Id  = new Guid("04484529-d942-4b8e-a07e-b74842c88925"), Name = RankName.advanced };
        var expert = new UserRank { Id = new  Guid("f0ba3200-f315-4b33-afa3-cfdf3db43e00"), Name = RankName.expert };
        var legend = new UserRank { Id = new  Guid("2a03d922-eb06-4354-9ff7-be091fdc5b13"), Name = RankName.legend };
   
        var adminRole = new UserRole { Id = new Guid("5b11963e-6248-4b81-ac6d-402f0ebee3d8"), Name = "admin", Description = "Can Create Topics, Disable Users and Create Events"};
        var commonRole = new UserRole { Id = new Guid("61ff516d-a1c8-44b8-b5b5-cca0853fb28d"), Name = "common", Description = "Can Play Quizzes and Earn EXP, Can Play the Stop Game"};
       
        //Build
        modelBuilder.Entity<Answer>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Award>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Question>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Quiz>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<Score>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<UserLevel>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<UserRank>()
            .HasQueryFilter(e => e.Status == true)
            .HasData(rookie, beginner, intermediate, advanced, expert, legend);

        modelBuilder.Entity<UserRole>().HasQueryFilter(e => e.Status == true)
            .HasData(adminRole, commonRole);
            modelBuilder.Entity<Topic>().HasQueryFilter(e => e.Status == true)
                .HasData(generalKnowledge, mathematics, biology, physics, 
                    chemistry, history, geography, computerScience, sports, music, movies, astrology);
        modelBuilder.Entity<User>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<StopGame>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<StopGameRound>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<StopGamePlayer>().HasQueryFilter(e => e.Status == true);
        modelBuilder.Entity<StopGameAnswer>().HasQueryFilter(e => e.Status == true);

        
            
        
    }
}