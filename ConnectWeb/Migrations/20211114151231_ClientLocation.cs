using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWeb.Migrations
{
    public partial class ClientLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_clientId",
                table: "users");

            migrationBuilder.CreateIndex(
                name: "IX_users_clientId",
                table: "users",
                column: "clientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_clientId",
                table: "users");

            migrationBuilder.CreateIndex(
                name: "IX_users_clientId",
                table: "users",
                column: "clientId",
                unique: true);
        }
    }
}
