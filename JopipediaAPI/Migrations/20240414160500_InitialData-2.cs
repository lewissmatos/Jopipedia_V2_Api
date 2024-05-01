using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("04e802b3-ae1f-4de0-bef1-0501a0c4bd89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0bde6aad-5244-4e6e-995e-546b2531898f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1d92611d-134c-40a1-a636-1628f73cd029"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52dfba94-98fc-4143-a4f8-b31f0480f065"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5f4c58a7-3ff3-46e4-8806-1e99cb3b52a5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("71cccb5f-74a4-41f8-afac-a888b02a77bf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7a2bf943-388e-40e4-bf7a-b6863248630a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("84718173-425b-4f9c-b393-94498678543b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("97b8e048-a24b-4c33-81ce-cb0dddaf93df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9b5a7254-d650-448c-bd07-7f1cc771be07"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b8839e79-9ec4-4395-9b81-fe0244a2c00e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("019f5cad-4b10-4c36-b0b1-73bf33b6d826"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("194614f9-f133-4372-bf51-bea9a665f0e3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2ac0bcca-0042-42a2-b8d1-8ac9553bb22a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("789b3e14-3813-4210-bd1f-cc03f65f288f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("b13bf655-aec2-43cd-ae63-5d063b1c5988"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f40c7957-ef3b-476b-bacf-570ab55b54a8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("327f8be1-dfad-415f-a149-288d0f334419"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("bdefb79a-884d-4a62-aea3-d6283c8d88f6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("04e802b3-ae1f-4de0-bef1-0501a0c4bd89"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("0bde6aad-5244-4e6e-995e-546b2531898f"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("1d92611d-134c-40a1-a636-1628f73cd029"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("52dfba94-98fc-4143-a4f8-b31f0480f065"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), null },
                    { new Guid("5f4c58a7-3ff3-46e4-8806-1e99cb3b52a5"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), null },
                    { new Guid("71cccb5f-74a4-41f8-afac-a888b02a77bf"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), null },
                    { new Guid("7a2bf943-388e-40e4-bf7a-b6863248630a"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("84718173-425b-4f9c-b393-94498678543b"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("97b8e048-a24b-4c33-81ce-cb0dddaf93df"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), null },
                    { new Guid("9b5a7254-d650-448c-bd07-7f1cc771be07"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("b8839e79-9ec4-4395-9b81-fe0244a2c00e"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3970), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3970), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("019f5cad-4b10-4c36-b0b1-73bf33b6d826"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940), "beginner", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940) },
                    { new Guid("194614f9-f133-4372-bf51-bea9a665f0e3"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "advanced", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("2ac0bcca-0042-42a2-b8d1-8ac9553bb22a"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "expert", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("789b3e14-3813-4210-bd1f-cc03f65f288f"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "intermediate", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("b13bf655-aec2-43cd-ae63-5d063b1c5988"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940), "rookie", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940) },
                    { new Guid("f40c7957-ef3b-476b-bacf-570ab55b54a8"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3960), "legend", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3960) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("327f8be1-dfad-415f-a149-288d0f334419"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3880), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3880) },
                    { new Guid("bdefb79a-884d-4a62-aea3-d6283c8d88f6"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3850), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3850) }
                });
        }
    }
}
