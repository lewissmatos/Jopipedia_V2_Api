﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class rebuild4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c986b7f-1ba0-4532-8a3f-22bd05a3caf9"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1490), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1490), null },
                    { new Guid("2ca224bf-b4d9-4df0-a4ab-b960c7e5515c"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), null },
                    { new Guid("4e732e09-d942-4b7c-855c-36adec283dcd"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), null },
                    { new Guid("6610a3cf-951a-42af-a860-9e5c6112b55c"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), null },
                    { new Guid("8b11a9d4-f4a2-4c5d-87f2-fd43cd97865c"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1540), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1540), null },
                    { new Guid("903081b5-83c0-4767-9727-ceaf4759d7ac"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), null },
                    { new Guid("96e35f74-53ba-42c0-87dc-d892250bf627"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), null },
                    { new Guid("9b7d409c-67b4-4457-aae1-62c8fcddc6a8"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1570), null },
                    { new Guid("d2663045-2f68-4e09-9e32-71ddb104c556"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), null },
                    { new Guid("d471fb36-1311-4831-bc2b-26ec368b4216"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1560), null },
                    { new Guid("dc56241a-be32-4ac6-ba48-50929d42fda1"), new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 19, 51, 48, 452, DateTimeKind.Utc).AddTicks(1550), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0c986b7f-1ba0-4532-8a3f-22bd05a3caf9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2ca224bf-b4d9-4df0-a4ab-b960c7e5515c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4e732e09-d942-4b7c-855c-36adec283dcd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6610a3cf-951a-42af-a860-9e5c6112b55c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8b11a9d4-f4a2-4c5d-87f2-fd43cd97865c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("903081b5-83c0-4767-9727-ceaf4759d7ac"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("96e35f74-53ba-42c0-87dc-d892250bf627"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9b7d409c-67b4-4457-aae1-62c8fcddc6a8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d2663045-2f68-4e09-9e32-71ddb104c556"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d471fb36-1311-4831-bc2b-26ec368b4216"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dc56241a-be32-4ac6-ba48-50929d42fda1"));
        }
    }
}