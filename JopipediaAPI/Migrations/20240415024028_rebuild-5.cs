using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class rebuild5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0d71f11b-a7d8-4326-bfe3-53ce35a1f07d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0fd660b5-bbe0-40d4-bf84-c46c3a0b1231"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2dedaa16-4419-4dc6-830b-3768f03fbff4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("328e25ee-1c1d-482c-8458-1b78cda32a89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4f76fca5-67ce-43aa-984a-72594409e7aa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("719a21ce-56a4-42b1-8b89-218febecfb4f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("809884f8-8cff-4478-b396-ce682a703c5f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("84bf65f0-6c80-43a4-b8d4-35f40054c1da"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("85899c41-5ac5-46c2-90dc-3ff2cf22e592"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("94aea9c7-af91-4e24-a191-94937d6e076c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a89bad78-8564-43a2-95b8-dac977b8d4b8"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("01eaf4a0-72c2-4195-a415-d069c8eb9380"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5830), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5830), null },
                    { new Guid("0315d1cb-cf1f-4c19-82ca-c8060e1ec265"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), null },
                    { new Guid("12c211b7-4604-4a2d-9d19-8a4b84162d8c"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), "History Quizzes", true, "History", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), null },
                    { new Guid("167219a1-5934-4352-b710-2267cc06a702"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5760), "Astrology Quizzes", true, "Astrology", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5760), null },
                    { new Guid("57d53668-25dc-481d-b24c-9fa454e20d31"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), null },
                    { new Guid("9869f417-39c3-449c-8250-1aefe0a7444b"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), null },
                    { new Guid("ba339907-d44c-4c30-88ad-478a6b93134a"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5810), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5810), null },
                    { new Guid("d5f8620b-c9b4-461b-b417-7b13d461731b"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), null },
                    { new Guid("dac47999-47fa-413b-bc26-df7744aacbfe"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5850), null },
                    { new Guid("ed240c36-6781-4db9-9cd0-514f92d2594e"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), null },
                    { new Guid("f141d671-969f-4d7b-b114-53ee325e691a"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5840), null },
                    { new Guid("f72ac747-c9f8-4a13-ab99-1f559ef9a417"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), "Music Quizzes", true, "Music", new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5860), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04484529-d942-4b8e-a07e-b74842c88925"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880), "advanced", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880) },
                    { new Guid("2a03d922-eb06-4354-9ff7-be091fdc5b13"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890), "legend", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890) },
                    { new Guid("486771e2-cd07-4892-a35f-996e2731bd20"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880), "intermediate", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880) },
                    { new Guid("61ffef2e-5dbe-4d5d-80c9-ca3081fd821f"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5870), "beginner", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5870) },
                    { new Guid("be247d3a-d360-48e8-965d-6d2179a0020c"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5870), "rookie", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5870) },
                    { new Guid("f0ba3200-f315-4b33-afa3-cfdf3db43e00"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880), "expert", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5880) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5b11963e-6248-4b81-ac6d-402f0ebee3d8"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890) },
                    { new Guid("61ff516d-a1c8-44b8-b5b5-cca0853fb28d"), new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 15, 2, 40, 28, 714, DateTimeKind.Utc).AddTicks(5890) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("01eaf4a0-72c2-4195-a415-d069c8eb9380"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0315d1cb-cf1f-4c19-82ca-c8060e1ec265"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("12c211b7-4604-4a2d-9d19-8a4b84162d8c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("167219a1-5934-4352-b710-2267cc06a702"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("57d53668-25dc-481d-b24c-9fa454e20d31"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9869f417-39c3-449c-8250-1aefe0a7444b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba339907-d44c-4c30-88ad-478a6b93134a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d5f8620b-c9b4-461b-b417-7b13d461731b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dac47999-47fa-413b-bc26-df7744aacbfe"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ed240c36-6781-4db9-9cd0-514f92d2594e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f141d671-969f-4d7b-b114-53ee325e691a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f72ac747-c9f8-4a13-ab99-1f559ef9a417"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("04484529-d942-4b8e-a07e-b74842c88925"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2a03d922-eb06-4354-9ff7-be091fdc5b13"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("486771e2-cd07-4892-a35f-996e2731bd20"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("61ffef2e-5dbe-4d5d-80c9-ca3081fd821f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("be247d3a-d360-48e8-965d-6d2179a0020c"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f0ba3200-f315-4b33-afa3-cfdf3db43e00"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5b11963e-6248-4b81-ac6d-402f0ebee3d8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("61ff516d-a1c8-44b8-b5b5-cca0853fb28d"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d71f11b-a7d8-4326-bfe3-53ce35a1f07d"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3890), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3890), null },
                    { new Guid("0fd660b5-bbe0-40d4-bf84-c46c3a0b1231"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3880), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3890), null },
                    { new Guid("2dedaa16-4419-4dc6-830b-3768f03fbff4"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3860), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3860), null },
                    { new Guid("328e25ee-1c1d-482c-8458-1b78cda32a89"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), null },
                    { new Guid("4f76fca5-67ce-43aa-984a-72594409e7aa"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3860), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3860), null },
                    { new Guid("719a21ce-56a4-42b1-8b89-218febecfb4f"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), null },
                    { new Guid("809884f8-8cff-4478-b396-ce682a703c5f"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3870), null },
                    { new Guid("84bf65f0-6c80-43a4-b8d4-35f40054c1da"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3880), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3880), null },
                    { new Guid("85899c41-5ac5-46c2-90dc-3ff2cf22e592"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3890), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3890), null },
                    { new Guid("94aea9c7-af91-4e24-a191-94937d6e076c"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3880), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3880), null },
                    { new Guid("a89bad78-8564-43a2-95b8-dac977b8d4b8"), new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3830), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 19, 55, 17, 60, DateTimeKind.Utc).AddTicks(3830), null }
                });
        }
    }
}
