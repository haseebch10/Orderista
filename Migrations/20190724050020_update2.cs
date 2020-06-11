using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 9,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 11,
                column: "RestaurantRuId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 9,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 11,
                column: "RestaurantRuId",
                value: 1);
        }
    }
}
