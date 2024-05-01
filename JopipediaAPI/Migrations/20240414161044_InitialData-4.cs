using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("04344e21-e8c2-4791-93ba-691e2790f3e5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("08142102-1ead-4eee-bcf4-c345dd42d2f1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("144b75fe-ceb1-4fea-8102-fcd5adfaa603"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("28b5d1f6-4680-4317-828c-13cbccdf155a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4e3dbdd8-244d-4d22-ae35-ad2337ab0716"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("520c1e8a-e6f8-4280-bbf4-98d4c4971a6b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7b566cea-dad4-4024-a52c-cdb7eeca86de"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ac5f16f6-ad13-4c17-8849-b2161697519a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aecc0572-ac12-4fd4-b918-6413d5cb8329"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b7e86a24-6dd8-4943-99a9-76f264096e1e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bbf7175a-3cf2-422b-ae74-ad73445de92d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("1eac52cd-951c-4dc8-aedf-0f9b54edd3e1"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("3fe8f3a6-25c1-4646-8cdc-0e6ee20f21ba"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("4d04992b-2f1d-4a57-af80-fa576d35fd15"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("784c990b-e1a1-4e31-b63f-d8babec77a74"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("89748487-91cd-4161-9de0-53954e795b54"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f2032598-b1b7-41c1-8646-1ad7ccc576eb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("45c8351f-f821-4380-a719-17a4713e7938"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("dfbc3167-246e-4301-9ed9-9155c4707759"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("04344e21-e8c2-4791-93ba-691e2790f3e5"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1010), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1010), null },
                    { new Guid("08142102-1ead-4eee-bcf4-c345dd42d2f1"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), null },
                    { new Guid("144b75fe-ceb1-4fea-8102-fcd5adfaa603"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(980), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(980), null },
                    { new Guid("28b5d1f6-4680-4317-828c-13cbccdf155a"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), null },
                    { new Guid("4e3dbdd8-244d-4d22-ae35-ad2337ab0716"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(970), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(980), null },
                    { new Guid("520c1e8a-e6f8-4280-bbf4-98d4c4971a6b"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1000), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1000), null },
                    { new Guid("7b566cea-dad4-4024-a52c-cdb7eeca86de"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(980), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(980), null },
                    { new Guid("ac5f16f6-ad13-4c17-8849-b2161697519a"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(970), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(970), null },
                    { new Guid("aecc0572-ac12-4fd4-b918-6413d5cb8329"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(960), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(970), null },
                    { new Guid("b7e86a24-6dd8-4943-99a9-76f264096e1e"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1000), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(1000), null },
                    { new Guid("bbf7175a-3cf2-422b-ae74-ad73445de92d"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(990), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1eac52cd-951c-4dc8-aedf-0f9b54edd3e1"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(950), "expert", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(950) },
                    { new Guid("3fe8f3a6-25c1-4646-8cdc-0e6ee20f21ba"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940), "intermediate", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940) },
                    { new Guid("4d04992b-2f1d-4a57-af80-fa576d35fd15"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(930), "rookie", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(930) },
                    { new Guid("784c990b-e1a1-4e31-b63f-d8babec77a74"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(950), "legend", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(950) },
                    { new Guid("89748487-91cd-4161-9de0-53954e795b54"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940), "advanced", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940) },
                    { new Guid("f2032598-b1b7-41c1-8646-1ad7ccc576eb"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940), "beginner", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(940) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("45c8351f-f821-4380-a719-17a4713e7938"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(860), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(860) },
                    { new Guid("dfbc3167-246e-4301-9ed9-9155c4707759"), new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(830), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 6, 8, 799, DateTimeKind.Utc).AddTicks(830) }
                });
        }
    }
}
