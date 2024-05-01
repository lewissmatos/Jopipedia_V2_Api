using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("06e831a6-f2c5-40ab-b772-dfde6711a98b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1e2c5873-a769-430f-a409-2bb02a85daed"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("46d4ca69-e0a5-467b-a738-1e61ca87d052"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4eec4249-7a9b-4f2a-872b-4fa24ce42316"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("954b305c-87c4-405b-b935-3cafe0447b06"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a0f4585a-4286-4ad0-b905-17116a9ad351"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bb1dab2f-4b9e-4073-94c4-53ff55ac1df6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bd4dc739-5b6e-4358-b344-0b352627e090"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dc677257-62b3-462d-85a7-7ac6e3cb9bb4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e07d5c74-b218-4780-9b64-a29d473886b6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f573d1e5-3d75-4df5-9708-ffe25c311a8e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("035e802c-45f3-4715-b717-d9167cec285d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("25e29dbc-c7b9-4595-bbc7-bd284960a48f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("39237bba-4f29-4373-b216-5b5799d7d053"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("449190ec-9780-426b-af9b-805f9fbb4720"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8c272da9-9f7d-4b55-8d9e-7031973f579b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("e8cfcf15-5d5d-4542-9fdd-2ed006a46428"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("551b002d-52aa-4150-ae01-be2e2bfdb0d1"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c5de8fd-8ed4-44cb-9ae4-039196a3dcd8"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dbcd044-f48f-45d1-bc1d-e151a9ad4efb"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), null },
                    { new Guid("2d74048d-e5d9-483b-b8dd-715c33826b3b"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("34c0add8-c27d-4c58-9efa-bff2b6b20ae2"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), null },
                    { new Guid("3cf499c4-16fd-4102-9873-6be06ec5978a"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("7a6acf6a-17f2-4f9d-b0d7-68fd1b595638"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), null },
                    { new Guid("908adf4e-c7f1-4a39-bf22-49f985a2bb56"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("a6f0d59c-a698-4cf5-acab-06d36e139e4e"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("b3078986-4716-4cd9-b7bd-38e1b1a8ae48"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("cb7261c4-ed57-4b49-a2f2-8efe0d59f087"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("e8129e21-a06c-44aa-9f76-6254631ed48c"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), null },
                    { new Guid("eeeaff63-0ae2-43ee-909a-39b711bd52f4"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4b6c10df-c6ad-4b15-bc40-05bd5fedd8a3"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "expert", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("711060c0-0ad9-4f95-90da-a18650251c28"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620), "beginner", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620) },
                    { new Guid("91acca60-e278-4185-be48-e28606313224"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "advanced", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("edf95d57-d45e-4c00-a2a2-487ea3ab99f7"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620), "intermediate", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620) },
                    { new Guid("fc2dbc71-9e89-44a1-937f-ea3e52fda480"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "legend", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("ffea7f7c-27f9-4650-b11b-f8f81d12f84d"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570), "rookie", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ce4a4d0-2998-478c-b016-5412a0a88e50"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690) },
                    { new Guid("b87b2b0f-dbf6-4dbb-89cb-f6dde10aa428"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0dbcd044-f48f-45d1-bc1d-e151a9ad4efb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2d74048d-e5d9-483b-b8dd-715c33826b3b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("34c0add8-c27d-4c58-9efa-bff2b6b20ae2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3cf499c4-16fd-4102-9873-6be06ec5978a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7a6acf6a-17f2-4f9d-b0d7-68fd1b595638"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("908adf4e-c7f1-4a39-bf22-49f985a2bb56"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a6f0d59c-a698-4cf5-acab-06d36e139e4e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b3078986-4716-4cd9-b7bd-38e1b1a8ae48"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cb7261c4-ed57-4b49-a2f2-8efe0d59f087"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e8129e21-a06c-44aa-9f76-6254631ed48c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("eeeaff63-0ae2-43ee-909a-39b711bd52f4"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("4b6c10df-c6ad-4b15-bc40-05bd5fedd8a3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("711060c0-0ad9-4f95-90da-a18650251c28"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("91acca60-e278-4185-be48-e28606313224"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("edf95d57-d45e-4c00-a2a2-487ea3ab99f7"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fc2dbc71-9e89-44a1-937f-ea3e52fda480"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("ffea7f7c-27f9-4650-b11b-f8f81d12f84d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ce4a4d0-2998-478c-b016-5412a0a88e50"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b87b2b0f-dbf6-4dbb-89cb-f6dde10aa428"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("06e831a6-f2c5-40ab-b772-dfde6711a98b"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5730), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5730), null },
                    { new Guid("1e2c5873-a769-430f-a409-2bb02a85daed"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5760), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5760), null },
                    { new Guid("46d4ca69-e0a5-467b-a738-1e61ca87d052"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), null },
                    { new Guid("4eec4249-7a9b-4f2a-872b-4fa24ce42316"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5720), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5720), null },
                    { new Guid("954b305c-87c4-405b-b935-3cafe0447b06"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), null },
                    { new Guid("a0f4585a-4286-4ad0-b905-17116a9ad351"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5730), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5730), null },
                    { new Guid("bb1dab2f-4b9e-4073-94c4-53ff55ac1df6"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), null },
                    { new Guid("bd4dc739-5b6e-4358-b344-0b352627e090"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), null },
                    { new Guid("dc677257-62b3-462d-85a7-7ac6e3cb9bb4"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5720), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5720), null },
                    { new Guid("e07d5c74-b218-4780-9b64-a29d473886b6"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5750), null },
                    { new Guid("f573d1e5-3d75-4df5-9708-ffe25c311a8e"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5740), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("035e802c-45f3-4715-b717-d9167cec285d"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4060), "expert", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4060) },
                    { new Guid("25e29dbc-c7b9-4595-bbc7-bd284960a48f"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4050), "intermediate", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4050) },
                    { new Guid("39237bba-4f29-4373-b216-5b5799d7d053"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(3960), "rookie", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(3960) },
                    { new Guid("449190ec-9780-426b-af9b-805f9fbb4720"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4060), "advanced", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4060) },
                    { new Guid("8c272da9-9f7d-4b55-8d9e-7031973f579b"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4070), "legend", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4070) },
                    { new Guid("e8cfcf15-5d5d-4542-9fdd-2ed006a46428"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4050), "beginner", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(4050) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("551b002d-52aa-4150-ae01-be2e2bfdb0d1"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5670), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5670) },
                    { new Guid("9c5de8fd-8ed4-44cb-9ae4-039196a3dcd8"), new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5690), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 47, 45, 924, DateTimeKind.Utc).AddTicks(5690) }
                });
        }
    }
}
