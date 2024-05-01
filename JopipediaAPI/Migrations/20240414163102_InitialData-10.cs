using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("037d4e1a-656e-49dc-9e4d-e14947bcf95c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1241faac-b7dc-41f1-a60f-d6063056838d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("22e52c35-8763-42e9-84c4-2bf32846f95a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("23b719dd-6b3d-4987-b2cc-8d917d22cfa8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("37f50944-6afa-41d3-a0ca-edf5529def92"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("62d9e7a6-37ed-459d-8bc2-aa6521ae9881"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("89d08887-6b3b-4040-897d-cb8dcaad0b54"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("933773ea-1892-44f2-bb5b-954a21990964"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ce1f3b7c-780f-4f33-8d78-1b0f6a9b0d2d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fb9fae6f-b458-4e7a-89b9-88f3bb0d92eb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ffb3d92d-a7d8-4888-b3da-91c044d375b6"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2ed50f62-6ee9-4c88-b21f-e8aed78bcd32"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("75c7f7e0-a57e-4a8d-9aa0-bf45252474f4"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("7fe3c0b6-529c-483b-96fe-abdb35f8a11f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("9324a1f9-3d91-4959-a8d7-aa0080858677"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("c1c07cb7-f14b-4178-b791-e876ae752c96"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f6742293-806c-487b-b156-22086bce3aee"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1b4c4ed6-9ac3-46d5-af84-2537a8fe708e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("bf8807fd-f004-49b1-a781-b427875f3bef"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("017274d8-5723-4f41-9b59-54b5c0b3bfa1"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), null },
                    { new Guid("0b7e7c56-8b8f-4f3b-9def-91e9b4bbc1c2"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), null },
                    { new Guid("120a6d2c-caa5-4092-9bf5-204882fce2de"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), null },
                    { new Guid("8158ef8d-4e23-42a5-88c2-5e9a6e41ef3b"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4160), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4160), null },
                    { new Guid("ac4f4260-47fa-4222-a526-8982a88c6310"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4170), null },
                    { new Guid("b72c7c80-2834-4147-a33a-6d8439e9493f"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4180), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4180), null },
                    { new Guid("c4163ce8-8989-438d-beec-b2a247b6b602"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4180), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4180), null },
                    { new Guid("cb827562-e16c-4d3a-9efd-e4492ea86b60"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4130), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4130), null },
                    { new Guid("ccf20219-a6c6-4985-92ad-e38a9ea93c3d"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4160), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4160), null },
                    { new Guid("e15a873c-5b22-4a54-8719-d8eba2ebbca7"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), null },
                    { new Guid("f48ba024-13b0-45ab-9476-36383fe60f7d"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4140), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("23dbcc51-6e30-4f0c-bdf8-6add7cda4f54"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110), "expert", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110) },
                    { new Guid("28c98325-a28b-4452-9beb-ecf56b6f0dcd"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4100), "rookie", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4100) },
                    { new Guid("47bde932-e512-4e17-9817-5517363e69d0"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4120), "legend", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4120) },
                    { new Guid("5bd48224-fc6f-4265-b5b6-6da4f0568319"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110), "advanced", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110) },
                    { new Guid("8ea7d604-98fb-4fd4-9edb-3c028b9caf08"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4100), "beginner", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4100) },
                    { new Guid("d6ea823d-9968-4cc0-9d56-540eabd8374f"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110), "intermediate", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4110) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("40cd18a6-63ed-4e02-94a5-611d5ff37fd9"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4030), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4030) },
                    { new Guid("68328b93-53bf-498e-941a-7435414226fe"), new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4010), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 31, 2, 712, DateTimeKind.Utc).AddTicks(4010) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("017274d8-5723-4f41-9b59-54b5c0b3bfa1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0b7e7c56-8b8f-4f3b-9def-91e9b4bbc1c2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("120a6d2c-caa5-4092-9bf5-204882fce2de"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8158ef8d-4e23-42a5-88c2-5e9a6e41ef3b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ac4f4260-47fa-4222-a526-8982a88c6310"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b72c7c80-2834-4147-a33a-6d8439e9493f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c4163ce8-8989-438d-beec-b2a247b6b602"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cb827562-e16c-4d3a-9efd-e4492ea86b60"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ccf20219-a6c6-4985-92ad-e38a9ea93c3d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e15a873c-5b22-4a54-8719-d8eba2ebbca7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f48ba024-13b0-45ab-9476-36383fe60f7d"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("23dbcc51-6e30-4f0c-bdf8-6add7cda4f54"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("28c98325-a28b-4452-9beb-ecf56b6f0dcd"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("47bde932-e512-4e17-9817-5517363e69d0"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5bd48224-fc6f-4265-b5b6-6da4f0568319"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8ea7d604-98fb-4fd4-9edb-3c028b9caf08"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d6ea823d-9968-4cc0-9d56-540eabd8374f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("40cd18a6-63ed-4e02-94a5-611d5ff37fd9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("68328b93-53bf-498e-941a-7435414226fe"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("037d4e1a-656e-49dc-9e4d-e14947bcf95c"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7240), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7250), null },
                    { new Guid("1241faac-b7dc-41f1-a60f-d6063056838d"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7240), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7240), null },
                    { new Guid("22e52c35-8763-42e9-84c4-2bf32846f95a"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7260), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7260), null },
                    { new Guid("23b719dd-6b3d-4987-b2cc-8d917d22cfa8"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7250), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7250), null },
                    { new Guid("37f50944-6afa-41d3-a0ca-edf5529def92"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7240), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7240), null },
                    { new Guid("62d9e7a6-37ed-459d-8bc2-aa6521ae9881"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), null },
                    { new Guid("89d08887-6b3b-4040-897d-cb8dcaad0b54"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7260), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7260), null },
                    { new Guid("933773ea-1892-44f2-bb5b-954a21990964"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7250), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7250), null },
                    { new Guid("ce1f3b7c-780f-4f33-8d78-1b0f6a9b0d2d"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), null },
                    { new Guid("fb9fae6f-b458-4e7a-89b9-88f3bb0d92eb"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7220), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7220), null },
                    { new Guid("ffb3d92d-a7d8-4888-b3da-91c044d375b6"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7230), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ed50f62-6ee9-4c88-b21f-e8aed78bcd32"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7190), "beginner", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7190) },
                    { new Guid("75c7f7e0-a57e-4a8d-9aa0-bf45252474f4"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7190), "rookie", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7190) },
                    { new Guid("7fe3c0b6-529c-483b-96fe-abdb35f8a11f"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200), "expert", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200) },
                    { new Guid("9324a1f9-3d91-4959-a8d7-aa0080858677"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7210), "legend", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7210) },
                    { new Guid("c1c07cb7-f14b-4178-b791-e876ae752c96"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200), "advanced", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200) },
                    { new Guid("f6742293-806c-487b-b156-22086bce3aee"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200), "intermediate", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7200) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b4c4ed6-9ac3-46d5-af84-2537a8fe708e"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7110), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7110) },
                    { new Guid("bf8807fd-f004-49b1-a781-b427875f3bef"), new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7050), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 28, 1, 91, DateTimeKind.Utc).AddTicks(7050) }
                });
        }
    }
}
