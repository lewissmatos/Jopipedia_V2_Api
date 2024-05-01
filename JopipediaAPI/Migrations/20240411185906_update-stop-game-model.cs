using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatestopgamemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_StopGames_StopGameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StopGameId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StopGameId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "StopGameId",
                table: "StopGamePlayers",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StopGamePlayers_StopGameId",
                table: "StopGamePlayers",
                column: "StopGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers");

            migrationBuilder.DropIndex(
                name: "IX_StopGamePlayers_StopGameId",
                table: "StopGamePlayers");

            migrationBuilder.DropColumn(
                name: "StopGameId",
                table: "StopGamePlayers");

            migrationBuilder.AddColumn<Guid>(
                name: "StopGameId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_StopGameId",
                table: "Users",
                column: "StopGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StopGames_StopGameId",
                table: "Users",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id");
        }
    }
}
