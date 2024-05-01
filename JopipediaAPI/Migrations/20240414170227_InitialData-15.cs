using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0dbcd044-f48f-45d1-bc1d-e151a9ad4efb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2d74048d-e5d9-483b-b8dd-715c33826b3b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("34c0add8-c27d-4c58-9efa-bff2b6b20ae2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3cf499c4-16fd-4102-9873-6be06ec5978a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7a6acf6a-17f2-4f9d-b0d7-68fd1b595638"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("908adf4e-c7f1-4a39-bf22-49f985a2bb56"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a6f0d59c-a698-4cf5-acab-06d36e139e4e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b3078986-4716-4cd9-b7bd-38e1b1a8ae48"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cb7261c4-ed57-4b49-a2f2-8efe0d59f087"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e8129e21-a06c-44aa-9f76-6254631ed48c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("eeeaff63-0ae2-43ee-909a-39b711bd52f4"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("4b6c10df-c6ad-4b15-bc40-05bd5fedd8a3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("711060c0-0ad9-4f95-90da-a18650251c28"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("91acca60-e278-4185-be48-e28606313224"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("edf95d57-d45e-4c00-a2a2-487ea3ab99f7"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("fc2dbc71-9e89-44a1-937f-ea3e52fda480"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("ffea7f7c-27f9-4650-b11b-f8f81d12f84d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ce4a4d0-2998-478c-b016-5412a0a88e50"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b87b2b0f-dbf6-4dbb-89cb-f6dde10aa428"));

            migrationBuilder.AddColumn<List<Guid>>(
                name: "UserIds",
                table: "UserRanks",
                type: "uuid[]",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("122e5217-8bc9-4e70-910f-f1f2d77bdd1b"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), null },
                    { new Guid("15ad2285-ac1f-4787-b5b3-68695a4d1cd9"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("4a5b4fae-0c5f-4e17-bc92-917f9b9012df"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("609e2bcd-e70b-4dc6-947e-76e0a33e2516"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("6a49e067-8e66-40a5-be1f-b70c22ce5f20"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8190), null },
                    { new Guid("6dea86b6-04fe-4dd9-b4d9-a02ed8af465d"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("874fb14f-ad2d-4f90-a1bc-02ccda252dc9"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8180), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8180), null },
                    { new Guid("c664feba-d87e-404a-8e77-8102adba47d2"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), null },
                    { new Guid("dcb9a300-5193-4fa7-99d1-615c41910b47"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8180), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8180), null },
                    { new Guid("e24240ed-6897-4caf-91ce-3903415015b4"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8200), null },
                    { new Guid("f2124ff0-671e-4812-ab49-60423cc1ff39"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8210), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt", "UserIds" },
                values: new object[,]
                {
                    { new Guid("0518498e-de24-4769-bc86-439cc95d4af0"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), "legend", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), null },
                    { new Guid("6054704c-ca75-4e14-8513-a84636710686"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8160), "beginner", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8160), null },
                    { new Guid("636eb54d-1227-49a6-8e26-be3e3690fcac"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8140), "rookie", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8140), null },
                    { new Guid("66cbcb63-8749-40ff-86d9-9a244f07f312"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), "advanced", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), null },
                    { new Guid("7fd525b9-18c3-477c-912b-551ee6424613"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), "expert", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8170), null },
                    { new Guid("8a298c3a-25fb-46a0-8a39-951b3a4c6e2d"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8160), "intermediate", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8160), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7840146b-8c7f-423b-a9fb-a63a7b99c609"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8220), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8220) },
                    { new Guid("a9e8f85b-c52d-415e-b4a5-309fb5eb12df"), new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8230), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 2, 27, 691, DateTimeKind.Utc).AddTicks(8230) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("122e5217-8bc9-4e70-910f-f1f2d77bdd1b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("15ad2285-ac1f-4787-b5b3-68695a4d1cd9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4a5b4fae-0c5f-4e17-bc92-917f9b9012df"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("609e2bcd-e70b-4dc6-947e-76e0a33e2516"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6a49e067-8e66-40a5-be1f-b70c22ce5f20"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6dea86b6-04fe-4dd9-b4d9-a02ed8af465d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("874fb14f-ad2d-4f90-a1bc-02ccda252dc9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c664feba-d87e-404a-8e77-8102adba47d2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dcb9a300-5193-4fa7-99d1-615c41910b47"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e24240ed-6897-4caf-91ce-3903415015b4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f2124ff0-671e-4812-ab49-60423cc1ff39"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("0518498e-de24-4769-bc86-439cc95d4af0"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("6054704c-ca75-4e14-8513-a84636710686"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("636eb54d-1227-49a6-8e26-be3e3690fcac"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("66cbcb63-8749-40ff-86d9-9a244f07f312"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("7fd525b9-18c3-477c-912b-551ee6424613"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("8a298c3a-25fb-46a0-8a39-951b3a4c6e2d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7840146b-8c7f-423b-a9fb-a63a7b99c609"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("a9e8f85b-c52d-415e-b4a5-309fb5eb12df"));

            migrationBuilder.DropColumn(
                name: "UserIds",
                table: "UserRanks");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dbcd044-f48f-45d1-bc1d-e151a9ad4efb"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), null },
                    { new Guid("2d74048d-e5d9-483b-b8dd-715c33826b3b"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("34c0add8-c27d-4c58-9efa-bff2b6b20ae2"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), null },
                    { new Guid("3cf499c4-16fd-4102-9873-6be06ec5978a"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("7a6acf6a-17f2-4f9d-b0d7-68fd1b595638"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4660), null },
                    { new Guid("908adf4e-c7f1-4a39-bf22-49f985a2bb56"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("a6f0d59c-a698-4cf5-acab-06d36e139e4e"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4670), null },
                    { new Guid("b3078986-4716-4cd9-b7bd-38e1b1a8ae48"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("cb7261c4-ed57-4b49-a2f2-8efe0d59f087"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4650), null },
                    { new Guid("e8129e21-a06c-44aa-9f76-6254631ed48c"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4680), null },
                    { new Guid("eeeaff63-0ae2-43ee-909a-39b711bd52f4"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4640), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4b6c10df-c6ad-4b15-bc40-05bd5fedd8a3"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "expert", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("711060c0-0ad9-4f95-90da-a18650251c28"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620), "beginner", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620) },
                    { new Guid("91acca60-e278-4185-be48-e28606313224"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "advanced", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("edf95d57-d45e-4c00-a2a2-487ea3ab99f7"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620), "intermediate", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4620) },
                    { new Guid("fc2dbc71-9e89-44a1-937f-ea3e52fda480"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630), "legend", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4630) },
                    { new Guid("ffea7f7c-27f9-4650-b11b-f8f81d12f84d"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570), "rookie", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4570) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ce4a4d0-2998-478c-b016-5412a0a88e50"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690) },
                    { new Guid("b87b2b0f-dbf6-4dbb-89cb-f6dde10aa428"), new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 16, 51, 40, 174, DateTimeKind.Utc).AddTicks(4690) }
                });
        }
    }
}
