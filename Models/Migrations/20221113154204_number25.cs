using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Cars",
                newName: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Cars",
                newName: "Photo");
        }
    }
}
