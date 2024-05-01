using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("07fadce4-9e21-4ae0-b642-14b5e039da39"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("27d78feb-d00f-43d4-bd26-0384b4af0b8c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("612cbfc2-a448-45f6-8449-9cbf686c9d21"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("706249a5-6410-426e-821f-88e1843736fc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7d2471d8-6bce-4513-9e8a-a38a5df1cf25"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("925be0e5-2944-4e23-98e7-53843e28f830"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9298db4d-0baa-4a57-8215-f861cdb09d65"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("934412f5-becd-41c1-a82c-b9ca6fd5eb54"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a1e7a8a5-8a19-4378-9611-e1fb4aff9749"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("baefdd5d-d14e-4908-81c4-2a4a6d6f8824"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c4735bbc-9892-4128-b349-7e7d5f355ebb"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("0a47e1c3-7537-4aa6-b483-44b68d2b95a5"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("35900138-a6ff-49cf-a33e-94d1ed938d98"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("b04ac6ac-16e1-4ac1-99a4-01af4dab2cb0"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("b1e04c77-c2ac-47eb-9260-37f351588eed"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("de5afc5d-14e5-4011-8e6e-4db76ff20a7d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("e2ed6130-6c55-4b64-a32a-1fe76d0c17a2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1815e9f4-3a76-4513-a042-9a95814be238"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("9641da9f-2a81-48c0-8549-6e66b2a914ee"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("07fadce4-9e21-4ae0-b642-14b5e039da39"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), null },
                    { new Guid("27d78feb-d00f-43d4-bd26-0384b4af0b8c"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040), null },
                    { new Guid("612cbfc2-a448-45f6-8449-9cbf686c9d21"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050), null },
                    { new Guid("706249a5-6410-426e-821f-88e1843736fc"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8050), null },
                    { new Guid("7d2471d8-6bce-4513-9e8a-a38a5df1cf25"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), null },
                    { new Guid("925be0e5-2944-4e23-98e7-53843e28f830"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8030), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8030), null },
                    { new Guid("9298db4d-0baa-4a57-8215-f861cdb09d65"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8070), null },
                    { new Guid("934412f5-becd-41c1-a82c-b9ca6fd5eb54"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8040), null },
                    { new Guid("a1e7a8a5-8a19-4378-9611-e1fb4aff9749"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), null },
                    { new Guid("baefdd5d-d14e-4908-81c4-2a4a6d6f8824"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), null },
                    { new Guid("c4735bbc-9892-4128-b349-7e7d5f355ebb"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8060), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a47e1c3-7537-4aa6-b483-44b68d2b95a5"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000), "rookie", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000) },
                    { new Guid("35900138-a6ff-49cf-a33e-94d1ed938d98"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010), "advanced", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("b04ac6ac-16e1-4ac1-99a4-01af4dab2cb0"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010), "expert", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("b1e04c77-c2ac-47eb-9260-37f351588eed"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010), "intermediate", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8010) },
                    { new Guid("de5afc5d-14e5-4011-8e6e-4db76ff20a7d"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000), "beginner", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8000) },
                    { new Guid("e2ed6130-6c55-4b64-a32a-1fe76d0c17a2"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8020), "legend", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(8020) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1815e9f4-3a76-4513-a042-9a95814be238"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7840), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7840) },
                    { new Guid("9641da9f-2a81-48c0-8549-6e66b2a914ee"), new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7910), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 4, 59, 933, DateTimeKind.Utc).AddTicks(7910) }
                });
        }
    }
}
