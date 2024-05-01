using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatestopgamemodel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames");

            migrationBuilder.AlterColumn<Guid>(
                name: "WinnerId",
                table: "StopGames",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<List<Guid>>(
                name: "RoundIds",
                table: "StopGames",
                type: "uuid[]",
                nullable: true,
                oldClrType: typeof(List<Guid>),
                oldType: "uuid[]");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames",
                column: "WinnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames");

            migrationBuilder.AlterColumn<Guid>(
                name: "WinnerId",
                table: "StopGames",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<List<Guid>>(
                name: "RoundIds",
                table: "StopGames",
                type: "uuid[]",
                nullable: false,
                oldClrType: typeof(List<Guid>),
                oldType: "uuid[]",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames",
                column: "WinnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
