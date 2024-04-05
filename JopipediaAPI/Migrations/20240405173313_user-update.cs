using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class userupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwardUser_Award_AwardsId",
                table: "AwardUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Award",
                table: "Award");

            migrationBuilder.RenameTable(
                name: "Award",
                newName: "Awards");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Awards",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Awards",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Awards",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Awards",
                table: "Awards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AwardUser_Awards_AwardsId",
                table: "AwardUser",
                column: "AwardsId",
                principalTable: "Awards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwardUser_Awards_AwardsId",
                table: "AwardUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Awards",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Awards");

            migrationBuilder.RenameTable(
                name: "Awards",
                newName: "Award");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Award",
                table: "Award",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AwardUser_Award_AwardsId",
                table: "AwardUser",
                column: "AwardsId",
                principalTable: "Award",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
