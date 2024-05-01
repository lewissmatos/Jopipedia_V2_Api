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
    [Migration("20240414171944_retry-2")]
    partial class retry2
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
                            Id = new Guid("3de1ebef-cfe1-4246-a537-4ab108d871f3"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9020),
                            Description = "General Knowledge Quizzes",
                            Status = true,
                            Title = "General-Knowledge",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9020)
                        },
                        new
                        {
                            Id = new Guid("166b7711-6753-4649-b892-fb54fa02e87f"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030),
                            Description = "Mathematics Quizzes",
                            Status = true,
                            Title = "Mathematics",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030)
                        },
                        new
                        {
                            Id = new Guid("6a3708be-a7e0-4dd2-8daf-1b8406653c99"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030),
                            Description = "Biology Quizzes",
                            Status = true,
                            Title = "Biology",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030)
                        },
                        new
                        {
                            Id = new Guid("35010f53-46bd-417d-ad2f-422c55540d02"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030),
                            Description = "Physics Quizzes",
                            Status = true,
                            Title = "Physics",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030)
                        },
                        new
                        {
                            Id = new Guid("4675098c-4c3d-43ae-a6b9-089cab6d6b79"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040),
                            Description = "Chemistry Quizzes",
                            Status = true,
                            Title = "Chemistry",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040)
                        },
                        new
                        {
                            Id = new Guid("a2dd800c-4e06-46e6-9546-d70765a4e43a"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040),
                            Description = "History Quizzes",
                            Status = true,
                            Title = "History",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040)
                        },
                        new
                        {
                            Id = new Guid("abe98df5-188b-47d4-8ea8-fc3c646ee87c"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050),
                            Description = "Geography Quizzes",
                            Status = true,
                            Title = "Geography",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050)
                        },
                        new
                        {
                            Id = new Guid("43cdab9e-6697-4dcb-906a-426057efaad0"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050),
                            Description = "Computer Science Quizzes",
                            Status = true,
                            Title = "Computer-Science",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050)
                        },
                        new
                        {
                            Id = new Guid("503aa484-478b-4f2f-a2ce-79cf9b68240f"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050),
                            Description = "Sports Quizzes",
                            Status = true,
                            Title = "Sports",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050)
                        },
                        new
                        {
                            Id = new Guid("541b994f-af8d-47c4-83e3-bd3db76b28a3"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060),
                            Description = "Music Quizzes",
                            Status = true,
                            Title = "Music",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060)
                        },
                        new
                        {
                            Id = new Guid("a9a06ffe-c17d-41fe-b43e-5083e5c8acc8"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060),
                            Description = "Movies Quizzes",
                            Status = true,
                            Title = "Movies",
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060)
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
                            Id = new Guid("7d833732-c405-414a-aaa6-eb82810132ce"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(8970),
                            Name = "rookie",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(8970)
                        },
                        new
                        {
                            Id = new Guid("ee83ef3c-5634-42ec-a894-d030f3c52073"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000),
                            Name = "beginner",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000)
                        },
                        new
                        {
                            Id = new Guid("2af9e98f-0efd-42d6-91a1-eceb42e5944f"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000),
                            Name = "intermediate",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000)
                        },
                        new
                        {
                            Id = new Guid("c6459277-de88-4a4a-b14a-93024546ba1c"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000),
                            Name = "advanced",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010)
                        },
                        new
                        {
                            Id = new Guid("23f2782f-7b09-4211-941c-a9d1053b5e09"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010),
                            Name = "expert",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010)
                        },
                        new
                        {
                            Id = new Guid("e3bcc20f-fedc-4dc6-b3fe-53aaeba48638"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010),
                            Name = "legend",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010)
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
                            Id = new Guid("cd4f7bc7-7b74-41d1-96fd-d837a92eae14"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070),
                            Description = "Can Create Topics, Disable Users and Create Events",
                            Name = "ADMIN",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070)
                        },
                        new
                        {
                            Id = new Guid("41a03351-b5b3-4205-ab60-4207d27694d8"),
                            CreatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070),
                            Description = "Can Play Quizzes and Earn EX, Can Play the Stop Game",
                            Name = "COMMON",
                            Status = true,
                            UpdatedAt = new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070)
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
