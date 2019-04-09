using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class OrderBasicLabor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DeleteData(
				table: "OrderBasicLaborDetails",
				keyColumn: "OrderId",
				keyValue: "65599");

			migrationBuilder.DeleteData(
				table: "OrderBasicLaborDetails",
				keyColumn: "Id",
				keyValue: "65599");

			migrationBuilder.DropForeignKey(
				name: "FK_OrderBasicLaborDetails_Orders_OrdersId",
				table: "OrderBasicLaborDetails");

			migrationBuilder.DropIndex(
				name: "IX_OrderBasicLaborDetails_OrdersId",
				table: "OrderBasicLaborDetails");

			migrationBuilder.DropColumn(
				table: "OrderBasicLaborDetails",
				name: "OrdersId");

			migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderBasicLaborDetails",
                table: "OrderBasicLaborDetails");

            migrationBuilder.RenameTable(
                name: "OrderBasicLaborDetails",
                newName: "OrderBasicLabor");

            migrationBuilder.CreateIndex(
                column: "ReviewedById",
                table: "OrderBasicLabor",
                name: "IX_OrderBasicLabor_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLaborDetails_OrderId",
                table: "OrderBasicLabor",
                newName: "IX_OrderBasicLabor_OrderId");

            migrationBuilder.CreateIndex(
                column: "MaterialStatusId",
                table: "OrderBasicLabor",
                name: "IX_OrderBasicLabor_MaterialStatusId");

            migrationBuilder.CreateIndex(
                column: "EntryMethodId",
                table: "OrderBasicLabor",
                name: "IX_OrderBasicLabor_EntryMethodId");

            migrationBuilder.CreateIndex(
                column: "BasicLaborId",
                table: "OrderBasicLabor",
                name: "IX_OrderBasicLabor_BasicLaborId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderBasicLabor",
                table: "OrderBasicLabor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLabor_BasicLabor_BasicLaborId",
                table: "OrderBasicLabor",
                column: "BasicLaborId",
                principalTable: "BasicLabor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLabor_Orders_OrderId",
                table: "OrderBasicLabor",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLabor_BasicLabor_BasicLaborId",
                table: "OrderBasicLabor");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLabor_Orders_OrderId",
                table: "OrderBasicLabor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderBasicLabor",
                table: "OrderBasicLabor");

            migrationBuilder.RenameTable(
                name: "OrderBasicLabor",
                newName: "OrderBasicLaborDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLabor_ReviewedById",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLabor_OrderId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLabor_MaterialStatusId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_MaterialStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLabor_EntryMethodId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_EntryMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBasicLabor_BasicLaborId",
                table: "OrderBasicLaborDetails",
                newName: "IX_OrderBasicLaborDetails_BasicLaborId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderBasicLaborDetails",
                table: "OrderBasicLaborDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborId",
                table: "OrderBasicLaborDetails",
                column: "BasicLaborId",
                principalTable: "BasicLabor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrderId",
                table: "OrderBasicLaborDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
