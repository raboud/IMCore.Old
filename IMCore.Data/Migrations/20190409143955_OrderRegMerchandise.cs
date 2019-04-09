using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class OrderRegMerchandise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderRegMerchandiseDetails",
                table: "OrderRegMerchandiseDetails");

            migrationBuilder.RenameTable(
                name: "OrderRegMerchandiseDetails",
                newName: "OrderRegMerchandise");

            migrationBuilder.CreateIndex(
                column: "UOMId",
                table: "OrderRegMerchandise",
                name: "IX_OrderRegMerchandise_UOMId");

            migrationBuilder.CreateIndex(
                column: "StatusId",
                table: "OrderRegMerchandise",
                name: "IX_OrderRegMerchandise_StatusId");

            migrationBuilder.CreateIndex(
                column: "ReviewedById",
                table: "OrderRegMerchandise",
                name: "IX_OrderRegMerchandise_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandiseDetails_OrderId",
                table: "OrderRegMerchandise",
                newName: "IX_OrderRegMerchandise_OrderId");

            migrationBuilder.CreateIndex(
                column: "EntryMethodId",
                table: "OrderRegMerchandise",
                name: "IX_OrderRegMerchandise_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderRegMerchandise",
                table: "OrderRegMerchandise",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderRegMerchandise",
                table: "OrderRegMerchandise");

            migrationBuilder.RenameTable(
                name: "OrderRegMerchandise",
                newName: "OrderRegMerchandiseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandise_UOMId",
                table: "OrderRegMerchandiseDetails",
                newName: "IX_OrderRegMerchandiseDetails_UOMId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandise_StatusId",
                table: "OrderRegMerchandiseDetails",
                newName: "IX_OrderRegMerchandiseDetails_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandise_ReviewedById",
                table: "OrderRegMerchandiseDetails",
                newName: "IX_OrderRegMerchandiseDetails_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandise_OrderId",
                table: "OrderRegMerchandiseDetails",
                newName: "IX_OrderRegMerchandiseDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderRegMerchandise_EntryMethodId",
                table: "OrderRegMerchandiseDetails",
                newName: "IX_OrderRegMerchandiseDetails_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderRegMerchandiseDetails",
                table: "OrderRegMerchandiseDetails",
                column: "Id");
        }
    }
}
