﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBaseModel8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "createdById",
                table: "Quizzes",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("01eaf4a0-72c2-4195-a415-d069c8eb9380"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0315d1cb-cf1f-4c19-82ca-c8060e1ec265"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("12c211b7-4604-4a2d-9d19-8a4b84162d8c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("167219a1-5934-4352-b710-2267cc06a702"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("57d53668-25dc-481d-b24c-9fa454e20d31"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9869f417-39c3-449c-8250-1aefe0a7444b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba339907-d44c-4c30-88ad-478a6b93134a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d5f8620b-c9b4-461b-b417-7b13d461731b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dac47999-47fa-413b-bc26-df7744aacbfe"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ed240c36-6781-4db9-9cd0-514f92d2594e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f141d671-969f-4d7b-b114-53ee325e691a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f72ac747-c9f8-4a13-ab99-1f559ef9a417"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("04484529-d942-4b8e-a07e-b74842c88925"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2a03d922-eb06-4354-9ff7-be091fdc5b13"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("486771e2-cd07-4892-a35f-996e2731bd20"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("61ffef2e-5dbe-4d5d-80c9-ca3081fd821f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("be247d3a-d360-48e8-965d-6d2179a0020c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f0ba3200-f315-4b33-afa3-cfdf3db43e00"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5b11963e-6248-4b81-ac6d-402f0ebee3d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("61ff516d-a1c8-44b8-b5b5-cca0853fb28d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 4, 15, 22, 58, 17, 378, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_createdById",
                table: "Quizzes",
                column: "createdById");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Users_createdById",
                table: "Quizzes",
                column: "createdById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Users_createdById",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_createdById",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "createdById",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("01eaf4a0-72c2-4195-a415-d069c8eb9380"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0315d1cb-cf1f-4c19-82ca-c8060e1ec265"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("12c211b7-4604-4a2d-9d19-8a4b84162d8c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("167219a1-5934-4352-b710-2267cc06a702"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("57d53668-25dc-481d-b24c-9fa454e20d31"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9869f417-39c3-449c-8250-1aefe0a7444b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba339907-d44c-4c30-88ad-478a6b93134a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d5f8620b-c9b4-461b-b417-7b13d461731b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dac47999-47fa-413b-bc26-df7744aacbfe"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ed240c36-6781-4db9-9cd0-514f92d2594e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f141d671-969f-4d7b-b114-53ee325e691a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f72ac747-c9f8-4a13-ab99-1f559ef9a417"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("04484529-d942-4b8e-a07e-b74842c88925"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("2a03d922-eb06-4354-9ff7-be091fdc5b13"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("486771e2-cd07-4892-a35f-996e2731bd20"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("61ffef2e-5dbe-4d5d-80c9-ca3081fd821f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("be247d3a-d360-48e8-965d-6d2179a0020c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRanks",
                keyColumn: "Id",
                keyValue: new Guid("f0ba3200-f315-4b33-afa3-cfdf3db43e00"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5b11963e-6248-4b81-ac6d-402f0ebee3d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("61ff516d-a1c8-44b8-b5b5-cca0853fb28d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 15, 22, 50, 26, 113, DateTimeKind.Utc).AddTicks(2490) });
        }
    }
}
