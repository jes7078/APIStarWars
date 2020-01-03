using Microsoft.EntityFrameworkCore.Migrations;

namespace APIStarWars.Migrations
{
    public partial class ChangedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "TransportId",
                table: "Transports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "TransportId",
                table: "People",
                type: "text",
                nullable: true);
        }
    }
}
