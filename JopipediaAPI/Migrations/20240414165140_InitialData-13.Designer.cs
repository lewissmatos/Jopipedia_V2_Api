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
    [Migration("20240414165140_InitialData-13")]
    partial class InitialData13
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
                            Id = new Guid("eeeaff63-0ae2-43ee-909a-39b711bd52f4"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640),
                            Description = "General Knowledge Quizzes",
                            Status = true,
                            Title = "General-Knowledge",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640)
                        },
                        new
                        {
                            Id = new Guid("cb7261c4-ed57-4b49-a2f2-8efe0d59f087"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650),
                            Description = "Mathematics Quizzes",
                            Status = true,
                            Title = "Mathematics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650)
                        },
                        new
                        {
                            Id = new Guid("b3078986-4716-4cd9-b7bd-38e1b1a8ae48"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650),
                            Description = "Biology Quizzes",
                            Status = true,
                            Title = "Biology",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650)
                        },
                        new
                        {
                            Id = new Guid("3cf499c4-16fd-4102-9873-6be06ec5978a"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650),
                            Description = "Physics Quizzes",
                            Status = true,
                            Title = "Physics",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650)
                        },
                        new
                        {
                            Id = new Guid("34c0add8-c27d-4c58-9efa-bff2b6b20ae2"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660),
                            Description = "Chemistry Quizzes",
                            Status = true,
                            Title = "Chemistry",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660)
                        },
                        new
                        {
                            Id = new Guid("7a6acf6a-17f2-4f9d-b0d7-68fd1b595638"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660),
                            Description = "History Quizzes",
                            Status = true,
                            Title = "History",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660)
                        },
                        new
                        {
                            Id = new Guid("a6f0d59c-a698-4cf5-acab-06d36e139e4e"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670),
                            Description = "Geography Quizzes",
                            Status = true,
                            Title = "Geography",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670)
                        },
                        new
                        {
                            Id = new Guid("908adf4e-c7f1-4a39-bf22-49f985a2bb56"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670),
                            Description = "Computer Science Quizzes",
                            Status = true,
                            Title = "Computer-Science",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670)
                        },
                        new
                        {
                            Id = new Guid("2d74048d-e5d9-483b-b8dd-715c33826b3b"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670),
                            Description = "Sports Quizzes",
                            Status = true,
                            Title = "Sports",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670)
                        },
                        new
                        {
                            Id = new Guid("e8129e21-a06c-44aa-9f76-6254631ed48c"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680),
                            Description = "Music Quizzes",
                            Status = true,
                            Title = "Music",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680)
                        },
                        new
                        {
                            Id = new Guid("0dbcd044-f48f-45d1-bc1d-e151a9ad4efb"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680),
                            Description = "Movies Quizzes",
                            Status = true,
                            Title = "Movies",
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680)
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
                            Id = new Guid("ffea7f7c-27f9-4650-b11b-f8f81d12f84d"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570),
                            Name = "rookie",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570)
                        },
                        new
                        {
                            Id = new Guid("711060c0-0ad9-4f95-90da-a18650251c28"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620),
                            Name = "beginner",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620)
                        },
                        new
                        {
                            Id = new Guid("edf95d57-d45e-4c00-a2a2-487ea3ab99f7"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620),
                            Name = "intermediate",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620)
                        },
                        new
                        {
                            Id = new Guid("91acca60-e278-4185-be48-e28606313224"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630),
                            Name = "advanced",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630)
                        },
                        new
                        {
                            Id = new Guid("4b6c10df-c6ad-4b15-bc40-05bd5fedd8a3"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630),
                            Name = "expert",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630)
                        },
                        new
                        {
                            Id = new Guid("fc2dbc71-9e89-44a1-937f-ea3e52fda480"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630),
                            Name = "legend",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630)
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
                            Id = new Guid("1ce4a4d0-2998-478c-b016-5412a0a88e50"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690),
                            Description = "Can Create Topics, Disable Users and Create Events",
                            Name = "ADMIN",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690)
                        },
                        new
                        {
                            Id = new Guid("b87b2b0f-dbf6-4dbb-89cb-f6dde10aa428"),
                            CreatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690),
                            Description = "Can Play Quizzes and Earn EX, Can Play the Stop Game",
                            Name = "COMMON",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690)
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
