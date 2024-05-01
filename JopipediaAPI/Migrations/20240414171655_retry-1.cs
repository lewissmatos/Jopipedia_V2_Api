using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class retry1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("14ba33fe-5e9c-4cdd-adc7-7aad11ede985"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4630), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4630), null },
                    { new Guid("7c768597-2c8c-4fa9-8fba-c60a222bdd08"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), null },
                    { new Guid("8d61d063-d8f9-41d1-bb1c-924abd440850"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4600), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4600), null },
                    { new Guid("98c9e15c-cf0a-4970-8d12-d476d965759a"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), null },
                    { new Guid("9bd92a63-cf16-4c40-b63b-fdd1e356bbbc"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4630), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4640), null },
                    { new Guid("b8965999-e16f-4b09-bfa0-ea4a876c58cc"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4610), null },
                    { new Guid("ba80f597-dd79-41e2-9c72-702453514608"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), null },
                    { new Guid("ed94919f-2445-4e39-a257-d01bd573da98"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4630), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4630), null },
                    { new Guid("fc389b2a-b21d-42b8-ba33-e2097fd76fe4"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), null },
                    { new Guid("fedcc1e6-6b03-4ef7-94f7-07e351e38fe0"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4600), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4600), null },
                    { new Guid("ffef875d-8906-4fef-a786-e3eb50d4ac7e"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4620), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9243b9c9-26f7-4b3b-82dc-3f0cfabc084b"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580), "intermediate", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580) },
                    { new Guid("a3f52064-2cd6-427a-be3c-b24ed842d750"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580), "advanced", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580) },
                    { new Guid("c20bc084-5e72-45ce-be47-1e2175b467c6"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4590), "legend", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4590) },
                    { new Guid("c6dde2f5-e885-4029-8cee-043f059eec82"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4590), "expert", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4590) },
                    { new Guid("d2a28ec2-546a-40fa-9010-aef2425dff4a"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580), "beginner", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4580) },
                    { new Guid("d3eead19-7443-4ecf-88c5-060db2c7233a"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4550), "rookie", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4550) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("70f3359a-ac57-48cc-8a40-de6a8d8bc3e7"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4650), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4650) },
                    { new Guid("ae45acb8-a40b-4522-9084-2e5409b744f1"), new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4640), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 16, 55, 73, DateTimeKind.Utc).AddTicks(4640) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("14ba33fe-5e9c-4cdd-adc7-7aad11ede985"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7c768597-2c8c-4fa9-8fba-c60a222bdd08"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8d61d063-d8f9-41d1-bb1c-924abd440850"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("98c9e15c-cf0a-4970-8d12-d476d965759a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9bd92a63-cf16-4c40-b63b-fdd1e356bbbc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b8965999-e16f-4b09-bfa0-ea4a876c58cc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba80f597-dd79-41e2-9c72-702453514608"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ed94919f-2445-4e39-a257-d01bd573da98"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fc389b2a-b21d-42b8-ba33-e2097fd76fe4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fedcc1e6-6b03-4ef7-94f7-07e351e38fe0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ffef875d-8906-4fef-a786-e3eb50d4ac7e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("9243b9c9-26f7-4b3b-82dc-3f0cfabc084b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("a3f52064-2cd6-427a-be3c-b24ed842d750"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c20bc084-5e72-45ce-be47-1e2175b467c6"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c6dde2f5-e885-4029-8cee-043f059eec82"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d2a28ec2-546a-40fa-9010-aef2425dff4a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d3eead19-7443-4ecf-88c5-060db2c7233a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("70f3359a-ac57-48cc-8a40-de6a8d8bc3e7"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae45acb8-a40b-4522-9084-2e5409b744f1"));

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
    }
}
