using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGIS.Migrations
{
    public partial class updatereference2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IzvornoMjerilo",
                table: "Cestice",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IzvornoMjerilo",
                table: "Cestice");
        }
    }
}
