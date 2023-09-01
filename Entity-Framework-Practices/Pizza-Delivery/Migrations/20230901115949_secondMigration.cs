using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_Delivery.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveriesId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveriesId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveriesId",
                table: "Orders",
                column: "DeliveriesId",
                principalTable: "Deliveries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveriesId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveriesId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveriesId",
                table: "Orders",
                column: "DeliveriesId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
