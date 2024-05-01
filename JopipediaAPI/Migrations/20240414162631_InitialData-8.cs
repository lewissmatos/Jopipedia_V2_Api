using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("063d1b42-6975-4ec1-aef6-e4a19bbdde57"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("21c66097-ebd3-4719-b11c-9c5fd6d85e2d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3630cab9-0997-46c2-8239-c9948a8185f8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("48c7a71a-7d4d-4bfc-a839-73ad4fe6a84e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("85414eb8-7a52-4e94-949d-675be9a1249f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8d677dc9-a91b-49b8-a13c-630ef16ce632"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a2445c0b-aa11-42b0-aa15-d92a05a6731c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a8dd5231-ae2e-4bb9-be16-3ff423b2b366"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bb1361d0-4760-48ca-b289-f9b0f0338ba6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ce5606d4-22f0-434f-aece-2bb07884bdc0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fa10ff94-665b-4c49-81bf-a961eb70fd8b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("3700bdd8-c549-4e22-83c5-2f47e4aac7a0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c90e687d-ee91-46a0-9df1-b568c185b6bc"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("37c641d0-1621-4a72-bb1f-bf57bb5805d6"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), null },
                    { new Guid("3a827dd9-6c30-41be-81ac-5a61aeb43f7a"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), null },
                    { new Guid("4b159dc9-66a9-4983-b3e4-9424ecaa79be"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null },
                    { new Guid("51ae290e-1277-4d20-b286-e848d3ccbf8d"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("5e102b99-9c25-4099-a8b1-ed6c8d89c447"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("70643450-127d-4825-8f40-6fc828dfd143"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), null },
                    { new Guid("8e176765-949f-4d2c-a81b-37a9d17640df"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("a5dfefcb-87d3-431d-9e11-6d606f360518"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8930), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8930), null },
                    { new Guid("bbef034c-f67f-4f8f-a25b-5f537d3ae2b6"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null },
                    { new Guid("d2a51fe6-f1b7-4486-a376-53e746ea2dc4"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), null },
                    { new Guid("f37381ea-dfcc-4cf9-b7fc-f23f7b6e35b2"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("47d700ad-76d4-4fdb-a565-404900ac917f"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8840), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("53652543-f5a2-4fc6-87c3-b0aae2ef3921"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8870), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8870) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("37c641d0-1621-4a72-bb1f-bf57bb5805d6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3a827dd9-6c30-41be-81ac-5a61aeb43f7a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4b159dc9-66a9-4983-b3e4-9424ecaa79be"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("51ae290e-1277-4d20-b286-e848d3ccbf8d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e102b99-9c25-4099-a8b1-ed6c8d89c447"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("70643450-127d-4825-8f40-6fc828dfd143"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8e176765-949f-4d2c-a81b-37a9d17640df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a5dfefcb-87d3-431d-9e11-6d606f360518"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bbef034c-f67f-4f8f-a25b-5f537d3ae2b6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d2a51fe6-f1b7-4486-a376-53e746ea2dc4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f37381ea-dfcc-4cf9-b7fc-f23f7b6e35b2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("47d700ad-76d4-4fdb-a565-404900ac917f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("53652543-f5a2-4fc6-87c3-b0aae2ef3921"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("063d1b42-6975-4ec1-aef6-e4a19bbdde57"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5570), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5570), null },
                    { new Guid("21c66097-ebd3-4719-b11c-9c5fd6d85e2d"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5560), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5560), null },
                    { new Guid("3630cab9-0997-46c2-8239-c9948a8185f8"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5570), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5570), null },
                    { new Guid("48c7a71a-7d4d-4bfc-a839-73ad4fe6a84e"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5610), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5610), null },
                    { new Guid("85414eb8-7a52-4e94-949d-675be9a1249f"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5580), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5580), null },
                    { new Guid("8d677dc9-a91b-49b8-a13c-630ef16ce632"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), null },
                    { new Guid("a2445c0b-aa11-42b0-aa15-d92a05a6731c"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), null },
                    { new Guid("a8dd5231-ae2e-4bb9-be16-3ff423b2b366"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), null },
                    { new Guid("bb1361d0-4760-48ca-b289-f9b0f0338ba6"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), null },
                    { new Guid("ce5606d4-22f0-434f-aece-2bb07884bdc0"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5600), null },
                    { new Guid("fa10ff94-665b-4c49-81bf-a961eb70fd8b"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5590), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3700bdd8-c549-4e22-83c5-2f47e4aac7a0"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5400), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5400) },
                    { new Guid("c90e687d-ee91-46a0-9df1-b568c185b6bc"), new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5320), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 20, 24, 454, DateTimeKind.Utc).AddTicks(5320) }
                });
        }
    }
}
