using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWeb.Migrations
{
    public partial class addBookings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weekCommencing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.bookingId);
                    table.ForeignKey(
                        name: "FK_bookings_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_userId",
                table: "bookings",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");
        }
    }
}
