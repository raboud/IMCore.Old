using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class PrintOnWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrintOnWO",
                table: "OrderBasicLaborDetails",
                newName: "PrintOnWorkOrder");

            migrationBuilder.RenameColumn(
                name: "PrintOnWO",
                table: "Order Options Details",
                newName: "PrintOnWorkOrder");

            migrationBuilder.RenameColumn(
                name: "PrintOnWO",
                table: "BasicLabor",
                newName: "PrintOnWorkOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrintOnWorkOrder",
                table: "OrderBasicLaborDetails",
                newName: "PrintOnWO");

            migrationBuilder.RenameColumn(
                name: "PrintOnWorkOrder",
                table: "Order Options Details",
                newName: "PrintOnWO");

            migrationBuilder.RenameColumn(
                name: "PrintOnWorkOrder",
                table: "BasicLabor",
                newName: "PrintOnWO");
        }
    }
}
