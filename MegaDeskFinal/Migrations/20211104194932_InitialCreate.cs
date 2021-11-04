using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desk",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeskId = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<decimal>(type: "TEXT", nullable: false),
                    Depth = table.Column<decimal>(type: "TEXT", nullable: false),
                    NumberOfDrawers = table.Column<int>(type: "INTEGER", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    desktopMaterial = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    DeskQuoteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeskID = table.Column<int>(type: "INTEGER", nullable: true),
                    RushDays = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    QuoteDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    QuoteAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    shipping = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.DeskQuoteId);
                    table.ForeignKey(
                        name: "FK_DeskQuote_Desk_DeskID",
                        column: x => x.DeskID,
                        principalTable: "Desk",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeskQuote_DeskID",
                table: "DeskQuote",
                column: "DeskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");

            migrationBuilder.DropTable(
                name: "Desk");
        }
    }
}
