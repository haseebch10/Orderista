using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class user1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_Menu_ItemMId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_ItemMId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_UserId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "ItemMId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "carts");

            migrationBuilder.AddColumn<int>(
                name: "Cartid",
                table: "Menu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Menu",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usercartid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Cartid",
                table: "Menu",
                column: "Cartid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Usercartid",
                table: "AspNetUsers",
                column: "Usercartid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_carts_Usercartid",
                table: "AspNetUsers",
                column: "Usercartid",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_carts_Cartid",
                table: "Menu",
                column: "Cartid",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_carts_Usercartid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_carts_Cartid",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_Cartid",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Usercartid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cartid",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Usercartid",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ItemMId",
                table: "carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "carts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_carts_ItemMId",
                table: "carts",
                column: "ItemMId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserId",
                table: "carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_Menu_ItemMId",
                table: "carts",
                column: "ItemMId",
                principalTable: "Menu",
                principalColumn: "MId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
