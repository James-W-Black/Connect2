using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWeb.Migrations
{
    public partial class bookingDepartRTPass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "passwords",
                columns: table => new
                {
                    PasswordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passwords", x => x.PasswordId);
                    table.ForeignKey(
                        name: "FK_passwords_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rateTypes",
                columns: table => new
                {
                    RateTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ChareRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rateTypes", x => x.RateTypeId);
                    table.ForeignKey(
                        name: "FK_rateTypes_client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "client",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rateTypes_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_passwords_userId",
                table: "passwords",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_rateTypes_ClientId",
                table: "rateTypes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_rateTypes_DepartmentId",
                table: "rateTypes",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passwords");

            migrationBuilder.DropTable(
                name: "rateTypes");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
