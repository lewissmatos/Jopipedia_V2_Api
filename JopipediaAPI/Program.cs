using System.Reflection;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using JopipediaAPI.Data.Framework.MappingProfiles;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.Service;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("corsPolicy",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add Mappers
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AppMappingProfile());
});

// builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var mapper = mappingConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

// Add Services
#region Services
    builder.Services.AddScoped<IAuthService, AuthService>();
    builder.Services.AddScoped<IUserService, UserService>();
    builder.Services.AddScoped<IUserRoleService, UserRoleService>();
    builder.Services.AddScoped<IUserRankService, UserRankService>();
    builder.Services.AddScoped<ITopicService, TopicService>();
    builder.Services.AddScoped<IQuizService, QuizService>();
    builder.Services.AddScoped<IQuestionService, QuestionService>();
    builder.Services.AddScoped<IAnswerService, AnswerService>();
    builder.Services.AddScoped<IScoreService, ScoreService>();
    builder.Services.AddScoped<IStopGameService, StopGameService>();
#endregion

// Add Authenti// Add Authentication and Authorization with JWT to Services
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };

        options.Events = new JwtBearerEvents
        {
            OnChallenge = context =>
            {
                context.HandleResponse();
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Response.ContentType = "application/json";
                var result = JsonConvert.SerializeObject(new { error = "You are not authorized to access this resource" });
                return context.Response.WriteAsync(result);
            },
        };
    });

// Add Controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();

// Add Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme.",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    });

    // c.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
    // {
    //     Description = "Basic Authentication",
    //     Type = SecuritySchemeType.Http,
    //     Scheme = "basic"
    // });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        },
    });
});

// Create the WebApplication.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use the CORS Policy
app.UseCors("corsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Start the WebApplication.
app.Run();