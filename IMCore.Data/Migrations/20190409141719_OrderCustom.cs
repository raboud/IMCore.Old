using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class OrderCustom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			/*

								b.Property<decimal>("ExtendedCost")
									.ValueGeneratedOnAddOrUpdate()
									.HasColumnType("decimal(37, 8)")
									.HasComputedColumnSql("(isnull(case when [NotOnWorkOrder]='0' then [UnitCost]*[Quanity] else (0) end,(0.0)))");

								b.Property<decimal>("ExtendedPrice")
									.ValueGeneratedOnAddOrUpdate()
									.HasColumnType("decimal(37, 8)")
									.HasComputedColumnSql("(isnull(case when [NotOnInvoice]='0' then [UnitPrice]*[Quanity] else (0) end,(0.0)))");

			 */
			migrationBuilder.DropPrimaryKey(
                name: "PK_OrderCustomDetails",
                table: "OrderCustomDetails");

            migrationBuilder.RenameTable(
                name: "OrderCustomDetails",
                newName: "OrderCustom");

			migrationBuilder.DropColumn(
				table: "OrderCustom",
				name: "ExtendedCost");

			migrationBuilder.DropColumn(
				table: "OrderCustom",
				name: "ExtendedPrice");

			migrationBuilder.RenameColumn(
                name: "Quanity",
                table: "OrderCustom",
                newName: "Quantity");

			migrationBuilder.AddColumn<decimal>(
				name: "ExtendedCost",
				table: "OrderCustom",
				type: "decimal(37, 8)",
				nullable: false,
				computedColumnSql: "(isnull(case when [NotOnWorkOrder]='0' then [UnitCost]*[Quantity] else (0) end,(0.0)))");

			migrationBuilder.AddColumn<decimal>(
				name: "ExtendedPrice",
				table: "OrderCustom",
				type: "decimal(37, 8)",
				nullable: false,
				computedColumnSql: "(isnull(case when [NotOnInvoice]='0' then [UnitPrice]*[Quantity] else (0) end,(0.0)))");

			migrationBuilder.CreateIndex(
                column: "UnitOfMeasureId",
                table: "OrderCustom",
                name: "IX_OrderCustom_UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                column: "SubContractorId",
                table: "OrderCustom",
                name: "IX_OrderCustom_SubContractorId");

            migrationBuilder.CreateIndex(
                column: "ReviewedById",
                table: "OrderCustom",
                name: "IX_OrderCustom_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustomDetails_OrderId",
                table: "OrderCustom",
                newName: "IX_OrderCustom_OrderId");

            migrationBuilder.CreateIndex(
                column: "EntryMethodId",
                table: "OrderCustom",
                name: "IX_OrderCustom_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderCustom",
                table: "OrderCustom",
                column: "OrderCustomId")
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderCustom",
                table: "OrderCustom");

            migrationBuilder.RenameTable(
                name: "OrderCustom",
                newName: "OrderCustomDetails");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderCustomDetails",
                newName: "Quanity");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustom_UnitOfMeasureId",
                table: "OrderCustomDetails",
                newName: "IX_OrderCustomDetails_UnitOfMeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustom_SubContractorId",
                table: "OrderCustomDetails",
                newName: "IX_OrderCustomDetails_SubContractorId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustom_ReviewedById",
                table: "OrderCustomDetails",
                newName: "IX_OrderCustomDetails_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustom_OrderId",
                table: "OrderCustomDetails",
                newName: "IX_OrderCustomDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderCustom_EntryMethodId",
                table: "OrderCustomDetails",
                newName: "IX_OrderCustomDetails_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderCustomDetails",
                table: "OrderCustomDetails",
                column: "OrderCustomId")
                .Annotation("SqlServer:Clustered", false);
        }
    }
}
