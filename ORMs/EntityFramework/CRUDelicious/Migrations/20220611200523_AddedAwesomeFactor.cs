using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDelicious.Migrations
{
    public partial class AddedAwesomeFactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AwesomeFactor",
                table: "Dishes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwesomeFactor",
                table: "Dishes");
        }
    }
}
