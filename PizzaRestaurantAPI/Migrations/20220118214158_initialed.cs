using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaRestaurantAPI.Migrations
{
    public partial class initialed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Pizzas");
        }
    }
}
