using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class UpdatingDeskQuoteClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateQutoe",
                table: "DeskQuote",
                newName: "DateCreated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "DeskQuote",
                newName: "DateQutoe");
        }
    }
}
