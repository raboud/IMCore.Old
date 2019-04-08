using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class CleanUp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Discrepancies_DiscrepancySubTypeId",
                table: "Discrepancies",
                column: "DiscrepancySubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discrepancies_DiscrepancySubType_DiscrepancySubTypeId",
                table: "Discrepancies",
                column: "DiscrepancySubTypeId",
                principalTable: "DiscrepancySubType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discrepancies_DiscrepancySubType_DiscrepancySubTypeId",
                table: "Discrepancies");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrderId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Discrepancies_DiscrepancySubTypeId",
                table: "Discrepancies");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "OrderBasicLaborDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderBasicLaborDetails_OrdersId",
                table: "OrderBasicLaborDetails",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersId",
                table: "OrderBasicLaborDetails",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
