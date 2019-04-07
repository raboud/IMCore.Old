using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class PrintOnWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderBasicLaborDetails_Jobs",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropIndex(
                name: "IX_Order Options Details_JOB",
                table: "Order Options Details");

			migrationBuilder.DropColumn(
				name: "ExtendedCost",
				table: "OrderBasicLaborDetails");

			migrationBuilder.DropColumn(
				name: "ExtendedCost",
				table: "Order Options Details");

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

			//-----------------------------------------------------------

			migrationBuilder.AddColumn<decimal>(
				name: "ExtendedCost",
				table: "OrderBasicLaborDetails",
				type: "decimal(37, 8)",
				nullable: false,
				computedColumnSql: "(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[InstallQuantity] else (0) end,(0.0)))");

			migrationBuilder.AddColumn<decimal>(
				name: "ExtendedCost",
				table: "Order Options Details",
				type: "decimal(37, 8)",
				nullable: false,
				computedColumnSql: "(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[Quantity] else (0) end,(0.0)))");
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

            migrationBuilder.AlterColumn<decimal>(
                name: "ExtendedCost",
                table: "OrderBasicLaborDetails",
                type: "decimal(37, 8)",
                nullable: false,
                computedColumnSql: "(isnull(case when [PrintOnWO]='1' then [UnitCost]*[InstallQuantity] else (0) end,(0.0)))",
                oldClrType: typeof(decimal),
                oldType: "decimal(37, 8)",
                oldComputedColumnSql: "(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[InstallQuantity] else (0) end,(0.0)))");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExtendedCost",
                table: "Order Options Details",
                type: "decimal(37, 8)",
                nullable: false,
                computedColumnSql: "(isnull(case when [PrintOnWO]='1' then [UnitCost]*[Quantity] else (0) end,(0.0)))",
                oldClrType: typeof(decimal),
                oldType: "decimal(37, 8)",
                oldComputedColumnSql: "(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[Quantity] else (0) end,(0.0)))");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBasicLaborDetails_Jobs",
                table: "OrderBasicLaborDetails",
                columns: new[] { "InstallQuantity", "UnitCost", "UnitPrice", "UnitRetail", "PrintOnInvoice", "PrintOnWO", "ServiceLineNumber", "MaterialStatusID", "EntryMethodID", "Deleted", "Reviewed", "ReviewedByID", "ReviewedDate", "MaterialCost", "ExtendedPrice", "ExtendedCost", "OrderID", "ID", "BasicLaborID" });

            migrationBuilder.CreateIndex(
                name: "IX_Order Options Details_JOB",
                table: "Order Options Details",
                columns: new[] { "OrdeOptionslID", "Quantity", "UnitPrice", "SubContractorID", "UnitCost", "UnitRetail", "SubContractorPaid", "SubContractorPay", "EntryMethodID", "PrintOnInvoice", "PrintOnWO", "Deleted", "Reviewed", "ReviewedByID", "ReviewedDate", "MaterialCost", "ExtendedPrice", "ExtendedCost", "OrderID", "OptionID" });
        }
    }
}
