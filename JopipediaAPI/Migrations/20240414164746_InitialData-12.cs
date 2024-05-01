using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0e9df3dd-4b46-4151-8267-6825c8c95833"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("195812f8-5183-44d0-a5f3-2fba04c8aee0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1eaf9105-10d6-4d99-8b34-66816532a822"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3cae74c5-3ed0-4e0d-89fd-d4af3fca2f57"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("47e195db-7170-4c09-9289-11e3d7917125"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4b0a4d4e-e5d6-4a4d-9bfc-ae51991737a5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e840649-7efe-41da-9f18-cb1eeee2b8e1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5fd91532-a809-4f21-a0e9-42cd1acd13f1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("aa413ed7-1409-49b3-a5d2-f05b71a2055d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f4bad48e-0751-45b0-bcf5-67265174375e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fc60f1b0-af15-4b75-b75b-574f910c878b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("0cdc2ff8-6089-45e6-b2b1-edf5941afe5e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2f0d6c4c-8c2f-4f34-9f76-ffabebd38e9b"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("37b1b993-8173-41e6-97f4-d2a2e06f5fe8"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("42ad055f-97d2-4871-ba74-41bfbcdbd68d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5acce8a3-fc1b-4da7-8259-8c916b8aa928"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8cbb8cff-28f2-4325-a8f6-34387f1b2bfd"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("500cd21a-883b-420b-8015-5d26a6e42e10"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("fc4aa4c5-43e1-41e2-8db2-0ec36fff1e1b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0e9df3dd-4b46-4151-8267-6825c8c95833"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("195812f8-5183-44d0-a5f3-2fba04c8aee0"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("1eaf9105-10d6-4d99-8b34-66816532a822"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230), null },
                    { new Guid("3cae74c5-3ed0-4e0d-89fd-d4af3fca2f57"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), null },
                    { new Guid("47e195db-7170-4c09-9289-11e3d7917125"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220), null },
                    { new Guid("4b0a4d4e-e5d6-4a4d-9bfc-ae51991737a5"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), null },
                    { new Guid("5e840649-7efe-41da-9f18-cb1eeee2b8e1"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230), null },
                    { new Guid("5fd91532-a809-4f21-a0e9-42cd1acd13f1"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8220), null },
                    { new Guid("aa413ed7-1409-49b3-a5d2-f05b71a2055d"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8240), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8240), null },
                    { new Guid("f4bad48e-0751-45b0-bcf5-67265174375e"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8210), null },
                    { new Guid("fc60f1b0-af15-4b75-b75b-574f910c878b"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8230), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cdc2ff8-6089-45e6-b2b1-edf5941afe5e"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180), "expert", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180) },
                    { new Guid("2f0d6c4c-8c2f-4f34-9f76-ffabebd38e9b"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170), "beginner", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170) },
                    { new Guid("37b1b993-8173-41e6-97f4-d2a2e06f5fe8"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180), "intermediate", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180) },
                    { new Guid("42ad055f-97d2-4871-ba74-41bfbcdbd68d"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8190), "legend", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8190) },
                    { new Guid("5acce8a3-fc1b-4da7-8259-8c916b8aa928"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170), "rookie", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8170) },
                    { new Guid("8cbb8cff-28f2-4325-a8f6-34387f1b2bfd"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180), "advanced", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8180) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("500cd21a-883b-420b-8015-5d26a6e42e10"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8100), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8100) },
                    { new Guid("fc4aa4c5-43e1-41e2-8db2-0ec36fff1e1b"), new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8120), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 40, 39, 263, DateTimeKind.Utc).AddTicks(8120) }
                });
        }
    }
}
