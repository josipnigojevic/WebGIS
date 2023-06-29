using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGIS.Migrations
{
    public partial class updatereference3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrojCestice",
                table: "NaciniUporabe",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojCestice",
                table: "NaciniUporabe");
        }
    }
}
