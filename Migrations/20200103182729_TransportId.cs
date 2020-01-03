using Microsoft.EntityFrameworkCore.Migrations;

namespace APIStarWars.Migrations
{
    public partial class TransportId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "TransportId",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "People",
                type: "text",
                nullable: true);
        }
    }
}
