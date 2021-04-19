using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental.Migrations
{
    public partial class CarsInCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCars",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCars",
                table: "Categories");
        }
    }
}
