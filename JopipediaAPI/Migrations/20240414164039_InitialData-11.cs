using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserRoles",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(80)",
                oldMaxLength: 80);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserRoles",
                type: "character varying(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

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
    }
}
