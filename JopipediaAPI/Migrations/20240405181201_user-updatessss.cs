using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class userupdatessss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Ranks_RankId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks");

            migrationBuilder.RenameTable(
                name: "Ranks",
                newName: "UserRanks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRanks",
                table: "UserRanks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRanks_RankId",
                table: "Users",
                column: "RankId",
                principalTable: "UserRanks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRanks_RankId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRanks",
                table: "UserRanks");

            migrationBuilder.RenameTable(
                name: "UserRanks",
                newName: "Ranks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ranks",
                table: "Ranks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Ranks_RankId",
                table: "Users",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id");
        }
    }
}
