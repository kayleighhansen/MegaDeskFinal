using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class width : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Depth",
                table: "Desk",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDrawers",
                table: "Desk",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Width",
                table: "Desk",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "desktopMaterial",
                table: "Desk",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Desk");

            migrationBuilder.DropColumn(
                name: "NumberOfDrawers",
                table: "Desk");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Desk");

            migrationBuilder.DropColumn(
                name: "desktopMaterial",
                table: "Desk");
        }
    }
}
