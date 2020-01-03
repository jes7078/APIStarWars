using Microsoft.EntityFrameworkCore.Migrations;

namespace APIStarWars.Migrations
{
    public partial class ChangedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_People_PersonId",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_PersonId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "TransportId",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_TransportId",
                table: "People",
                column: "TransportId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Transports_TransportId",
                table: "People",
                column: "TransportId",
                principalTable: "Transports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Transports_TransportId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_TransportId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Transports",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportId",
                table: "Transports",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transports_PersonId",
                table: "Transports",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_People_PersonId",
                table: "Transports",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
