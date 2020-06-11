using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class upd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_Menu_ItemMId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_ItemMId",
                table: "carts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
