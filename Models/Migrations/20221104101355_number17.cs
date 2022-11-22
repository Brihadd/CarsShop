using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
