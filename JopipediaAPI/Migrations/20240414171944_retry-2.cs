using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class retry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("166b7711-6753-4649-b892-fb54fa02e87f"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("35010f53-46bd-417d-ad2f-422c55540d02"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("3de1ebef-cfe1-4246-a537-4ab108d871f3"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9020), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9020), null },
                    { new Guid("43cdab9e-6697-4dcb-906a-426057efaad0"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("4675098c-4c3d-43ae-a6b9-089cab6d6b79"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("503aa484-478b-4f2f-a2ce-79cf9b68240f"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), null },
                    { new Guid("541b994f-af8d-47c4-83e3-bd3db76b28a3"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060), null },
                    { new Guid("6a3708be-a7e0-4dd2-8daf-1b8406653c99"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9030), null },
                    { new Guid("a2dd800c-4e06-46e6-9546-d70765a4e43a"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9040), null },
                    { new Guid("a9a06ffe-c17d-41fe-b43e-5083e5c8acc8"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9060), null },
                    { new Guid("abe98df5-188b-47d4-8ea8-fc3c646ee87c"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9050), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("23f2782f-7b09-4211-941c-a9d1053b5e09"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010), "expert", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010) },
                    { new Guid("2af9e98f-0efd-42d6-91a1-eceb42e5944f"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000), "intermediate", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000) },
                    { new Guid("7d833732-c405-414a-aaa6-eb82810132ce"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(8970), "rookie", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(8970) },
                    { new Guid("c6459277-de88-4a4a-b14a-93024546ba1c"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000), "advanced", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010) },
                    { new Guid("e3bcc20f-fedc-4dc6-b3fe-53aaeba48638"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010), "legend", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9010) },
                    { new Guid("ee83ef3c-5634-42ec-a894-d030f3c52073"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000), "beginner", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9000) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("41a03351-b5b3-4205-ab60-4207d27694d8"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070) },
                    { new Guid("cd4f7bc7-7b74-41d1-96fd-d837a92eae14"), new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 19, 43, 987, DateTimeKind.Utc).AddTicks(9070) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("166b7711-6753-4649-b892-fb54fa02e87f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("35010f53-46bd-417d-ad2f-422c55540d02"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3de1ebef-cfe1-4246-a537-4ab108d871f3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("43cdab9e-6697-4dcb-906a-426057efaad0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4675098c-4c3d-43ae-a6b9-089cab6d6b79"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("503aa484-478b-4f2f-a2ce-79cf9b68240f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("541b994f-af8d-47c4-83e3-bd3db76b28a3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6a3708be-a7e0-4dd2-8daf-1b8406653c99"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a2dd800c-4e06-46e6-9546-d70765a4e43a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a9a06ffe-c17d-41fe-b43e-5083e5c8acc8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("abe98df5-188b-47d4-8ea8-fc3c646ee87c"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("23f2782f-7b09-4211-941c-a9d1053b5e09"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2af9e98f-0efd-42d6-91a1-eceb42e5944f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("7d833732-c405-414a-aaa6-eb82810132ce"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c6459277-de88-4a4a-b14a-93024546ba1c"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc20f-fedc-4dc6-b3fe-53aaeba48638"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("ee83ef3c-5634-42ec-a894-d030f3c52073"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("41a03351-b5b3-4205-ab60-4207d27694d8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd4f7bc7-7b74-41d1-96fd-d837a92eae14"));

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
    }
}
