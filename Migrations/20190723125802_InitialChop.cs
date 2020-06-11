using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class InitialChop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantRuId",
                table: "MenuItem");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantRuId",
                table: "MenuItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MId", "Category", "ItemName", "Photopath", "Price", "RestaurantRuId" },
                values: new object[] { 1, null, "Chicken Corn Soup", null, 150, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantRuId",
                table: "MenuItem",
                column: "RestaurantRuId",
                principalTable: "Restaurants",
                principalColumn: "RuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantRuId",
                table: "MenuItem");

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantRuId",
                table: "MenuItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantRuId",
                table: "MenuItem",
                column: "RestaurantRuId",
                principalTable: "Restaurants",
                principalColumn: "RuId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
