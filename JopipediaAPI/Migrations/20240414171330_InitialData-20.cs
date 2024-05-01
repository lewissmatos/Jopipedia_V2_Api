using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1115d777-5c41-416b-bfaf-f462b7fb5bd8"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1710), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1710), null },
                    { new Guid("11b21a40-9594-4c32-b508-de10e4336238"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), null },
                    { new Guid("2ac56331-2731-43c2-9491-cdfa508b90b1"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1730), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1730), null },
                    { new Guid("2e8fe79f-c6e7-42ec-a817-68d429c786c0"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1710), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1710), null },
                    { new Guid("41963564-4c11-4127-a94c-6c98f999cb0a"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1700), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1700), null },
                    { new Guid("74f92cba-01ab-44f4-b912-c89f48ed5c4e"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1700), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1700), null },
                    { new Guid("86c20ec1-9003-43c7-8cb7-a6068dc47843"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1730), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1730), null },
                    { new Guid("b402f303-5d92-4072-8022-79b8a6005bae"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1690), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1690), null },
                    { new Guid("bbe2be62-785b-454c-9319-e442045933c3"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1680), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1680), null },
                    { new Guid("cc1f0721-7487-4f9a-82b3-8ac335c5d1a1"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), null },
                    { new Guid("dad6d0b9-9246-4820-ae12-ecd1cd499e8f"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1720), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04bfdb27-0f2e-4c57-8a57-25026904c4a9"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1680), "legend", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1680) },
                    { new Guid("25a9cf54-27ba-4765-8253-6fa7a41eb7d3"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1650), "intermediate", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1650) },
                    { new Guid("482b7d49-1952-47a6-be33-38c568892e1b"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1630), "rookie", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1630) },
                    { new Guid("86f747f0-2641-4d6e-b87e-04921f1955f9"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1650), "beginner", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1650) },
                    { new Guid("bffc3f7e-4231-43dd-94de-afb57bede6a3"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1670), "advanced", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1670) },
                    { new Guid("f25577ea-4f11-4acf-af4b-e9b7d32cddef"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1670), "expert", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1680) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c4716b27-e6b4-4bb4-8668-583040c60ece"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1740), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1740) },
                    { new Guid("e74d8b98-f45f-4983-b6f3-189cc19096c5"), new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1750), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 13, 30, 223, DateTimeKind.Utc).AddTicks(1750) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1115d777-5c41-416b-bfaf-f462b7fb5bd8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("11b21a40-9594-4c32-b508-de10e4336238"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2ac56331-2731-43c2-9491-cdfa508b90b1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2e8fe79f-c6e7-42ec-a817-68d429c786c0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("41963564-4c11-4127-a94c-6c98f999cb0a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("74f92cba-01ab-44f4-b912-c89f48ed5c4e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("86c20ec1-9003-43c7-8cb7-a6068dc47843"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b402f303-5d92-4072-8022-79b8a6005bae"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bbe2be62-785b-454c-9319-e442045933c3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cc1f0721-7487-4f9a-82b3-8ac335c5d1a1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dad6d0b9-9246-4820-ae12-ecd1cd499e8f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("04bfdb27-0f2e-4c57-8a57-25026904c4a9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("25a9cf54-27ba-4765-8253-6fa7a41eb7d3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("482b7d49-1952-47a6-be33-38c568892e1b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("86f747f0-2641-4d6e-b87e-04921f1955f9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bffc3f7e-4231-43dd-94de-afb57bede6a3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f25577ea-4f11-4acf-af4b-e9b7d32cddef"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c4716b27-e6b4-4bb4-8668-583040c60ece"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e74d8b98-f45f-4983-b6f3-189cc19096c5"));

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
    }
}
