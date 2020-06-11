using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class IntitalCHopp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Restaurants");

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photopath = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    RestaurantRuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.MId);
                    table.ForeignKey(
                        name: "FK_MenuItem_Restaurants_RestaurantRuId",
                        column: x => x.RestaurantRuId,
                        principalTable: "Restaurants",
                        principalColumn: "RuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_RestaurantRuId",
                table: "MenuItem",
                column: "RestaurantRuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Restaurants",
                nullable: true);
        }
    }
}
