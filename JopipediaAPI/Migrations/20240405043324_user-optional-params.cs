using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class useroptionalparams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserLevels_LevelId",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "LevelId",
                table: "Users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserLevels_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "UserLevels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserLevels_LevelId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "LevelId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserLevels_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "UserLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
