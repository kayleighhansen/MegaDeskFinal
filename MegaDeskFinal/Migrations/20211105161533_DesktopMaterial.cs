using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class DesktopMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desktopMaterial",
                table: "Desk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "desktopMaterial",
                table: "Desk",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
