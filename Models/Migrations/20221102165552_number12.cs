using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DealState",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DealState",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Cars");
        }
    }
}
