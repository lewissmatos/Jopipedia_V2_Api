using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class stopgame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardIds",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "StopGameId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Topics",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Topics",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Topics",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Topics",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Scores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Scores",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Scores",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TopicId",
                table: "Awards",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "StopGamePlayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FinalScore = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopGamePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopGamePlayers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StopGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlayerIds = table.Column<List<Guid>>(type: "uuid[]", nullable: false),
                    RoundIds = table.Column<List<Guid>>(type: "uuid[]", nullable: false),
                    WinnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopGames_Users_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StopGameRounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Letter = table.Column<string>(type: "text", nullable: false),
                    AnswerIds = table.Column<List<Guid>>(type: "uuid[]", nullable: false),
                    Category = table.Column<List<string>>(type: "text[]", nullable: false),
                    StopGameId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopGameRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopGameRounds_StopGames_StopGameId",
                        column: x => x.StopGameId,
                        principalTable: "StopGames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StopGameAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false),
                    Score = table.Column<double>(type: "double precision", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    StopGameRoundId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopGameAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopGameAnswers_StopGameRounds_StopGameRoundId",
                        column: x => x.StopGameRoundId,
                        principalTable: "StopGameRounds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StopGameAnswers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_StopGameId",
                table: "Users",
                column: "StopGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_UserId",
                table: "Topics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_TopicId",
                table: "Awards",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_StopGameAnswers_StopGameRoundId",
                table: "StopGameAnswers",
                column: "StopGameRoundId");

            migrationBuilder.CreateIndex(
                name: "IX_StopGameAnswers_UserId",
                table: "StopGameAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StopGamePlayers_UserId",
                table: "StopGamePlayers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StopGameRounds_StopGameId",
                table: "StopGameRounds",
                column: "StopGameId");

            migrationBuilder.CreateIndex(
                name: "IX_StopGames_WinnerId",
                table: "StopGames",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Topics_TopicId",
                table: "Awards",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Users_UserId",
                table: "Topics",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StopGames_StopGameId",
                table: "Users",
                column: "StopGameId",
                principalTable: "StopGames",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Topics_TopicId",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Users_UserId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StopGames_StopGameId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "StopGameAnswers");

            migrationBuilder.DropTable(
                name: "StopGamePlayers");

            migrationBuilder.DropTable(
                name: "StopGameRounds");

            migrationBuilder.DropTable(
                name: "StopGames");

            migrationBuilder.DropIndex(
                name: "IX_Users_StopGameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Topics_UserId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Awards_TopicId",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "StopGameId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Awards");

            migrationBuilder.AddColumn<List<Guid>>(
                name: "AwardIds",
                table: "Users",
                type: "uuid[]",
                nullable: true);
        }
    }
}
