using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class DeskQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DeskQuote_DeskId",
                table: "DeskQuote");

            migrationBuilder.AddColumn<decimal>(
                name: "QuotePrice",
                table: "DeskQuote",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_DeskQuote_DeskId",
                table: "DeskQuote",
                column: "DeskId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DeskQuote_DeskId",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "QuotePrice",
                table: "DeskQuote");

            migrationBuilder.CreateIndex(
                name: "IX_DeskQuote_DeskId",
                table: "DeskQuote",
                column: "DeskId");
        }
    }
}
