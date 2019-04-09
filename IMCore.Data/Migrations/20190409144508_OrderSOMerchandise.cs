using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class OrderSOMerchandise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropForeignKey(
				name: "FK_SODocument_Order",
				table: "SODocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderSOMerchandiseDetails",
                table: "OrderSOMerchandiseDetails");

            migrationBuilder.RenameTable(
                name: "OrderSOMerchandiseDetails",
                newName: "OrderSOMerchandise");

            migrationBuilder.CreateIndex(
                column: "UOMId",
                table: "OrderSOMerchandise",
                name: "IX_OrderSOMerchandise_UOMId");

            migrationBuilder.CreateIndex(
                column: "ReviewedById",
                table: "OrderSOMerchandise",
                name: "IX_OrderSOMerchandise_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandiseDetails_OrderId",
                table: "OrderSOMerchandise",
                newName: "IX_OrderSOMerchandise_OrderId");

            migrationBuilder.CreateIndex(
                column: "MaterialStatusId",
                table: "OrderSOMerchandise",
                name: "IX_OrderSOMerchandise_MaterialStatusId");

            migrationBuilder.CreateIndex(
                column: "EntryMethodId",
                table: "OrderSOMerchandise",
                name: "IX_OrderSOMerchandise_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderSOMerchandise",
                table: "OrderSOMerchandise",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderSOMerchandise",
                table: "OrderSOMerchandise");

            migrationBuilder.RenameTable(
                name: "OrderSOMerchandise",
                newName: "OrderSOMerchandiseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandise_UOMId",
                table: "OrderSOMerchandiseDetails",
                newName: "IX_OrderSOMerchandiseDetails_UOMId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandise_ReviewedById",
                table: "OrderSOMerchandiseDetails",
                newName: "IX_OrderSOMerchandiseDetails_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandise_OrderId",
                table: "OrderSOMerchandiseDetails",
                newName: "IX_OrderSOMerchandiseDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandise_MaterialStatusId",
                table: "OrderSOMerchandiseDetails",
                newName: "IX_OrderSOMerchandiseDetails_MaterialStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderSOMerchandise_EntryMethodId",
                table: "OrderSOMerchandiseDetails",
                newName: "IX_OrderSOMerchandiseDetails_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderSOMerchandiseDetails",
                table: "OrderSOMerchandiseDetails",
                column: "Id");
        }
    }
}
