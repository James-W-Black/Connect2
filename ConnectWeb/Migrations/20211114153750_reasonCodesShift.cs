using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectWeb.Migrations
{
    public partial class reasonCodesShift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reasonCodes",
                columns: table => new
                {
                    ReasonCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reasonCodes", x => x.ReasonCodeId);
                });

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    RateTypeId = table.Column<int>(type: "int", nullable: false),
                    ReasonCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.ShiftId);
                    table.ForeignKey(
                        name: "FK_shifts_bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "bookings",
                        principalColumn: "bookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shifts_client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "client",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shifts_rateTypes_RateTypeId",
                        column: x => x.RateTypeId,
                        principalTable: "rateTypes",
                        principalColumn: "RateTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shifts_reasonCodes_ReasonCodeId",
                        column: x => x.ReasonCodeId,
                        principalTable: "reasonCodes",
                        principalColumn: "ReasonCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shifts_BookingId",
                table: "shifts",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_ClientId",
                table: "shifts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_RateTypeId",
                table: "shifts",
                column: "RateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_ReasonCodeId",
                table: "shifts",
                column: "ReasonCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "reasonCodes");
        }
    }
}
