using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Program : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropForeignKey(
				table: "Options",
				name: "FK_Options_MaterialType");

			migrationBuilder.DropForeignKey(
				name: "FK_MaterialTypesMarketMapping_MaterialType",
				table: "MaterialTypesMarketMapping");

			migrationBuilder.DropForeignKey(
				name: "FK_Orders_MaterialType",
				table: "Orders");

			migrationBuilder.DropForeignKey(
				name: "FK_BasicLabor_MaterialType",
				table: "BasicLabor");

			migrationBuilder.DropForeignKey(
				name: "FK_MaterialCost_Program",
				table: "MaterialCost");

			migrationBuilder.DropForeignKey(
				name: "FK_MaterialPrice_MaterialType",
				table: "MaterialPrice");

			migrationBuilder.DropForeignKey(
				name: "FK_ProgramReport_Program",
				table: "ProgramReport");

			migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialType",
                table: "MaterialType");

            migrationBuilder.RenameTable(
                name: "MaterialType",
                newName: "Program");

            migrationBuilder.CreateIndex(
                column: "StoreTypeId",
                table: "Program",
                name: "IX_Program_StoreTypeId");

            migrationBuilder.CreateIndex(
                column: "JobTypeId",
                table: "Program",
                name: "IX_Program_JobTypeId");

            migrationBuilder.CreateIndex(
                column: "DivisionId",
                table: "Program",
                name: "IX_Program_DivisionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Program",
                table: "Program",
                column: "Id")
                .Annotation("SqlServer:Clustered", false);

			migrationBuilder.AddForeignKey(
				name: "FK_Options_Program",
				table: "Options",
				column: "MaterialTypeId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Orders_Program",
				table: "Orders",
				column: "MaterialTypeId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_MaterialTypesMarketMapping_Program",
				table: "MaterialTypesMarketMapping",
				column: "MaterialTypeId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			//FK_BasicLabor_MaterialType
			migrationBuilder.AddForeignKey(
				name: "FK_BasicLabor_Program",
				table: "BasicLabor",
				column: "MaterialTypeId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			//FK_MaterialCost_Program
			migrationBuilder.AddForeignKey(
				name: "FK_MaterialCost_Program",
				table: "MaterialCost",
				column: "ProgramId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			//FK_MaterialPrice_MaterialType
			migrationBuilder.AddForeignKey(
				name: "FK_MaterialPrice_Program",
				table: "MaterialPrice",
				column: "ProgramId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			//FK_ProgramReport_Program
			migrationBuilder.AddForeignKey(
				name: "FK_ProgramReport_Program",
				table: "ProgramReport",
				column: "ProgramId",
				principalTable: "Program",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Program",
                table: "Program");

            migrationBuilder.RenameTable(
                name: "Program",
                newName: "MaterialType");

            migrationBuilder.RenameIndex(
                name: "IX_Program_StoreTypeId",
                table: "MaterialType",
                newName: "IX_MaterialType_StoreTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Program_JobTypeId",
                table: "MaterialType",
                newName: "IX_MaterialType_JobTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Program_DivisionId",
                table: "MaterialType",
                newName: "IX_MaterialType_DivisionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialType",
                table: "MaterialType",
                column: "Id")
                .Annotation("SqlServer:Clustered", false);
        }
    }
}
