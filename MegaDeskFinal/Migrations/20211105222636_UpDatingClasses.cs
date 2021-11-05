using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskFinal.Migrations
{
    public partial class UpDatingClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desk_DesktopMaterial_DesktopMaterialId",
                table: "Desk");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_Desk_DeskId",
                table: "DeskQuote");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_ShippingType_ShippingTypeId",
                table: "DeskQuote");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingTypeId",
                table: "DeskQuote",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeskId",
                table: "DeskQuote",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DesktopMaterialId",
                table: "Desk",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Desk_DesktopMaterial_DesktopMaterialId",
                table: "Desk",
                column: "DesktopMaterialId",
                principalTable: "DesktopMaterial",
                principalColumn: "DesktopMaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_Desk_DeskId",
                table: "DeskQuote",
                column: "DeskId",
                principalTable: "Desk",
                principalColumn: "DeskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_ShippingType_ShippingTypeId",
                table: "DeskQuote",
                column: "ShippingTypeId",
                principalTable: "ShippingType",
                principalColumn: "ShippingTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desk_DesktopMaterial_DesktopMaterialId",
                table: "Desk");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_Desk_DeskId",
                table: "DeskQuote");

            migrationBuilder.DropForeignKey(
                name: "FK_DeskQuote_ShippingType_ShippingTypeId",
                table: "DeskQuote");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingTypeId",
                table: "DeskQuote",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DeskId",
                table: "DeskQuote",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DesktopMaterialId",
                table: "Desk",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Desk_DesktopMaterial_DesktopMaterialId",
                table: "Desk",
                column: "DesktopMaterialId",
                principalTable: "DesktopMaterial",
                principalColumn: "DesktopMaterialId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_Desk_DeskId",
                table: "DeskQuote",
                column: "DeskId",
                principalTable: "Desk",
                principalColumn: "DeskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskQuote_ShippingType_ShippingTypeId",
                table: "DeskQuote",
                column: "ShippingTypeId",
                principalTable: "ShippingType",
                principalColumn: "ShippingTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
