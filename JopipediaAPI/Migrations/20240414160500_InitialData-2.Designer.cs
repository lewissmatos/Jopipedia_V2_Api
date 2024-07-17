﻿// <auto-generated />
using System;
using System.Collections.Generic;
using JopipediaAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JopipediaAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240414160500_InitialData-2")]
    partial class InitialData2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AwardUser", b =>
                {
                    b.Property<Guid>("AwardsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid");

                    b.HasKey("AwardsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AwardUser");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Explanation")
                        .HasColumnType("text");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("boolean");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Award", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("QuizId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Quiz", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("Emoji")
                        .HasColumnType("text");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<string>("Passcode")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FinishedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("boolean");

                    b.Property<List<Guid>>("PlayerIds")
                        .HasColumnType("uuid[]");

                    b.Property<List<Guid>>("RoundIds")
                        .HasColumnType("uuid[]");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("WinnerId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("StopGames");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGameAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("boolean");

                    b.Property<Guid>("RoundId")
                        .HasColumnType("uuid");

                    b.Property<double>("Score")
                        .HasColumnType("double precision");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.HasIndex("UserId");

                    b.ToTable("StopGameAnswers");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGamePlayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("FinalScore")
                        .HasColumnType("double precision");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<Guid>("StopGameId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("StopGameId");

                    b.HasIndex("UserId");

                    b.ToTable("StopGamePlayers");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGameRound", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<List<Guid>>("AnswerIds")
                        .HasColumnType("uuid[]");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Letter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<Guid>("StopGameId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StopGameId");

                    b.ToTable("StopGameRounds");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("925be0e5-2944-4e23-98e7-53843e28f830"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8030),
                            Description = "General Knowledge Quizzes",
                            Status = true,
                            Title = "General-Knowledge",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8030)
                        },
                        new
                        {
                            Id = new Guid("27d78feb-d00f-43d4-bd26-0384b4af0b8c"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040),
                            Description = "Mathematics Quizzes",
                            Status = true,
                            Title = "Mathematics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040)
                        },
                        new
                        {
                            Id = new Guid("934412f5-becd-41c1-a82c-b9ca6fd5eb54"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040),
                            Description = "Biology Quizzes",
                            Status = true,
                            Title = "Biology",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040)
                        },
                        new
                        {
                            Id = new Guid("612cbfc2-a448-45f6-8449-9cbf686c9d21"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050),
                            Description = "Physics Quizzes",
                            Status = true,
                            Title = "Physics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050)
                        },
                        new
                        {
                            Id = new Guid("706249a5-6410-426e-821f-88e1843736fc"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050),
                            Description = "Chemistry Quizzes",
                            Status = true,
                            Title = "Chemistry",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050)
                        },
                        new
                        {
                            Id = new Guid("c4735bbc-9892-4128-b349-7e7d5f355ebb"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060),
                            Description = "History Quizzes",
                            Status = true,
                            Title = "History",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060)
                        },
                        new
                        {
                            Id = new Guid("a1e7a8a5-8a19-4378-9611-e1fb4aff9749"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060),
                            Description = "Geography Quizzes",
                            Status = true,
                            Title = "Geography",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060)
                        },
                        new
                        {
                            Id = new Guid("baefdd5d-d14e-4908-81c4-2a4a6d6f8824"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060),
                            Description = "Computer Science Quizzes",
                            Status = true,
                            Title = "Computer-Science",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060)
                        },
                        new
                        {
                            Id = new Guid("07fadce4-9e21-4ae0-b642-14b5e039da39"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070),
                            Description = "Sports Quizzes",
                            Status = true,
                            Title = "Sports",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070)
                        },
                        new
                        {
                            Id = new Guid("7d2471d8-6bce-4513-9e8a-a38a5df1cf25"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070),
                            Description = "Music Quizzes",
                            Status = true,
                            Title = "Music",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070)
                        },
                        new
                        {
                            Id = new Guid("9298db4d-0baa-4a57-8215-f861cdb09d65"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070),
                            Description = "Movies Quizzes",
                            Status = true,
                            Title = "Movies",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070)
                        });
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<List<Guid>>("FollowerIds")
                        .HasColumnType("uuid[]");

                    b.Property<Guid?>("LevelId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<Guid?>("RankId")
                        .HasColumnType("uuid");

                    b.Property<double>("RankingValue")
                        .HasColumnType("double precision");

                    b.Property<List<Guid>>("RoleIds")
                        .HasColumnType("uuid[]");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LevelId");

                    b.HasIndex("RankId");

                    b.HasIndex("UserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.UserLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Percentage")
                        .HasColumnType("double precision");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserLevels");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.UserRank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("UserRanks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a47e1c3-7537-4aa6-b483-44b68d2b95a5"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000),
                            Name = "rookie",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000)
                        },
                        new
                        {
                            Id = new Guid("de5afc5d-14e5-4011-8e6e-4db76ff20a7d"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000),
                            Name = "beginner",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000)
                        },
                        new
                        {
                            Id = new Guid("b1e04c77-c2ac-47eb-9260-37f351588eed"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010),
                            Name = "intermediate",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010)
                        },
                        new
                        {
                            Id = new Guid("35900138-a6ff-49cf-a33e-94d1ed938d98"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010),
                            Name = "advanced",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010)
                        },
                        new
                        {
                            Id = new Guid("b04ac6ac-16e1-4ac1-99a4-01af4dab2cb0"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010),
                            Name = "expert",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010)
                        },
                        new
                        {
                            Id = new Guid("e2ed6130-6c55-4b64-a32a-1fe76d0c17a2"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8020),
                            Name = "legend",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8020)
                        });
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1815e9f4-3a76-4513-a042-9a95814be238"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7840),
                            Description = "Can Create Topics, Disable Users and Create Events",
                            Name = "ADMIN",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7840)
                        },
                        new
                        {
                            Id = new Guid("9641da9f-2a81-48c0-8549-6e66b2a914ee"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7910),
                            Description = "Can Play Quizzes and Earn EX, Can Play the Stop Game",
                            Name = "COMMON",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7910)
                        });
                });

            modelBuilder.Entity("UserUserRole", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uuid");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("UserUserRole");
                });

            modelBuilder.Entity("AwardUser", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Award", null)
                        .WithMany()
                        .HasForeignKey("AwardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JopipediaAPI.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Answer", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Award", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Question", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Quiz", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Topic", "Topic")
                        .WithMany("Quizzes")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Score", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JopipediaAPI.Data.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGameAnswer", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.StopGameRound", "Round")
                        .WithMany("Answers")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JopipediaAPI.Data.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGamePlayer", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.StopGame", "StopGame")
                        .WithMany("Players")
                        .HasForeignKey("StopGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JopipediaAPI.Data.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StopGame");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGameRound", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.StopGame", "StopGame")
                        .WithMany("Rounds")
                        .HasForeignKey("StopGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StopGame");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Topic", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.User", null)
                        .WithMany("Interests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.User", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.UserLevel", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("JopipediaAPI.Data.Model.UserRank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId");

                    b.HasOne("JopipediaAPI.Data.Model.User", null)
                        .WithMany("Followers")
                        .HasForeignKey("UserId");

                    b.Navigation("Level");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("UserUserRole", b =>
                {
                    b.HasOne("JopipediaAPI.Data.Model.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JopipediaAPI.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGame", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Rounds");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.StopGameRound", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.Topic", b =>
                {
                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("JopipediaAPI.Data.Model.User", b =>
                {
                    b.Navigation("Followers");

                    b.Navigation("Interests");
                });
#pragma warning restore 612, 618
        }
    }
}