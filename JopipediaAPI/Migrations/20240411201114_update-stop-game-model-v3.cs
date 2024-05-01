using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatestopgamemodelv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGameAnswers_StopGameRounds_StopGameRoundId",
                table: "StopGameAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_StopGameRounds_StopGames_StopGameId",
                table: "StopGameRounds");

            migrationBuilder.DropIndex(
                name: "IX_StopGameAnswers_StopGameRoundId",
                table: "StopGameAnswers");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "StopGameRounds");

            migrationBuilder.DropColumn(
                name: "StopGameRoundId",
                table: "StopGameAnswers");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StopGames",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "StopGameId",
                table: "StopGameRounds",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "StopGameAnswers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "StopGameAnswers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "RoundId",
                table: "StopGameAnswers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_StopGames_Code",
                table: "StopGames",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StopGameAnswers_RoundId",
                table: "StopGameAnswers",
                column: "RoundId");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGameAnswers_StopGameRounds_RoundId",
                table: "StopGameAnswers",
                column: "RoundId",
                principalTable: "StopGameRounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StopGameRounds_StopGames_StopGameId",
                table: "StopGameRounds",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGameAnswers_StopGameRounds_RoundId",
                table: "StopGameAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_StopGameRounds_StopGames_StopGameId",
                table: "StopGameRounds");

            migrationBuilder.DropIndex(
                name: "IX_StopGames_Code",
                table: "StopGames");

            migrationBuilder.DropIndex(
                name: "IX_StopGameAnswers_RoundId",
                table: "StopGameAnswers");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "StopGames");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "StopGameAnswers");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "StopGameAnswers");

            migrationBuilder.DropColumn(
                name: "RoundId",
                table: "StopGameAnswers");

            migrationBuilder.AlterColumn<Guid>(
                name: "StopGameId",
                table: "StopGameRounds",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<List<string>>(
                name: "Category",
                table: "StopGameRounds",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "StopGameRoundId",
                table: "StopGameAnswers",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StopGameAnswers_StopGameRoundId",
                table: "StopGameAnswers",
                column: "StopGameRoundId");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGameAnswers_StopGameRounds_StopGameRoundId",
                table: "StopGameAnswers",
                column: "StopGameRoundId",
                principalTable: "StopGameRounds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGameRounds_StopGames_StopGameId",
                table: "StopGameRounds",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id");
        }
    }
}
