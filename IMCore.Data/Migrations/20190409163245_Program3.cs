using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Program3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Program",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Program",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Program",
                table: "Options",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Program",
                table: "Orders",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Program",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Program",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_MaterialType",
                table: "Options",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_MaterialType",
                table: "Orders",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
