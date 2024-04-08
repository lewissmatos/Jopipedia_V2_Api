using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JopipediaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateanswermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Answers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "isCorrect",
                table: "Answers",
                newName: "IsCorrect");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Answers",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "IsCorrect",
                table: "Answers",
                newName: "isCorrect");
        }
    }
}
