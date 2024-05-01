using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1a63911d-b683-4039-9110-a3381d266c08"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2708e229-fc8d-41e3-b32e-f234405b02a1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3913ff68-477b-479f-b364-b291c7516522"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("525ac2c4-480b-4989-a1bc-e7c738e07be1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("879b5bcc-8961-4296-9318-af4a1dc26f0b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8e302fb1-3985-42f0-bee0-2db93ffbd508"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9cf28dc7-20f5-43c0-9771-18a9878dbf99"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9d384d71-d63b-4b38-a74d-bf9090b326a3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9d4df450-e3a5-4ddc-b6c3-c69fc648dec7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b07d4ce8-ed07-4a11-857d-c8d029186891"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b6c40d2a-89a9-40c2-9ba1-3c2b889dd32a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("01e0424b-a389-4063-9c0c-18611eb7b576"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("24da4604-f129-4124-8a09-190c99232d71"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("35c87863-0f6e-4cd8-88bc-ed264cef5b39"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5691c9e7-811c-4392-b14b-5798c4dee02f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("77279fb8-b5ad-4aa6-aeb6-47fa64767898"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d0d3798f-61c9-483c-b282-11363ab5ead4"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("932d9e2d-8d19-46c3-87ec-f0abab5ae363"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b66683bb-8fc8-4bf3-ae3f-e3e432549737"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d0e80c4-ee70-4d70-b197-16d761aa6d2d"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8990), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9000), null },
                    { new Guid("2043e95d-7441-496b-bfcd-8e2e372829b3"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("2d31d846-c1b4-446e-8617-c979f5b80495"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("2e87d0c7-b46b-4c15-a3b3-0846d242532a"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("573ea36f-e358-45cc-829c-7275d89345fc"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9020), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9020), null },
                    { new Guid("66a46dd2-4377-4ff6-8fd8-1e23dcb7a05b"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9050), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("95074281-1f9d-4325-91eb-800984de06b9"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("aee33058-db0f-425b-9251-e300af0a75e6"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("c109e0f2-9ac4-4f8e-978d-48db3410acd6"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9010), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9010), null },
                    { new Guid("dc72d5fb-e257-418e-b515-5dfbc8e97635"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("ef013b4e-8653-44cb-b7af-7b89c94e0d21"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9020), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9020), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04d4d731-b6ec-49f4-ba71-a931f3ce6bb7"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8990), "legend", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8990) },
                    { new Guid("4f3087fe-1ce7-4e0e-8b08-cccadef7c651"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980), "beginner", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980) },
                    { new Guid("89b34769-c1fe-4114-9870-ba9819d65a6e"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8990), "expert", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8990) },
                    { new Guid("bc8073ab-8b61-4964-8ae6-704ab5960fc5"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8950), "rookie", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8950) },
                    { new Guid("bf5e7303-5ae4-4502-af3c-429008e6dc98"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980), "intermediate", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980) },
                    { new Guid("c7e75b54-de7b-4a3e-bc19-638922955d0a"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980), "advanced", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(8980) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("e5c45d9a-f122-4856-bf89-26307a2d668e"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9060), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9060) },
                    { new Guid("fd3a193d-ab13-4266-83fe-82a5780e5d7a"), new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9050), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 8, 29, 854, DateTimeKind.Utc).AddTicks(9050) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0d0e80c4-ee70-4d70-b197-16d761aa6d2d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2043e95d-7441-496b-bfcd-8e2e372829b3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2d31d846-c1b4-446e-8617-c979f5b80495"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2e87d0c7-b46b-4c15-a3b3-0846d242532a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("573ea36f-e358-45cc-829c-7275d89345fc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("66a46dd2-4377-4ff6-8fd8-1e23dcb7a05b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("95074281-1f9d-4325-91eb-800984de06b9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aee33058-db0f-425b-9251-e300af0a75e6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c109e0f2-9ac4-4f8e-978d-48db3410acd6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dc72d5fb-e257-418e-b515-5dfbc8e97635"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ef013b4e-8653-44cb-b7af-7b89c94e0d21"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("04d4d731-b6ec-49f4-ba71-a931f3ce6bb7"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("4f3087fe-1ce7-4e0e-8b08-cccadef7c651"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("89b34769-c1fe-4114-9870-ba9819d65a6e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bc8073ab-8b61-4964-8ae6-704ab5960fc5"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bf5e7303-5ae4-4502-af3c-429008e6dc98"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c7e75b54-de7b-4a3e-bc19-638922955d0a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e5c45d9a-f122-4856-bf89-26307a2d668e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd3a193d-ab13-4266-83fe-82a5780e5d7a"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a63911d-b683-4039-9110-a3381d266c08"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("2708e229-fc8d-41e3-b32e-f234405b02a1"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("3913ff68-477b-479f-b364-b291c7516522"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("525ac2c4-480b-4989-a1bc-e7c738e07be1"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("879b5bcc-8961-4296-9318-af4a1dc26f0b"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), null },
                    { new Guid("8e302fb1-3985-42f0-bee0-2db93ffbd508"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(270), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(270), null },
                    { new Guid("9cf28dc7-20f5-43c0-9771-18a9878dbf99"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("9d384d71-d63b-4b38-a74d-bf9090b326a3"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), null },
                    { new Guid("9d4df450-e3a5-4ddc-b6c3-c69fc648dec7"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), null },
                    { new Guid("b07d4ce8-ed07-4a11-857d-c8d029186891"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("b6c40d2a-89a9-40c2-9ba1-3c2b889dd32a"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01e0424b-a389-4063-9c0c-18611eb7b576"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230), "advanced", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) },
                    { new Guid("24da4604-f129-4124-8a09-190c99232d71"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220), "intermediate", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) },
                    { new Guid("35c87863-0f6e-4cd8-88bc-ed264cef5b39"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(200), "rookie", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(200) },
                    { new Guid("5691c9e7-811c-4392-b14b-5798c4dee02f"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), "legend", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240) },
                    { new Guid("77279fb8-b5ad-4aa6-aeb6-47fa64767898"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220), "beginner", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220) },
                    { new Guid("d0d3798f-61c9-483c-b282-11363ab5ead4"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230), "expert", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("932d9e2d-8d19-46c3-87ec-f0abab5ae363"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(310), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(310) },
                    { new Guid("b66683bb-8fc8-4bf3-ae3f-e3e432549737"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300) }
                });
        }
    }
}
