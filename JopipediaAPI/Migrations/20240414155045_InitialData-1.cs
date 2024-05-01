using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1a8c0e36-860d-49c8-b18d-3d18bcb3d08e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2ee138fe-21c1-47c0-9a9b-e12de0d4104e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("310244de-c3ad-42bc-8a40-793954d25bc8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("338dc9c7-5d63-4c1b-b0a3-eef6218f8c2e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3b48d64c-637f-48d1-9a82-3bb650033c34"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fc3093b-72a8-4498-9019-45fc134608e0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6bcbbc28-234c-4257-b640-78beae8393cc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8481f27e-23a7-44e3-a1a5-0ad8f2e0d2b2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ac39f695-e4e9-43cf-a6bd-ce3665414e0a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e16b7532-aa9f-435a-abad-a6a2dfc0b3a9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fe4fc2ca-e4be-467d-9d50-a9d53e97b697"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("0fcd8c93-ef28-4fa4-bd7c-17c016672b58"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8866fbd0-efb1-43d3-b9fb-0ef48019a956"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8c6593b6-5a50-4fed-9b60-a114f2c69c87"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("a9109320-5123-4226-b191-4fcc59c4f8fb"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("efb87484-e348-425e-8e4e-842b2e3f11d8"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fe0e145f-7ff7-4e2b-abbc-179db95748d5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("2a26f129-fc3f-48ce-a633-230fb993ec5d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ec5cc66-004e-41b6-b12f-00b0482490db"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("04e802b3-ae1f-4de0-bef1-0501a0c4bd89"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("0bde6aad-5244-4e6e-995e-546b2531898f"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("1d92611d-134c-40a1-a636-1628f73cd029"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3990), null },
                    { new Guid("52dfba94-98fc-4143-a4f8-b31f0480f065"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), null },
                    { new Guid("5f4c58a7-3ff3-46e4-8806-1e99cb3b52a5"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), null },
                    { new Guid("71cccb5f-74a4-41f8-afac-a888b02a77bf"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4010), null },
                    { new Guid("7a2bf943-388e-40e4-bf7a-b6863248630a"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("84718173-425b-4f9c-b393-94498678543b"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("97b8e048-a24b-4c33-81ce-cb0dddaf93df"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3980), null },
                    { new Guid("9b5a7254-d650-448c-bd07-7f1cc771be07"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(4000), null },
                    { new Guid("b8839e79-9ec4-4395-9b81-fe0244a2c00e"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3970), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3970), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("019f5cad-4b10-4c36-b0b1-73bf33b6d826"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940), "beginner", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940) },
                    { new Guid("194614f9-f133-4372-bf51-bea9a665f0e3"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "advanced", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("2ac0bcca-0042-42a2-b8d1-8ac9553bb22a"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "expert", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("789b3e14-3813-4210-bd1f-cc03f65f288f"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950), "intermediate", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3950) },
                    { new Guid("b13bf655-aec2-43cd-ae63-5d063b1c5988"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940), "rookie", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3940) },
                    { new Guid("f40c7957-ef3b-476b-bacf-570ab55b54a8"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3960), "legend", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3960) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("327f8be1-dfad-415f-a149-288d0f334419"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3880), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3880) },
                    { new Guid("bdefb79a-884d-4a62-aea3-d6283c8d88f6"), new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3850), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 15, 50, 45, 546, DateTimeKind.Utc).AddTicks(3850) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("04e802b3-ae1f-4de0-bef1-0501a0c4bd89"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0bde6aad-5244-4e6e-995e-546b2531898f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1d92611d-134c-40a1-a636-1628f73cd029"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("52dfba94-98fc-4143-a4f8-b31f0480f065"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5f4c58a7-3ff3-46e4-8806-1e99cb3b52a5"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("71cccb5f-74a4-41f8-afac-a888b02a77bf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7a2bf943-388e-40e4-bf7a-b6863248630a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("84718173-425b-4f9c-b393-94498678543b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("97b8e048-a24b-4c33-81ce-cb0dddaf93df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9b5a7254-d650-448c-bd07-7f1cc771be07"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b8839e79-9ec4-4395-9b81-fe0244a2c00e"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("019f5cad-4b10-4c36-b0b1-73bf33b6d826"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("194614f9-f133-4372-bf51-bea9a665f0e3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2ac0bcca-0042-42a2-b8d1-8ac9553bb22a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("789b3e14-3813-4210-bd1f-cc03f65f288f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("b13bf655-aec2-43cd-ae63-5d063b1c5988"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f40c7957-ef3b-476b-bacf-570ab55b54a8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("327f8be1-dfad-415f-a149-288d0f334419"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("bdefb79a-884d-4a62-aea3-d6283c8d88f6"));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a8c0e36-860d-49c8-b18d-3d18bcb3d08e"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), null },
                    { new Guid("2ee138fe-21c1-47c0-9a9b-e12de0d4104e"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3860), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3860), null },
                    { new Guid("310244de-c3ad-42bc-8a40-793954d25bc8"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), null },
                    { new Guid("338dc9c7-5d63-4c1b-b0a3-eef6218f8c2e"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), null },
                    { new Guid("3b48d64c-637f-48d1-9a82-3bb650033c34"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3830), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3830), null },
                    { new Guid("3fc3093b-72a8-4498-9019-45fc134608e0"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3860), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3860), null },
                    { new Guid("6bcbbc28-234c-4257-b640-78beae8393cc"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), null },
                    { new Guid("8481f27e-23a7-44e3-a1a5-0ad8f2e0d2b2"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3820), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3820), null },
                    { new Guid("ac39f695-e4e9-43cf-a6bd-ce3665414e0a"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3830), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3830), null },
                    { new Guid("e16b7532-aa9f-435a-abad-a6a2dfc0b3a9"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3850), null },
                    { new Guid("fe4fc2ca-e4be-467d-9d50-a9d53e97b697"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3840), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fcd8c93-ef28-4fa4-bd7c-17c016672b58"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3810), "expert", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3810) },
                    { new Guid("8866fbd0-efb1-43d3-b9fb-0ef48019a956"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800), "beginner", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800) },
                    { new Guid("8c6593b6-5a50-4fed-9b60-a114f2c69c87"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800), "advanced", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800) },
                    { new Guid("a9109320-5123-4226-b191-4fcc59c4f8fb"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3810), "legend", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3810) },
                    { new Guid("efb87484-e348-425e-8e4e-842b2e3f11d8"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800), "intermediate", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3800) },
                    { new Guid("fe0e145f-7ff7-4e2b-abbc-179db95748d5"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3790), "rookie", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3790) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2a26f129-fc3f-48ce-a633-230fb993ec5d"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3720), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3720) },
                    { new Guid("6ec5cc66-004e-41b6-b12f-00b0482490db"), new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3620), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 14, 27, 41, 360, DateTimeKind.Utc).AddTicks(3620) }
                });
        }
    }
}
