using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class number46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarRegNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historys");
        }
    }
}
