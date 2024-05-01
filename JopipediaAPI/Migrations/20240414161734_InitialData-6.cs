using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1afdfb97-0fb4-466c-bfcf-001989c24a4f"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), null },
                    { new Guid("3500a2af-5b25-476c-a81b-80666a5860f8"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), null },
                    { new Guid("3a0763e6-7719-4a71-8929-79a91a00ed49"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), null },
                    { new Guid("65dcf26d-6014-48c0-9647-bfeb750fbb21"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), null },
                    { new Guid("9ae44897-8ef2-41b5-8e91-8186b20b45c6"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6350), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6350), null },
                    { new Guid("a732c9e5-f580-4199-8161-d2d0a9e4e07f"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), null },
                    { new Guid("b0ecd5a3-452d-4daf-9bee-65b6c8228cde"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), null },
                    { new Guid("ba293752-43fa-4289-9930-61caea7a0d12"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6330), null },
                    { new Guid("c21046bb-c088-40ed-a906-094ec640a13f"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6320), null },
                    { new Guid("d1773fcd-f85b-4389-8385-15c757155db0"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6310), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6310), null },
                    { new Guid("fa36e57d-d31c-41e2-9eae-d622b5d1fc88"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6340), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("48dc0403-372d-46ac-b2a1-52ffe7169fdb"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6200), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6210) },
                    { new Guid("a79e5011-8d5d-4898-a625-69d94cb33e14"), new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6230), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 17, 34, 48, DateTimeKind.Utc).AddTicks(6230) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1afdfb97-0fb4-466c-bfcf-001989c24a4f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3500a2af-5b25-476c-a81b-80666a5860f8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3a0763e6-7719-4a71-8929-79a91a00ed49"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("65dcf26d-6014-48c0-9647-bfeb750fbb21"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9ae44897-8ef2-41b5-8e91-8186b20b45c6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a732c9e5-f580-4199-8161-d2d0a9e4e07f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b0ecd5a3-452d-4daf-9bee-65b6c8228cde"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba293752-43fa-4289-9930-61caea7a0d12"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c21046bb-c088-40ed-a906-094ec640a13f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d1773fcd-f85b-4389-8385-15c757155db0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fa36e57d-d31c-41e2-9eae-d622b5d1fc88"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("48dc0403-372d-46ac-b2a1-52ffe7169fdb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("a79e5011-8d5d-4898-a625-69d94cb33e14"));

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
    }
}
