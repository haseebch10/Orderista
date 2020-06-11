using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class up4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Menu",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photopath = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MId", "Category", "ItemName", "Photopath", "Price" },
                values: new object[] { 1, "Soup", "Hot & Sour Soup", null, 150 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

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
    }
}
