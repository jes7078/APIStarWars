using Microsoft.EntityFrameworkCore.Migrations;

namespace APIStarWars.Migrations
{
    public partial class FixedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "People");
        }
    }
}
