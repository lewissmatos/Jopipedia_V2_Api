using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0bec8b67-c88b-4fc5-b618-7ecffdbc13bf"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9020), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9020), null },
                    { new Guid("1255e53a-4b9c-4bb3-b980-32c3db911189"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("1e99282f-745b-426e-a194-eeec46e64bdf"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("38733a9c-55b8-4dfe-8a0a-7c69de28c633"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("4994eb99-5530-4a6b-85d3-2f0669759ba1"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("702054dc-2eec-4a01-a6f7-924535ae910f"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("7acc8bf7-6a08-476e-b947-0626f331a828"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("ade06474-34d8-4fd1-abe9-dad704fdc248"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9020), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9020), null },
                    { new Guid("b348d455-d317-4aa6-ad73-d0fee27a52b5"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9040), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("c75490b7-adca-45bf-aeb6-bcb54a46bd3f"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9040), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("df72f421-2b9f-401e-89e1-8d9be85658a1"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9060), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9060), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b21fa2c-93ca-4f9f-848a-93ec1ebd7087"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010), "legend", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010) },
                    { new Guid("20b153b7-655d-477e-b1c7-15f85e845386"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9000), "beginner", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9000) },
                    { new Guid("3dc6d202-e257-47a0-aa56-d41ea8807269"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9000), "intermediate", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9000) },
                    { new Guid("5f123a2f-67f5-45f2-bca3-869fe972675b"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(8980), "rookie", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(8980) },
                    { new Guid("9a3ace34-c28b-4af7-bc34-5294e3707353"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010), "expert", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010) },
                    { new Guid("d8a7c6f0-16a5-45c6-9750-e47373101fd3"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010), "advanced", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9010) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("13dbe3a6-d011-4a04-bb90-9cb59f718282"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9060), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9070) },
                    { new Guid("db7e584d-f0eb-40fc-8915-fd2a97cf08fb"), new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9070), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 12, 9, 905, DateTimeKind.Utc).AddTicks(9070) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0bec8b67-c88b-4fc5-b618-7ecffdbc13bf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1255e53a-4b9c-4bb3-b980-32c3db911189"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1e99282f-745b-426e-a194-eeec46e64bdf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("38733a9c-55b8-4dfe-8a0a-7c69de28c633"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4994eb99-5530-4a6b-85d3-2f0669759ba1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("702054dc-2eec-4a01-a6f7-924535ae910f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7acc8bf7-6a08-476e-b947-0626f331a828"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ade06474-34d8-4fd1-abe9-dad704fdc248"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b348d455-d317-4aa6-ad73-d0fee27a52b5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c75490b7-adca-45bf-aeb6-bcb54a46bd3f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("df72f421-2b9f-401e-89e1-8d9be85658a1"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("1b21fa2c-93ca-4f9f-848a-93ec1ebd7087"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("20b153b7-655d-477e-b1c7-15f85e845386"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("3dc6d202-e257-47a0-aa56-d41ea8807269"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5f123a2f-67f5-45f2-bca3-869fe972675b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("9a3ace34-c28b-4af7-bc34-5294e3707353"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d8a7c6f0-16a5-45c6-9750-e47373101fd3"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("13dbe3a6-d011-4a04-bb90-9cb59f718282"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("db7e584d-f0eb-40fc-8915-fd2a97cf08fb"));

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
    }
}
