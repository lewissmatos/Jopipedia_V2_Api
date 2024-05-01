using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1416250d-04b1-491e-8ce8-d4748290a17f"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), null },
                    { new Guid("25e17e9d-f4f2-470b-8c67-cf8d0b9184a6"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8600), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8600), null },
                    { new Guid("29b0808b-d063-429e-b25d-4a1d5bc3b30d"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), null },
                    { new Guid("34f25ab2-625d-44dd-b535-609de6b4fe00"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), null },
                    { new Guid("4b379321-a1a7-4f2f-bb36-fbcc5524eede"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), null },
                    { new Guid("6c7a7334-b396-4df9-84fe-88c6754b2a95"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), null },
                    { new Guid("71efce6e-1271-422e-a81f-c513f9f247c2"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), null },
                    { new Guid("72eaaf3a-f1e6-42cc-b035-9bc6f4cf455d"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8620), null },
                    { new Guid("87144168-cfc0-496c-952b-52fe00a1af64"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8610), null },
                    { new Guid("b0b45e56-2952-4ee5-9dbd-268cc285f6b9"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8630), null },
                    { new Guid("e45fec9f-8a7c-4607-af46-4f336fe563a9"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8600), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8600), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt", "UserIds" },
                values: new object[,]
                {
                    { new Guid("26e1561d-dc0a-4383-babe-3bceb2bb2454"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), "expert", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), null },
                    { new Guid("782f331a-5b95-41ba-b321-7e6ce90ca8d3"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8580), "intermediate", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8580), null },
                    { new Guid("850ab5a1-f94b-4d71-893b-c006fe6463e9"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8580), "beginner", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8580), null },
                    { new Guid("a69c8fd6-245d-472f-801a-0cebef972fba"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), "legend", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), null },
                    { new Guid("bbf0f4d7-1a95-4410-a1a3-fad741c17962"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8550), "rookie", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8550), null },
                    { new Guid("eab1bb0d-0c36-43ad-af4b-5e0c444d4b32"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), "advanced", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8590), null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7afd961a-99ee-45d4-bc7d-2b094f54b908"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8640), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8650) },
                    { new Guid("b611ba94-0a12-4706-b5ab-ffbe62f99b92"), new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8640), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 4, 49, 137, DateTimeKind.Utc).AddTicks(8640) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1416250d-04b1-491e-8ce8-d4748290a17f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("25e17e9d-f4f2-470b-8c67-cf8d0b9184a6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("29b0808b-d063-429e-b25d-4a1d5bc3b30d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("34f25ab2-625d-44dd-b535-609de6b4fe00"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4b379321-a1a7-4f2f-bb36-fbcc5524eede"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6c7a7334-b396-4df9-84fe-88c6754b2a95"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("71efce6e-1271-422e-a81f-c513f9f247c2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("72eaaf3a-f1e6-42cc-b035-9bc6f4cf455d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("87144168-cfc0-496c-952b-52fe00a1af64"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b0b45e56-2952-4ee5-9dbd-268cc285f6b9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e45fec9f-8a7c-4607-af46-4f336fe563a9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("26e1561d-dc0a-4383-babe-3bceb2bb2454"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("782f331a-5b95-41ba-b321-7e6ce90ca8d3"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("850ab5a1-f94b-4d71-893b-c006fe6463e9"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("a69c8fd6-245d-472f-801a-0cebef972fba"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("bbf0f4d7-1a95-4410-a1a3-fad741c17962"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("eab1bb0d-0c36-43ad-af4b-5e0c444d4b32"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7afd961a-99ee-45d4-bc7d-2b094f54b908"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b611ba94-0a12-4706-b5ab-ffbe62f99b92"));

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
    }
}
