using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class sixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentID",
                table: "Orders",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
