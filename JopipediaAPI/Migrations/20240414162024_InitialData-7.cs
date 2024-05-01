using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
