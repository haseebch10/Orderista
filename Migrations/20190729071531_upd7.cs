using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class upd7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "carts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserIdId",
                table: "carts",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserIdId",
                table: "carts",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserIdId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_UserIdId",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "carts");
        }
    }
}
