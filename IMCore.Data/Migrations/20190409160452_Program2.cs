using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Program2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "OrdersDeleted",
                newName: "ProgramId");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "Orders",
                newName: "ProgramId");

            migrationBuilder.CreateIndex(
                column: "ProgramId",
                table: "Orders",
                name: "IX_Orders_ProgramId");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "Options",
                newName: "ProgramId");

            migrationBuilder.CreateIndex(
                column: "ProgramId",
                table: "Options",
                name: "IX_Options_ProgramId");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "MaterialTypesMarketMapping",
                newName: "ProgramId");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "BasicLabor",
                newName: "ProgramId");

            migrationBuilder.CreateIndex(
                column: "ProgramId",
                table: "BasicLabor",
                name: "IX_BasicLabor_ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "OrdersDeleted",
                newName: "MaterialTypeId");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "Orders",
                newName: "MaterialTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProgramId",
                table: "Orders",
                newName: "IX_Orders_MaterialTypeId");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "Options",
                newName: "MaterialTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Options_ProgramId",
                table: "Options",
                newName: "IX_Options_MaterialTypeId");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "MaterialTypesMarketMapping",
                newName: "MaterialTypeId");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "BasicLabor",
                newName: "MaterialTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicLabor_ProgramId",
                table: "BasicLabor",
                newName: "IX_BasicLabor_MaterialTypeId");
        }
    }
}
