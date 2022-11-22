using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerComment",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "PricerComment",
                table: "Cars",
                newName: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Cars",
                newName: "PricerComment");

            migrationBuilder.AddColumn<string>(
                name: "BuyerComment",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
