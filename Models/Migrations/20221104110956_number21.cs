using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLuxury",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLuxury",
                table: "Cars");
        }
    }
}
