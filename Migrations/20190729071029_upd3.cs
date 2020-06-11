using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class upd3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemMId",
                table: "carts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1,
                column: "ItemMId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_carts_ItemMId",
                table: "carts",
                column: "ItemMId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_Menu_ItemMId",
                table: "carts",
                column: "ItemMId",
                principalTable: "Menu",
                principalColumn: "MId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_Menu_ItemMId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_ItemMId",
                table: "carts");

            migrationBuilder.AlterColumn<int>(
                name: "ItemMId",
                table: "carts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1,
                column: "ItemMId",
                value: 0);
        }
    }
}
