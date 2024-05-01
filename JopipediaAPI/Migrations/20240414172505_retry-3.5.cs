using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class retry35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("04d9a2fc-05df-43c2-8b6c-809aee4038e7"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), null },
                    { new Guid("0804f66f-4c8e-441e-afaa-61100931975e"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4600), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4600), null },
                    { new Guid("0b5ccd02-20dd-4296-8db9-505ef453a538"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), null },
                    { new Guid("2f180c7c-5d8c-4a60-985d-4256d5d3511c"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4560), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4560), null },
                    { new Guid("4a316445-94c4-471f-a33c-efc2db5fd471"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), null },
                    { new Guid("4fccbf78-dab2-4b39-be8f-c48b50033b6a"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540), null },
                    { new Guid("751c1f86-3a5e-40ec-ae88-90512ed0d787"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550), null },
                    { new Guid("797d6769-162a-4f25-a4f1-3b3017921a09"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4550), null },
                    { new Guid("96aafcd0-9d63-43a7-8261-4f31e9bf6c58"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), null },
                    { new Guid("a9468987-4ab5-4703-8fcf-eebedfc01eec"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4580), null },
                    { new Guid("bd957e23-9eb9-4bf5-84b5-91157d776160"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4590), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2eb1cc81-cea2-432d-9a26-bbdb82954ef1"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4520), "beginner", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4520) },
                    { new Guid("5d53bb93-bee5-4ce3-88e1-f26d49b74259"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540), "legend", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4540) },
                    { new Guid("820f1d62-369d-4b7b-9195-083e861c542f"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4490), "rookie", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4490) },
                    { new Guid("bb77d7db-9580-477b-b077-92c84b217aff"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530), "advanced", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("f6424503-ad4b-4d0e-b90b-f66a55d84cdd"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530), "expert", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("f815abea-aff3-4e72-85a3-ad9df86be93e"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530), "intermediate", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4530) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5a55129b-c844-4c32-95e1-c4a430d7a540"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610) },
                    { new Guid("f85f6359-6ad2-4551-acbe-c33656aec27c"), new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 25, 5, 238, DateTimeKind.Utc).AddTicks(4610) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("04d9a2fc-05df-43c2-8b6c-809aee4038e7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0804f66f-4c8e-441e-afaa-61100931975e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0b5ccd02-20dd-4296-8db9-505ef453a538"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2f180c7c-5d8c-4a60-985d-4256d5d3511c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4a316445-94c4-471f-a33c-efc2db5fd471"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4fccbf78-dab2-4b39-be8f-c48b50033b6a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("751c1f86-3a5e-40ec-ae88-90512ed0d787"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("797d6769-162a-4f25-a4f1-3b3017921a09"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("96aafcd0-9d63-43a7-8261-4f31e9bf6c58"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a9468987-4ab5-4703-8fcf-eebedfc01eec"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bd957e23-9eb9-4bf5-84b5-91157d776160"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2eb1cc81-cea2-432d-9a26-bbdb82954ef1"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5d53bb93-bee5-4ce3-88e1-f26d49b74259"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("820f1d62-369d-4b7b-9195-083e861c542f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bb77d7db-9580-477b-b077-92c84b217aff"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f6424503-ad4b-4d0e-b90b-f66a55d84cdd"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f815abea-aff3-4e72-85a3-ad9df86be93e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a55129b-c844-4c32-95e1-c4a430d7a540"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("f85f6359-6ad2-4551-acbe-c33656aec27c"));

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
    }
}
