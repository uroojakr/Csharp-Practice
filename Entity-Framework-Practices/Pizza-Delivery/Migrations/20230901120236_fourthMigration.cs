using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class fourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Orders",
                newName: "PaymentID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                newName: "IX_Orders_PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentID",
                table: "Orders",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "PaymentID",
                table: "Orders",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentID",
                table: "Orders",
                newName: "IX_Orders_PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
