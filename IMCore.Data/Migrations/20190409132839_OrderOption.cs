using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class OrderOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Order Options Details",
                table: "Order Options Details");

            migrationBuilder.RenameTable(
                name: "Order Options Details",
                newName: "OrderOption");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_OrderId",
				table: "OrderOption",
				newName: "IX_OrderOption_OrderId");

			migrationBuilder.CreateIndex(
                table: "OrderOption",
                name: "IX_OrderOption_ReviewedById",
				column: "ReviewedById");

            migrationBuilder.CreateIndex(
                column: "OptionId",
                table: "OrderOption",
                name: "IX_OrderOption_OptionId");

            migrationBuilder.CreateIndex(
                column: "EntryMethodId",
                table: "OrderOption",
                name: "IX_OrderOption_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderOption",
                table: "OrderOption",
                column: "OrdeOptionslId")
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderOption",
                table: "OrderOption");

            migrationBuilder.RenameTable(
                name: "OrderOption",
                newName: "Order Options Details");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOption_ReviewedById",
                table: "Order Options Details",
                newName: "IX_Order Options Details_ReviewedById");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOption_OrderId",
                table: "Order Options Details",
                newName: "IX_Order Options Details_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOption_OptionId",
                table: "Order Options Details",
                newName: "IX_Order Options Details_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOption_EntryMethodId",
                table: "Order Options Details",
                newName: "IX_Order Options Details_EntryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order Options Details",
                table: "Order Options Details",
                column: "OrdeOptionslId")
                .Annotation("SqlServer:Clustered", false);
        }
    }
}
