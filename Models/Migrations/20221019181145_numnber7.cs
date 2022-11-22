using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class numnber7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Employees",
                newName: "EmployeePassword");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeePassword",
                table: "Employees",
                newName: "Password");
        }
    }
}
