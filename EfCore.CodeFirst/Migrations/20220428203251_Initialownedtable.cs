using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.CodeFirst.Migrations
{
    public partial class Initialownedtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person_Age = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person_Age = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
