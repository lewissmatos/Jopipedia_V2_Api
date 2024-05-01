using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserIds",
                table: "UserRanks");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a63911d-b683-4039-9110-a3381d266c08"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "History Quizzes", true, "History", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("2708e229-fc8d-41e3-b32e-f234405b02a1"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "Chemistry Quizzes", true, "Chemistry", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("3913ff68-477b-479f-b364-b291c7516522"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Biology Quizzes", true, "Biology", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("525ac2c4-480b-4989-a1bc-e7c738e07be1"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), "Geography Quizzes", true, "Geography", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(260), null },
                    { new Guid("879b5bcc-8961-4296-9318-af4a1dc26f0b"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), "Sports Quizzes", true, "Sports", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), null },
                    { new Guid("8e302fb1-3985-42f0-bee0-2db93ffbd508"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(270), "Computer Science Quizzes", true, "Computer-Science", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(270), null },
                    { new Guid("9cf28dc7-20f5-43c0-9771-18a9878dbf99"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Physics Quizzes", true, "Physics", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("9d384d71-d63b-4b38-a74d-bf9090b326a3"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), "General Knowledge Quizzes", true, "General-Knowledge", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), null },
                    { new Guid("9d4df450-e3a5-4ddc-b6c3-c69fc648dec7"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), "Movies Quizzes", true, "Movies", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), null },
                    { new Guid("b07d4ce8-ed07-4a11-857d-c8d029186891"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), "Mathematics Quizzes", true, "Mathematics", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(250), null },
                    { new Guid("b6c40d2a-89a9-40c2-9ba1-3c2b889dd32a"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), "Music Quizzes", true, "Music", new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(290), null }
                });

            migrationBuilder.InsertData(
                table: "UserRanks",
                columns: new[] { "Id", "CreatedAt", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01e0424b-a389-4063-9c0c-18611eb7b576"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230), "advanced", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) },
                    { new Guid("24da4604-f129-4124-8a09-190c99232d71"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220), "intermediate", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) },
                    { new Guid("35c87863-0f6e-4cd8-88bc-ed264cef5b39"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(200), "rookie", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(200) },
                    { new Guid("5691c9e7-811c-4392-b14b-5798c4dee02f"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240), "legend", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(240) },
                    { new Guid("77279fb8-b5ad-4aa6-aeb6-47fa64767898"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220), "beginner", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(220) },
                    { new Guid("d0d3798f-61c9-483c-b282-11363ab5ead4"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230), "expert", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(230) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("932d9e2d-8d19-46c3-87ec-f0abab5ae363"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(310), "Can Play Quizzes and Earn EX, Can Play the Stop Game", "COMMON", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(310) },
                    { new Guid("b66683bb-8fc8-4bf3-ae3f-e3e432549737"), new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300), "Can Create Topics, Disable Users and Create Events", "ADMIN", true, new DateTime(2024, 4, 14, 17, 7, 21, 505, DateTimeKind.Utc).AddTicks(300) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1a63911d-b683-4039-9110-a3381d266c08"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2708e229-fc8d-41e3-b32e-f234405b02a1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3913ff68-477b-479f-b364-b291c7516522"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("525ac2c4-480b-4989-a1bc-e7c738e07be1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("879b5bcc-8961-4296-9318-af4a1dc26f0b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8e302fb1-3985-42f0-bee0-2db93ffbd508"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9cf28dc7-20f5-43c0-9771-18a9878dbf99"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9d384d71-d63b-4b38-a74d-bf9090b326a3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9d4df450-e3a5-4ddc-b6c3-c69fc648dec7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b07d4ce8-ed07-4a11-857d-c8d029186891"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b6c40d2a-89a9-40c2-9ba1-3c2b889dd32a"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("01e0424b-a389-4063-9c0c-18611eb7b576"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("24da4604-f129-4124-8a09-190c99232d71"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("35c87863-0f6e-4cd8-88bc-ed264cef5b39"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("5691c9e7-811c-4392-b14b-5798c4dee02f"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("77279fb8-b5ad-4aa6-aeb6-47fa64767898"));

            migrationBuilder.DeleteData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("d0d3798f-61c9-483c-b282-11363ab5ead4"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("932d9e2d-8d19-46c3-87ec-f0abab5ae363"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b66683bb-8fc8-4bf3-ae3f-e3e432549737"));

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
    }
}
