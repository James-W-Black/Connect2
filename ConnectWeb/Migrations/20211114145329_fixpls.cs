using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWeb.Migrations
{
    public partial class fixpls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    clientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "userTypes",
                columns: table => new
                {
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTypes", x => x.userTypeId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: false),
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_client_clientId",
                        column: x => x.clientId,
                        principalTable: "client",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_userTypes_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "userTypes",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_clientId",
                table: "users",
                column: "clientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_userTypeId",
                table: "users",
                column: "userTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "userTypes");
        }
    }
}
