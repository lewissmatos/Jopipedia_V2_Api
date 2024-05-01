using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("37c641d0-1621-4a72-bb1f-bf57bb5805d6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3a827dd9-6c30-41be-81ac-5a61aeb43f7a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4b159dc9-66a9-4983-b3e4-9424ecaa79be"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("51ae290e-1277-4d20-b286-e848d3ccbf8d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e102b99-9c25-4099-a8b1-ed6c8d89c447"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("70643450-127d-4825-8f40-6fc828dfd143"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8e176765-949f-4d2c-a81b-37a9d17640df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a5dfefcb-87d3-431d-9e11-6d606f360518"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bbef034c-f67f-4f8f-a25b-5f537d3ae2b6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d2a51fe6-f1b7-4486-a376-53e746ea2dc4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f37381ea-dfcc-4cf9-b7fc-f23f7b6e35b2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("47d700ad-76d4-4fdb-a565-404900ac917f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("53652543-f5a2-4fc6-87c3-b0aae2ef3921"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("37c641d0-1621-4a72-bb1f-bf57bb5805d6"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), null },
                    { new Guid("3a827dd9-6c30-41be-81ac-5a61aeb43f7a"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), null },
                    { new Guid("4b159dc9-66a9-4983-b3e4-9424ecaa79be"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null },
                    { new Guid("51ae290e-1277-4d20-b286-e848d3ccbf8d"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("5e102b99-9c25-4099-a8b1-ed6c8d89c447"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("70643450-127d-4825-8f40-6fc828dfd143"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8970), null },
                    { new Guid("8e176765-949f-4d2c-a81b-37a9d17640df"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8950), null },
                    { new Guid("a5dfefcb-87d3-431d-9e11-6d606f360518"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8930), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8930), null },
                    { new Guid("bbef034c-f67f-4f8f-a25b-5f537d3ae2b6"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null },
                    { new Guid("d2a51fe6-f1b7-4486-a376-53e746ea2dc4"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8940), null },
                    { new Guid("f37381ea-dfcc-4cf9-b7fc-f23f7b6e35b2"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8960), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("47d700ad-76d4-4fdb-a565-404900ac917f"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8840), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("53652543-f5a2-4fc6-87c3-b0aae2ef3921"), new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8870), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 26, 31, 96, DateTimeKind.Utc).AddTicks(8870) }
                });
        }
    }
}
