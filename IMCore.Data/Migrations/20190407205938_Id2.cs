using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Id2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersOrderId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.RenameColumn(
                name: "OrdersOrderId",
                table: "OrderBasicLaborDetails",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLaborDetails_OrdersOrderId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_OrdersId");

            migrationBuilder.AddColumn<int>(
                name: "CrewId",
                table: "InstallationCrewType",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersId",
                table: "OrderBasicLaborDetails",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropColumn(
                name: "CrewId",
                table: "InstallationCrewType");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderBasicLaborDetails",
                newName: "OrdersOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLaborDetails_OrdersId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_OrdersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersOrderId",
                table: "OrderBasicLaborDetails",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
