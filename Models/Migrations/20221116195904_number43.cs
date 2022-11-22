using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientCarBuyerId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientCarBuyerId",
                table: "Cars");
        }
    }
}
