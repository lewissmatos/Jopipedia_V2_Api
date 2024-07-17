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
    [Migration("20240414164039_InitialData-11")]
    partial class InitialData11
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
                            Id = new Guid("0e9df3dd-4b46-4151-8267-6825c8c95833"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200),
                            Description = "General Knowledge Quizzes",
                            Status = true,
                            Title = "General-Knowledge",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200)
                        },
                        new
                        {
                            Id = new Guid("195812f8-5183-44d0-a5f3-2fba04c8aee0"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200),
                            Description = "Mathematics Quizzes",
                            Status = true,
                            Title = "Mathematics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200)
                        },
                        new
                        {
                            Id = new Guid("f4bad48e-0751-45b0-bcf5-67265174375e"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210),
                            Description = "Biology Quizzes",
                            Status = true,
                            Title = "Biology",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210)
                        },
                        new
                        {
                            Id = new Guid("3cae74c5-3ed0-4e0d-89fd-d4af3fca2f57"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210),
                            Description = "Physics Quizzes",
                            Status = true,
                            Title = "Physics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210)
                        },
                        new
                        {
                            Id = new Guid("4b0a4d4e-e5d6-4a4d-9bfc-ae51991737a5"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210),
                            Description = "Chemistry Quizzes",
                            Status = true,
                            Title = "Chemistry",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210)
                        },
                        new
                        {
                            Id = new Guid("5fd91532-a809-4f21-a0e9-42cd1acd13f1"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220),
                            Description = "History Quizzes",
                            Status = true,
                            Title = "History",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220)
                        },
                        new
                        {
                            Id = new Guid("47e195db-7170-4c09-9289-11e3d7917125"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220),
                            Description = "Geography Quizzes",
                            Status = true,
                            Title = "Geography",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220)
                        },
                        new
                        {
                            Id = new Guid("1eaf9105-10d6-4d99-8b34-66816532a822"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220),
                            Description = "Computer Science Quizzes",
                            Status = true,
                            Title = "Computer-Science",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230)
                        },
                        new
                        {
                            Id = new Guid("5e840649-7efe-41da-9f18-cb1eeee2b8e1"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230),
                            Description = "Sports Quizzes",
                            Status = true,
                            Title = "Sports",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230)
                        },
                        new
                        {
                            Id = new Guid("fc60f1b0-af15-4b75-b75b-574f910c878b"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230),
                            Description = "Music Quizzes",
                            Status = true,
                            Title = "Music",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230)
                        },
                        new
                        {
                            Id = new Guid("aa413ed7-1409-49b3-a5d2-f05b71a2055d"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8240),
                            Description = "Movies Quizzes",
                            Status = true,
                            Title = "Movies",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8240)
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
                            Id = new Guid("5acce8a3-fc1b-4da7-8259-8c916b8aa928"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170),
                            Name = "rookie",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170)
                        },
                        new
                        {
                            Id = new Guid("2f0d6c4c-8c2f-4f34-9f76-ffabebd38e9b"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170),
                            Name = "beginner",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170)
                        },
                        new
                        {
                            Id = new Guid("37b1b993-8173-41e6-97f4-d2a2e06f5fe8"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180),
                            Name = "intermediate",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180)
                        },
                        new
                        {
                            Id = new Guid("8cbb8cff-28f2-4325-a8f6-34387f1b2bfd"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180),
                            Name = "advanced",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180)
                        },
                        new
                        {
                            Id = new Guid("0cdc2ff8-6089-45e6-b2b1-edf5941afe5e"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180),
                            Name = "expert",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180)
                        },
                        new
                        {
                            Id = new Guid("42ad055f-97d2-4871-ba74-41bfbcdbd68d"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8190),
                            Name = "legend",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8190)
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
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("500cd21a-883b-420b-8015-5d26a6e42e10"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8100),
                            Description = "Can Create Topics, Disable Users and Create Events",
                            Name = "ADMIN",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8100)
                        },
                        new
                        {
                            Id = new Guid("fc4aa4c5-43e1-41e2-8db2-0ec36fff1e1b"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8120),
                            Description = "Can Play Quizzes and Earn EX, Can Play the Stop Game",
                            Name = "COMMON",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8120)
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