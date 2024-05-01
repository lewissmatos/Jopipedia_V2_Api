using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00b6c52c-9239-46c4-b82f-babb2d55b438"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), null },
                    { new Guid("16bf4fbc-08a0-4783-a751-10068a2ad5a6"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), null },
                    { new Guid("1dd54bbf-8b61-43e8-9684-3733b82ca95e"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), null },
                    { new Guid("5e650a4c-2335-4ed7-98e6-0ffcfc622474"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), null },
                    { new Guid("81fb6893-f0be-4b1e-bc55-6192368d89e0"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9660), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9660), null },
                    { new Guid("86e914fc-f683-4e6b-aec9-c95a2742c784"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9620), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9620), null },
                    { new Guid("9cfe3f78-d725-48c4-9c29-fbfce9b763e7"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), null },
                    { new Guid("c50eac5a-8678-49ae-b0fa-f130efe87f96"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9650), null },
                    { new Guid("caf318e1-4978-416e-a8bf-d73be758d3cd"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), null },
                    { new Guid("da867ebb-2609-4635-a16f-ca980b2ef440"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9630), null },
                    { new Guid("f041eff4-ba88-4d68-984e-67a80b27e937"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9640), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("30b5fd1f-0f4a-4702-8a6d-7764735730cd"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9580), "rookie", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9580) },
                    { new Guid("7366d8f4-7f60-402a-8f1b-0fe8f78faeaa"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9600), "beginner", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9600) },
                    { new Guid("d45c01cd-f5f5-4a4a-86d0-690b908d603d"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610), "expert", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610) },
                    { new Guid("e52ae747-0a05-4dd0-b1c9-3d19becb683a"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9620), "legend", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9620) },
                    { new Guid("e73ceb37-0429-40e4-9e54-e7e9444435d5"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610), "advanced", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610) },
                    { new Guid("f89c536a-a910-4017-8fb6-ec658567b5cf"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610), "intermediate", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9610) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c9ab5055-4893-4d00-bb80-4e97061535b9"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9670), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9670) },
                    { new Guid("e6a39eab-a24c-415b-ad53-9ffc7f480622"), new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9660), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 18, 21, 16, 470, DateTimeKind.Utc).AddTicks(9660) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("00b6c52c-9239-46c4-b82f-babb2d55b438"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("16bf4fbc-08a0-4783-a751-10068a2ad5a6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1dd54bbf-8b61-43e8-9684-3733b82ca95e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e650a4c-2335-4ed7-98e6-0ffcfc622474"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("81fb6893-f0be-4b1e-bc55-6192368d89e0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("86e914fc-f683-4e6b-aec9-c95a2742c784"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9cfe3f78-d725-48c4-9c29-fbfce9b763e7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c50eac5a-8678-49ae-b0fa-f130efe87f96"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("caf318e1-4978-416e-a8bf-d73be758d3cd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("da867ebb-2609-4635-a16f-ca980b2ef440"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f041eff4-ba88-4d68-984e-67a80b27e937"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("30b5fd1f-0f4a-4702-8a6d-7764735730cd"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("7366d8f4-7f60-402a-8f1b-0fe8f78faeaa"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d45c01cd-f5f5-4a4a-86d0-690b908d603d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("e52ae747-0a05-4dd0-b1c9-3d19becb683a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("e73ceb37-0429-40e4-9e54-e7e9444435d5"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f89c536a-a910-4017-8fb6-ec658567b5cf"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9ab5055-4893-4d00-bb80-4e97061535b9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e6a39eab-a24c-415b-ad53-9ffc7f480622"));

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
    }
}
