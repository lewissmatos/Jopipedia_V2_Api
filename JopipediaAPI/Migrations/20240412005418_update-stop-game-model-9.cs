using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatestopgamemodel9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames");

            migrationBuilder.DropIndex(
                name: "IX_StopGames_WinnerId",
                table: "StopGames");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StopGames_WinnerId",
                table: "StopGames",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_StopGames_Users_WinnerId",
                table: "StopGames",
                column: "WinnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
