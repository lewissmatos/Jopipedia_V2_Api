﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class rebuild1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0b686d21-3aed-4ded-98ce-360530899fdb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1403adf2-85f4-438a-8fbf-259f705336a2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("626e63ee-25ef-4f19-93f4-d8cc1f1695fc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7a9a9358-8692-4039-a525-623a41e74683"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("843a4098-103e-4e2b-bad7-928badfea388"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("84fd355e-b453-4200-8716-8514fa6ec9ce"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bb9e1259-84e1-4a2e-9126-b5675e70655a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c4e679d0-468e-4b0a-814f-45aeee54dc9e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e136d580-306a-43ae-ab9d-f2474c78aef2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e19f2668-4bab-42e3-b392-312d6884582c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e4f82421-2283-4318-8dc4-b43442bed7b6"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("42863b2a-99d5-47c3-b05f-8e1bc3f10599"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bcd15ba8-79be-4a42-8478-2c83031ee71a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("cae28ec7-0eaa-47ec-b94c-21454ddc2f23"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("ef3a877a-17dd-4ce1-a433-0bc4d00fb62d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f4ec59b9-8104-46e7-aff0-b6e81d8d73c1"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fd645d2b-9912-400e-9d24-19ea3697ccb8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b52f228e-887a-4674-b977-3bd94bb9d6c2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd6fa741-f763-471c-8af3-c2d471e0e305"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b686d21-3aed-4ded-98ce-360530899fdb"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6950), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6950), null },
                    { new Guid("1403adf2-85f4-438a-8fbf-259f705336a2"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6920), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6920), null },
                    { new Guid("626e63ee-25ef-4f19-93f4-d8cc1f1695fc"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6910), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6910), null },
                    { new Guid("7a9a9358-8692-4039-a525-623a41e74683"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6920), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6930), null },
                    { new Guid("843a4098-103e-4e2b-bad7-928badfea388"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), null },
                    { new Guid("84fd355e-b453-4200-8716-8514fa6ec9ce"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6930), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6930), null },
                    { new Guid("bb9e1259-84e1-4a2e-9126-b5675e70655a"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6950), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6950), null },
                    { new Guid("c4e679d0-468e-4b0a-814f-45aeee54dc9e"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6930), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6930), null },
                    { new Guid("e136d580-306a-43ae-ab9d-f2474c78aef2"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), null },
                    { new Guid("e19f2668-4bab-42e3-b392-312d6884582c"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6940), null },
                    { new Guid("e4f82421-2283-4318-8dc4-b43442bed7b6"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6920), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6920), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("42863b2a-99d5-47c3-b05f-8e1bc3f10599"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6900), "advanced", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6900) },
                    { new Guid("bcd15ba8-79be-4a42-8478-2c83031ee71a"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6900), "intermediate", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6900) },
                    { new Guid("cae28ec7-0eaa-47ec-b94c-21454ddc2f23"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6910), "legend", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("ef3a877a-17dd-4ce1-a433-0bc4d00fb62d"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6890), "beginner", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("f4ec59b9-8104-46e7-aff0-b6e81d8d73c1"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6870), "rookie", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6870) },
                    { new Guid("fd645d2b-9912-400e-9d24-19ea3697ccb8"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6900), "expert", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6910) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b52f228e-887a-4674-b977-3bd94bb9d6c2"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6960), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6960) },
                    { new Guid("bd6fa741-f763-471c-8af3-c2d471e0e305"), new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6960), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 18, 24, 48, 25, DateTimeKind.Utc).AddTicks(6960) }
                });
        }
    }
}
