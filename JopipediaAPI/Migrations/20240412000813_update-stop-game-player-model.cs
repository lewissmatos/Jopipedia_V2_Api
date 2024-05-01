using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatestopgameplayermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers");

            migrationBuilder.AlterColumn<Guid>(
                name: "StopGameId",
                table: "StopGamePlayers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FinalScore",
                table: "StopGamePlayers",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers");

            migrationBuilder.AlterColumn<Guid>(
                name: "StopGameId",
                table: "StopGamePlayers",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<double>(
                name: "FinalScore",
                table: "StopGamePlayers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StopGamePlayers_StopGames_StopGameId",
                table: "StopGamePlayers",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id");
        }
    }
}
