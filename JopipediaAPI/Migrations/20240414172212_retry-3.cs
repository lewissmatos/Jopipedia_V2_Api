using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class retry3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("05cbd14a-e28a-4aa7-94d3-b6af6ed4020a"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), null },
                    { new Guid("0fdd9060-59ef-493b-b909-af77a9c773ac"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), null },
                    { new Guid("707e7d8d-cd89-4632-b763-de857de55d0f"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), null },
                    { new Guid("8afd9893-824f-4497-bd5f-290a63bf0ed7"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), null },
                    { new Guid("8c26cbf0-bbd1-4812-9336-426205778428"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1340), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1340), null },
                    { new Guid("96956ddf-b4b8-4171-9954-c2e756f1d701"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1380), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1380), null },
                    { new Guid("9dd6e867-9d6e-4c61-939a-f5a47a486ff5"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1370), null },
                    { new Guid("a919150b-2f5f-47af-a046-d65f11652040"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1400), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1400), null },
                    { new Guid("caed081c-92ae-41d9-8eca-83a315558ce3"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1390), null },
                    { new Guid("d5ce32a2-b3ee-422c-a698-f883fc97835c"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1380), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1380), null },
                    { new Guid("ee72ff2b-e712-4186-bffb-efd71f44eb98"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1400), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1400), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a4e50c4-9292-411b-9b5b-df339740ce02"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1260), "rookie", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1260) },
                    { new Guid("36301c16-68bc-49bf-838d-4d0f4b66ccd9"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1320), "intermediate", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1320) },
                    { new Guid("f050638b-e236-4838-91c1-545eaf3d9f1c"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1320), "beginner", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1320) },
                    { new Guid("fb0d8dde-5fc1-4e9a-b9cb-fe5248419dd6"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1330), "expert", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1330) },
                    { new Guid("fc4d6f49-bbd4-429a-9506-c05736822c19"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1340), "legend", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1340) },
                    { new Guid("fc7490f8-a543-4f10-ab01-7a99bb819e93"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1330), "advanced", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1330) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("26f3c3e7-5543-4c69-8ae8-17b5fa55ec1f"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1410), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1410) },
                    { new Guid("53468452-27b1-4147-82ef-dc2a9e7f42f9"), new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1410), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 22, 12, 150, DateTimeKind.Utc).AddTicks(1410) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("05cbd14a-e28a-4aa7-94d3-b6af6ed4020a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0fdd9060-59ef-493b-b909-af77a9c773ac"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("707e7d8d-cd89-4632-b763-de857de55d0f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8afd9893-824f-4497-bd5f-290a63bf0ed7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8c26cbf0-bbd1-4812-9336-426205778428"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("96956ddf-b4b8-4171-9954-c2e756f1d701"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9dd6e867-9d6e-4c61-939a-f5a47a486ff5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a919150b-2f5f-47af-a046-d65f11652040"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("caed081c-92ae-41d9-8eca-83a315558ce3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d5ce32a2-b3ee-422c-a698-f883fc97835c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ee72ff2b-e712-4186-bffb-efd71f44eb98"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("1a4e50c4-9292-411b-9b5b-df339740ce02"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("36301c16-68bc-49bf-838d-4d0f4b66ccd9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f050638b-e236-4838-91c1-545eaf3d9f1c"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fb0d8dde-5fc1-4e9a-b9cb-fe5248419dd6"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fc4d6f49-bbd4-429a-9506-c05736822c19"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fc7490f8-a543-4f10-ab01-7a99bb819e93"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("26f3c3e7-5543-4c69-8ae8-17b5fa55ec1f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("53468452-27b1-4147-82ef-dc2a9e7f42f9"));

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
    }
}
