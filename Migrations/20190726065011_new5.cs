using Microsoft.EntityFrameworkCore.Migrations;

namespace Orderista.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "carts",
                columns: new[] { "id", "ItemMId", "Quantity" },
                values: new object[] { 1, 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "carts",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
