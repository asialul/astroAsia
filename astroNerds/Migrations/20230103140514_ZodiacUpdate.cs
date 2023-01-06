using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace astroNerds.Migrations
{
    /// <inheritdoc />
    public partial class ZodiacUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Zodiac",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Zodiac");
        }
    }
}
