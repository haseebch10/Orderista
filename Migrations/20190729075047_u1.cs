using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class u1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserIdId",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "carts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_carts_UserIdId",
                table: "carts",
                newName: "IX_carts_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "carts",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_carts_UserId",
                table: "carts",
                newName: "IX_carts_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserIdId",
                table: "carts",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
