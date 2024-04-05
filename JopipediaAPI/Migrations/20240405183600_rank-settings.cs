using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ranksettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "UserRanks");

            migrationBuilder.AddColumn<double>(
                name: "RankingValue",
                table: "Users",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RankingValue",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "UserRanks",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
