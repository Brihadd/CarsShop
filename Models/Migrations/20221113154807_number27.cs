using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RequaredPrice",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequaredPrice",
                table: "Cars");
        }
    }
}
