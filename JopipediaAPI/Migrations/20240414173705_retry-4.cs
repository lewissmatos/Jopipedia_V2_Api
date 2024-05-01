using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class retry4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0eff2bee-c307-40a9-a33d-ed200d05f6f0"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), null },
                    { new Guid("2351862d-b220-44b7-99c8-f0fc6e7cee39"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8170), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8170), null },
                    { new Guid("30d0d915-3c36-4e54-b51f-bf525d315ef0"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8170), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8170), null },
                    { new Guid("36d8ee06-6c66-4af7-9794-7b844eb0ddce"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("a78b397a-ab17-4212-9ac5-3c5739bb6582"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("b1f66e6a-baf6-44be-8787-f47c579fdd32"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), null },
                    { new Guid("cef3d3da-dfa9-4d2d-8c73-39bdeceb74ee"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8180), null },
                    { new Guid("cf3e8939-d8a6-4d01-82db-b2d2890146e6"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8200), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("f23c19cd-6790-4050-bcb8-0c5c98904c4e"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160), null },
                    { new Guid("f3a3bd90-438e-4f76-be07-ad24ccc38841"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("f8a55bbf-d054-4080-add9-88c8b7524a9e"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8200), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8200), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a45d8f1-cf28-4875-be4a-e42d93fad4be"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8120), "rookie", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8120) },
                    { new Guid("5129caaa-da66-4553-8030-cd16a9d3da35"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8150), "intermediate", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8150) },
                    { new Guid("9bf4ed25-9638-4db6-9c0a-7459e1057335"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160), "legend", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160) },
                    { new Guid("ae3a827c-7d73-4f9b-b458-8b10d7850a1f"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8150), "advanced", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8150) },
                    { new Guid("c93c0831-e76e-494c-a7ac-dd29d8a0888f"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160), "expert", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8160) },
                    { new Guid("f5a6f2ed-c886-4bca-b058-0aad5492ab2e"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8140), "beginner", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8140) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("032c41a9-39cb-45e9-8c17-32c29f562ce1"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8210), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8210) },
                    { new Guid("5cb0b2ff-92a9-4b62-8624-ccfe418f4fcf"), new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8210), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 37, 5, 379, DateTimeKind.Utc).AddTicks(8210) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0eff2bee-c307-40a9-a33d-ed200d05f6f0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2351862d-b220-44b7-99c8-f0fc6e7cee39"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("30d0d915-3c36-4e54-b51f-bf525d315ef0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("36d8ee06-6c66-4af7-9794-7b844eb0ddce"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a78b397a-ab17-4212-9ac5-3c5739bb6582"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b1f66e6a-baf6-44be-8787-f47c579fdd32"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cef3d3da-dfa9-4d2d-8c73-39bdeceb74ee"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cf3e8939-d8a6-4d01-82db-b2d2890146e6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f23c19cd-6790-4050-bcb8-0c5c98904c4e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f3a3bd90-438e-4f76-be07-ad24ccc38841"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f8a55bbf-d054-4080-add9-88c8b7524a9e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("1a45d8f1-cf28-4875-be4a-e42d93fad4be"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5129caaa-da66-4553-8030-cd16a9d3da35"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("9bf4ed25-9638-4db6-9c0a-7459e1057335"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("ae3a827c-7d73-4f9b-b458-8b10d7850a1f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c93c0831-e76e-494c-a7ac-dd29d8a0888f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f5a6f2ed-c886-4bca-b058-0aad5492ab2e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("032c41a9-39cb-45e9-8c17-32c29f562ce1"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cb0b2ff-92a9-4b62-8624-ccfe418f4fcf"));

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
    }
}
