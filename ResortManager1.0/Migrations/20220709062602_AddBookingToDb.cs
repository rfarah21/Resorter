using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resort_Management.Migrations
{
    public partial class AddBookingToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userbookedId = table.Column<int>(type: "int", nullable: false),
                    dateBooked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateForBooking = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.bookingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
