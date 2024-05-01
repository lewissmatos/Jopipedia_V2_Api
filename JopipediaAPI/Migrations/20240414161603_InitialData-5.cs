using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("18dac05d-3678-4e45-bede-4179d9d99701"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("41c00d95-8183-4db2-bbc1-bff1473421b3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("448f7bb3-a364-4a6e-9fba-8f58ea45b140"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5a4e1af4-670f-4e0b-ae56-7d2c93f2f945"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("96788e5b-430d-408a-8ad0-153cc4994896"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9afa4df6-faed-4ed2-9a11-a34ebd9abd53"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9edd7d98-f3fa-47da-b477-c460361f0135"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a21beed9-1d53-423f-a6e5-8deb555ab5fb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aea6c91b-77bf-462f-9065-5902630a3351"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cadbda37-5db7-40a0-ac32-c579fbacbca1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("eaa08201-395d-49c2-9993-77418d3ae7d9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("09554636-962e-4c3b-965e-527cfa38061a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("143883e4-53b6-405b-a5c2-b7e936f9b6b1"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("468627ed-17c3-4d2f-8fae-cf57c1592707"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("60eb8704-c4e6-4cbc-96c6-fdef88e1c91a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c800e645-a9c2-4569-b18f-c61dd6f9bcf8"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("cf8adefa-ab42-44cc-83f7-f6cdd5ba23be"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0f387e90-5b1d-4d77-ab6d-93de7beee11c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("ca93a537-54e2-494c-97a7-29f163db84c7"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a7ad54a-46e9-440a-9a64-f7dd166a8f6c"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), null },
                    { new Guid("0ac6396f-a0ff-4e04-94e5-9480ab2ae8ff"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), null },
                    { new Guid("2867e0eb-8eb8-4ed8-92a3-a9dd96745dad"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), null },
                    { new Guid("3feb0d2e-b7bb-48b2-904c-3db6af4e9608"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5690), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5690), null },
                    { new Guid("42982277-665b-46be-83cb-7f65d696a1a7"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5710), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5710), null },
                    { new Guid("5573385b-8779-46fd-a4d7-dbc4bdad052d"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5680), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5690), null },
                    { new Guid("676e2808-4b43-4eb7-95fe-f3069b01f032"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5710), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5710), null },
                    { new Guid("9fc94bab-7ca1-4166-a496-5142a4541a70"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5730), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5730), null },
                    { new Guid("bda7d97b-be97-4b70-8199-a62a28305f42"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5700), null },
                    { new Guid("d3533620-c42b-400d-868f-302af42f4655"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), null },
                    { new Guid("f21e9b50-4db0-4e5a-9cdd-44ec56f5ba45"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5720), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a88aded-d6a0-4a5b-8e3b-de2c25f07a60"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5490), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5490) },
                    { new Guid("1a98c478-5f9b-4e70-9c59-43e0b6741ea5"), new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5560), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 16, 3, 207, DateTimeKind.Utc).AddTicks(5560) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0a7ad54a-46e9-440a-9a64-f7dd166a8f6c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0ac6396f-a0ff-4e04-94e5-9480ab2ae8ff"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2867e0eb-8eb8-4ed8-92a3-a9dd96745dad"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3feb0d2e-b7bb-48b2-904c-3db6af4e9608"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("42982277-665b-46be-83cb-7f65d696a1a7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5573385b-8779-46fd-a4d7-dbc4bdad052d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("676e2808-4b43-4eb7-95fe-f3069b01f032"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9fc94bab-7ca1-4166-a496-5142a4541a70"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bda7d97b-be97-4b70-8199-a62a28305f42"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d3533620-c42b-400d-868f-302af42f4655"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f21e9b50-4db0-4e5a-9cdd-44ec56f5ba45"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a88aded-d6a0-4a5b-8e3b-de2c25f07a60"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a98c478-5f9b-4e70-9c59-43e0b6741ea5"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("18dac05d-3678-4e45-bede-4179d9d99701"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3220), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3220), null },
                    { new Guid("41c00d95-8183-4db2-bbc1-bff1473421b3"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3230), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3230), null },
                    { new Guid("448f7bb3-a364-4a6e-9fba-8f58ea45b140"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3240), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3250), null },
                    { new Guid("5a4e1af4-670f-4e0b-ae56-7d2c93f2f945"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3260), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3260), null },
                    { new Guid("96788e5b-430d-408a-8ad0-153cc4994896"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3240), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3240), null },
                    { new Guid("9afa4df6-faed-4ed2-9a11-a34ebd9abd53"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3240), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3240), null },
                    { new Guid("9edd7d98-f3fa-47da-b477-c460361f0135"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3210), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3210), null },
                    { new Guid("a21beed9-1d53-423f-a6e5-8deb555ab5fb"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3230), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3230), null },
                    { new Guid("aea6c91b-77bf-462f-9065-5902630a3351"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3250), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3250), null },
                    { new Guid("cadbda37-5db7-40a0-ac32-c579fbacbca1"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3220), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3220), null },
                    { new Guid("eaa08201-395d-49c2-9993-77418d3ae7d9"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3260), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3260), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09554636-962e-4c3b-965e-527cfa38061a"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3200), "legend", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3200) },
                    { new Guid("143883e4-53b6-405b-a5c2-b7e936f9b6b1"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3180), "rookie", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3180) },
                    { new Guid("468627ed-17c3-4d2f-8fae-cf57c1592707"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3180), "beginner", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3180) },
                    { new Guid("60eb8704-c4e6-4cbc-96c6-fdef88e1c91a"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190), "expert", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190) },
                    { new Guid("c800e645-a9c2-4569-b18f-c61dd6f9bcf8"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190), "advanced", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190) },
                    { new Guid("cf8adefa-ab42-44cc-83f7-f6cdd5ba23be"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190), "intermediate", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(3190) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f387e90-5b1d-4d77-ab6d-93de7beee11c"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(2900), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(2900) },
                    { new Guid("ca93a537-54e2-494c-97a7-29f163db84c7"), new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(2840), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 10, 44, 557, DateTimeKind.Utc).AddTicks(2840) }
                });
        }
    }
}
