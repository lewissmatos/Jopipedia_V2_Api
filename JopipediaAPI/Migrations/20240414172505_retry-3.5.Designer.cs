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
    [Migration("20240414172505_retry-3.5")]
    partial class retry35
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
                            Id = new Guid("4fccbf78-dab2-4b39-be8f-c48b50033b6a"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540),
                            Description = "General Knowledge Quizzes",
                            Status = true,
                            Title = "General-Knowledge",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540)
                        },
                        new
                        {
                            Id = new Guid("751c1f86-3a5e-40ec-ae88-90512ed0d787"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550),
                            Description = "Mathematics Quizzes",
                            Status = true,
                            Title = "Mathematics",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550)
                        },
                        new
                        {
                            Id = new Guid("797d6769-162a-4f25-a4f1-3b3017921a09"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550),
                            Description = "Biology Quizzes",
                            Status = true,
                            Title = "Biology",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550)
                        },
                        new
                        {
                            Id = new Guid("2f180c7c-5d8c-4a60-985d-4256d5d3511c"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4560),
                            Description = "Physics Quizzes",
                            Status = true,
                            Title = "Physics",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4560)
                        },
                        new
                        {
                            Id = new Guid("0b5ccd02-20dd-4296-8db9-505ef453a538"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580),
                            Description = "Chemistry Quizzes",
                            Status = true,
                            Title = "Chemistry",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580)
                        },
                        new
                        {
                            Id = new Guid("a9468987-4ab5-4703-8fcf-eebedfc01eec"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580),
                            Description = "History Quizzes",
                            Status = true,
                            Title = "History",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580)
                        },
                        new
                        {
                            Id = new Guid("96aafcd0-9d63-43a7-8261-4f31e9bf6c58"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580),
                            Description = "Geography Quizzes",
                            Status = true,
                            Title = "Geography",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580)
                        },
                        new
                        {
                            Id = new Guid("4a316445-94c4-471f-a33c-efc2db5fd471"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590),
                            Description = "Computer Science Quizzes",
                            Status = true,
                            Title = "Computer-Science",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590)
                        },
                        new
                        {
                            Id = new Guid("04d9a2fc-05df-43c2-8b6c-809aee4038e7"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590),
                            Description = "Sports Quizzes",
                            Status = true,
                            Title = "Sports",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590)
                        },
                        new
                        {
                            Id = new Guid("bd957e23-9eb9-4bf5-84b5-91157d776160"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590),
                            Description = "Music Quizzes",
                            Status = true,
                            Title = "Music",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590)
                        },
                        new
                        {
                            Id = new Guid("0804f66f-4c8e-441e-afaa-61100931975e"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4600),
                            Description = "Movies Quizzes",
                            Status = true,
                            Title = "Movies",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4600)
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
                            Id = new Guid("820f1d62-369d-4b7b-9195-083e861c542f"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4490),
                            Name = "rookie",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4490)
                        },
                        new
                        {
                            Id = new Guid("2eb1cc81-cea2-432d-9a26-bbdb82954ef1"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4520),
                            Name = "beginner",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4520)
                        },
                        new
                        {
                            Id = new Guid("f815abea-aff3-4e72-85a3-ad9df86be93e"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530),
                            Name = "intermediate",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530)
                        },
                        new
                        {
                            Id = new Guid("bb77d7db-9580-477b-b077-92c84b217aff"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530),
                            Name = "advanced",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530)
                        },
                        new
                        {
                            Id = new Guid("f6424503-ad4b-4d0e-b90b-f66a55d84cdd"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530),
                            Name = "expert",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530)
                        },
                        new
                        {
                            Id = new Guid("5d53bb93-bee5-4ce3-88e1-f26d49b74259"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540),
                            Name = "legend",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540)
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
                            Id = new Guid("f85f6359-6ad2-4551-acbe-c33656aec27c"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610),
                            Description = "Can Create Topics, Disable Users and Create Events",
                            Name = "ADMIN",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610)
                        },
                        new
                        {
                            Id = new Guid("5a55129b-c844-4c32-95e1-c4a430d7a540"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610),
                            Description = "Can Play Quizzes and Earn EX, Can Play the Stop Game",
                            Name = "COMMON",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610)
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
