using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class MyMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TickerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TickerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VendorEvents",
                keyColumns: new[] { "EventId", "VendorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "VendorEvents",
                keyColumns: new[] { "EventId", "VendorId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "urooj.akram@mail.com", "339fd", "Urooj Akram", (byte)1 },
                    { 2, "sanakhalid@mail.com", "4he9ju", "Sana Khalid", (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "ContactInformation", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "532-3333", "Providing all the facilites for sports", "Sports Crew" },
                    { 2, "339-22844", "Photography essentials for the events by professional cameraman", "Photography" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Date", "Description", "Location", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 28, 13, 16, 9, 937, DateTimeKind.Local).AddTicks(8905), "cooking show for beginners", "ISB", 1, "Cooking Show" },
                    { 2, new DateTime(2023, 9, 13, 13, 16, 9, 937, DateTimeKind.Local).AddTicks(8934), "Kids Support Event", "Karachi", 2, "Sports Event" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "EventId", "Rating", "UserId", "VendorId" },
                values: new object[,]
                {
                    { 1, "Good event!", 1, 4, 1, null },
                    { 2, "Awesome event!", 2, 5, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TickerId", "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "VendorEvents",
                columns: new[] { "EventId", "VendorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });
        }
    }
}
