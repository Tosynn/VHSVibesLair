using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VHSVibesLair.Migrations
{
    /// <inheritdoc />
    public partial class Plot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "Movie",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plot",
                table: "Movie");
        }
    }
}
