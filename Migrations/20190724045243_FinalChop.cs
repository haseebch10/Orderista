using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class FinalChop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 1,
                columns: new[] { "Category", "ItemName" },
                values: new object[] { "Soup", "Hot & Sour Soup" });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MId", "Category", "ItemName", "Photopath", "Price", "RestaurantRuId" },
                values: new object[,]
                {
                    { 15, "Chicken", "Kung Pao", null, 290, 1 },
                    { 14, "Chicken", "Szechuan", null, 290, 1 },
                    { 13, "Chicken", "Hot Garlic", null, 290, 1 },
                    { 12, "Starters", "Spring Rolls", null, 190, 1 },
                    { 11, "Starters", "Drum Sticks", null, 260, 1 },
                    { 10, "Starters", "Honey Wings", null, 220, 1 },
                    { 16, "Chicken", "Manchurian", null, 290, 1 },
                    { 9, "Noodles", "American Choupsuey", null, 290, 1 },
                    { 7, "Specials", "Crispy Honey Beef", null, 350, 1 },
                    { 6, "Specials", "Beef Chilli Dry", null, 390, 1 },
                    { 5, "Specials", "Fish Chilli Dry", null, 390, 1 },
                    { 4, "Specials", "Chicken Chilli Dry", null, 290, 1 },
                    { 3, "Soup", "Chicken Corn Soup", null, 150, 1 },
                    { 2, "Soup", "Thai Soup", null, 150, 1 },
                    { 8, "Noodles", "Chicken Chowmein", null, 290, 1 },
                    { 17, "Chicken", "Black Pepper", null, 290, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "MId",
                keyValue: 1,
                columns: new[] { "Category", "ItemName" },
                values: new object[] { null, "Chicken Corn Soup" });
        }
    }
}
