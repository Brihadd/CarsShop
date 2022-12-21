using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastBuyerName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastPricerName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastSallerName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastBuyerName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LastPricerName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LastSallerName",
                table: "Cars");
        }
    }
}
