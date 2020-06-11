using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MId",
                keyValue: 17);

            migrationBuilder.RenameColumn(
                name: "RId",
                table: "Menu",
                newName: "RestaurantRuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantRuId",
                table: "Menu",
                column: "RestaurantRuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Restaurants_RestaurantRuId",
                table: "Menu",
                column: "RestaurantRuId",
                principalTable: "Restaurants",
                principalColumn: "RuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurants_RestaurantRuId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_RestaurantRuId",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "RestaurantRuId",
                table: "Menu",
                newName: "RId");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MId", "Category", "ItemName", "Photopath", "Price", "RId" },
                values: new object[,]
                {
                    { 1, "Soup", "Hot & Sour Soup", null, 150, 4 },
                    { 15, "Chicken", "Kung Pao", null, 290, 4 },
                    { 14, "Chicken", "Szechuan", null, 290, 4 },
                    { 13, "Chicken", "Hot Garlic", null, 290, 4 },
                    { 12, "Starters", "Spring Rolls", null, 190, 4 },
                    { 11, "Starters", "Drum Sticks", null, 260, 4 },
                    { 10, "Starters", "Honey Wings", null, 220, 4 },
                    { 16, "Chicken", "Manchurian", null, 290, 4 },
                    { 9, "Noodles", "American Choupsuey", null, 290, 4 },
                    { 7, "Specials", "Crispy Honey Beef", null, 350, 4 },
                    { 6, "Specials", "Beef Chilli Dry", null, 390, 4 },
                    { 5, "Specials", "Fish Chilli Dry", null, 390, 4 },
                    { 4, "Specials", "Chicken Chilli Dry", null, 290, 4 },
                    { 3, "Soup", "Chicken Corn Soup", null, 150, 4 },
                    { 2, "Soup", "Thai Soup", null, 150, 4 },
                    { 8, "Noodles", "Chicken Chowmein", null, 290, 4 },
                    { 17, "Chicken", "Black Pepper", null, 290, 4 }
                });
        }
    }
}
