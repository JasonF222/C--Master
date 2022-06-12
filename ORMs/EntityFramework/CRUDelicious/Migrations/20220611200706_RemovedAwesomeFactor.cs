using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDelicious.Migrations
{
    public partial class RemovedAwesomeFactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwesomeFactor",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AwesomeFactor",
                table: "Dishes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
