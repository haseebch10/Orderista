using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class u2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_UserId",
                table: "carts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "carts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "carts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1,
                column: "UserId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserId1",
                table: "carts",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserId1",
                table: "carts",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId1",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_UserId1",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "carts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "carts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_carts_UserId",
                table: "carts",
                column: "UserId");

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
