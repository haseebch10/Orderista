using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class UpdateChop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 1,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 2,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 3,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 4,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 5,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 7,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 8,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 10,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 12,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 13,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 14,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 15,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 16,
                column: "RestaurantRuId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 17,
                column: "RestaurantRuId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 1,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 2,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 3,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 4,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 5,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 7,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 8,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 10,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 12,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 13,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 14,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 15,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 16,
                column: "RestaurantRuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 17,
                column: "RestaurantRuId",
                value: 1);
        }
    }
}
