using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class newmenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photopath",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantRuId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Restaurants",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantRuId",
                table: "Restaurants",
                column: "RestaurantRuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Restaurants_RestaurantRuId",
                table: "Restaurants",
                column: "RestaurantRuId",
                principalTable: "Restaurants",
                principalColumn: "RuId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Restaurants_RestaurantRuId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_RestaurantRuId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "MId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Photopath",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "RestaurantRuId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Restaurants");

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Photopath = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    RestaurantRuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.MId);
                    table.ForeignKey(
                        name: "FK_MenuItem_Restaurants_RestaurantRuId",
                        column: x => x.RestaurantRuId,
                        principalTable: "Restaurants",
                        principalColumn: "RuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MId", "Category", "ItemName", "Photopath", "Price", "RestaurantRuId" },
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
                    { 6, "Specials", "Beef Chilli Dry", null, 390, 1 },
                    { 5, "Specials", "Fish Chilli Dry", null, 390, 4 },
                    { 4, "Specials", "Chicken Chilli Dry", null, 290, 4 },
                    { 3, "Soup", "Chicken Corn Soup", null, 150, 4 },
                    { 2, "Soup", "Thai Soup", null, 150, 4 },
                    { 8, "Noodles", "Chicken Chowmein", null, 290, 4 },
                    { 17, "Chicken", "Black Pepper", null, 290, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_RestaurantRuId",
                table: "MenuItem",
                column: "RestaurantRuId");
        }
    }
}
