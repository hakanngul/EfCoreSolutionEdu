using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.CodeFirst.Migrations
{
    public partial class AddTestForDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestForDb",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestForDb",
                table: "Products");
        }
    }
}
