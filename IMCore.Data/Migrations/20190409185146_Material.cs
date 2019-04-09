using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material Catagory_MatSubCat",
                table: "Material Catagory");

            migrationBuilder.DropForeignKey(
                name: "FK_Material Catagory_UnitOfMeasure",
                table: "Material Catagory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategoryBasicLaborMappings_BasicLabor",
                table: "MaterialCategoryBasicLaborMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategoryBasicLaborMappings_MaterialCategory",
                table: "MaterialCategoryBasicLaborMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterilCategoryItemMappings_MaterialCategory",
                table: "MaterialCategoryItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategoryOptionsMappings_MaterialCategory",
                table: "MaterialCategoryOptionsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategoryOptionsMappings_Options",
                table: "MaterialCategoryOptionsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Material Catagory",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Material Catagory",
                table: "MaterialPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialCategoryOptionsMappings",
                table: "MaterialCategoryOptionsMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialCategoryItemMappings",
                table: "MaterialCategoryItemMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialCategoryBasicLaborMappings",
                table: "MaterialCategoryBasicLaborMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Material Catagory",
                table: "Material Catagory");

            migrationBuilder.RenameTable(
                name: "MaterialCategoryOptionsMappings",
                newName: "MaterialsOptionsMapping");

            migrationBuilder.RenameTable(
                name: "MaterialCategoryItemMappings",
                newName: "MaterialsItemMapping");

            migrationBuilder.RenameTable(
                name: "MaterialCategoryBasicLaborMappings",
                newName: "MaterialBasicLaborMapping");

            migrationBuilder.RenameTable(
                name: "Material Catagory",
                newName: "Material");

            migrationBuilder.RenameColumn(
                name: "MaterialCatId",
                table: "MaterialPrice",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                column: "MaterialiD",
                table: "MaterialPrice",
                name: "IX_MaterialPrice_MaterialId");

            migrationBuilder.RenameColumn(
                name: "MaterialCatId",
                table: "MaterialCost",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                column: "MaterialId",
                table: "MaterialCost",
                name: "IX_MaterialCost_MaterialId");

            migrationBuilder.RenameColumn(
                name: "MaterialCategoryId",
                table: "MaterialsOptionsMapping",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                column: "OptionId",
                table: "MaterialsOptionsMapping",
                name: "IX_MaterialsOptionsMapping_OptionId");

            migrationBuilder.RenameColumn(
                name: "MaterialCategoryId",
                table: "MaterialsItemMapping",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                column: "ItemId",
                table: "MaterialsItemMapping",
                name: "IX_MaterialsItemMapping_ItemId");

            migrationBuilder.RenameColumn(
                name: "MaterialCategoryId",
                table: "MaterialBasicLaborMapping",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                column: "BasicLaborId",
                table: "MaterialBasicLaborMapping",
                name: "IX_MaterialBasicLaborMapping_BasicLaborId");

            migrationBuilder.CreateIndex(
                column: "UnitOfMeasureId",
                table: "Material",
                name: "IX_Material_UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                column: "SubCatId",
                table: "Material",
                name: "IX_Material_SubCatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialsOptionsMapping",
                table: "MaterialsOptionsMapping",
                columns: new[] { "MaterialId", "OptionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialsItemMapping",
                table: "MaterialsItemMapping",
                columns: new[] { "MaterialId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialBasicLaborMapping",
                table: "MaterialBasicLaborMapping",
                columns: new[] { "MaterialId", "BasicLaborId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Material",
                table: "Material",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_MatSubCat",
                table: "Material",
                column: "SubCatId",
                principalTable: "MatSubCat",
                principalColumn: "SubCatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_UnitOfMeasure",
                table: "Material",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasure",
                principalColumn: "UnitOfMeasureId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialBasicLaborMapping_BasicLabor",
                table: "MaterialBasicLaborMapping",
                column: "BasicLaborId",
                principalTable: "BasicLabor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialBasicLaborMapping_Material",
                table: "MaterialBasicLaborMapping",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Material",
                table: "MaterialCost",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Material",
                table: "MaterialPrice",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterilItemMappings_Material",
                table: "MaterialsItemMapping",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialOptionsMappings_Material",
                table: "MaterialsOptionsMapping",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialOptionsMappings_Options",
                table: "MaterialsOptionsMapping",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_MatSubCat",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_UnitOfMeasure",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialBasicLaborMapping_BasicLabor",
                table: "MaterialBasicLaborMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialBasicLaborMapping_Material",
                table: "MaterialBasicLaborMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Material",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Material",
                table: "MaterialPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterilItemMappings_Material",
                table: "MaterialsItemMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialOptionsMappings_Material",
                table: "MaterialsOptionsMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialOptionsMappings_Options",
                table: "MaterialsOptionsMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialsOptionsMapping",
                table: "MaterialsOptionsMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialsItemMapping",
                table: "MaterialsItemMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialBasicLaborMapping",
                table: "MaterialBasicLaborMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Material",
                table: "Material");

            migrationBuilder.RenameTable(
                name: "MaterialsOptionsMapping",
                newName: "MaterialCategoryOptionsMappings");

            migrationBuilder.RenameTable(
                name: "MaterialsItemMapping",
                newName: "MaterialCategoryItemMappings");

            migrationBuilder.RenameTable(
                name: "MaterialBasicLaborMapping",
                newName: "MaterialCategoryBasicLaborMappings");

            migrationBuilder.RenameTable(
                name: "Material",
                newName: "Material Catagory");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialPrice",
                newName: "MaterialCatId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialPrice_MaterialId",
                table: "MaterialPrice",
                newName: "IX_MaterialPrice_MaterialCatId");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialCost",
                newName: "MaterialCatId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialCost_MaterialId",
                table: "MaterialCost",
                newName: "IX_MaterialCost_MaterialCatId");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialCategoryOptionsMappings",
                newName: "MaterialCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialsOptionsMapping_OptionId",
                table: "MaterialCategoryOptionsMappings",
                newName: "IX_MaterialCategoryOptionsMappings_OptionId");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialCategoryItemMappings",
                newName: "MaterialCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialsItemMapping_ItemId",
                table: "MaterialCategoryItemMappings",
                newName: "IX_MaterialCategoryItemMappings_ItemId");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialCategoryBasicLaborMappings",
                newName: "MaterialCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialBasicLaborMapping_BasicLaborId",
                table: "MaterialCategoryBasicLaborMappings",
                newName: "IX_MaterialCategoryBasicLaborMappings_BasicLaborId");

            migrationBuilder.RenameIndex(
                name: "IX_Material_UnitOfMeasureId",
                table: "Material Catagory",
                newName: "IX_Material Catagory_UnitOfMeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_Material_SubCatId",
                table: "Material Catagory",
                newName: "IX_Material Catagory_SubCatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialCategoryOptionsMappings",
                table: "MaterialCategoryOptionsMappings",
                columns: new[] { "MaterialCategoryId", "OptionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialCategoryItemMappings",
                table: "MaterialCategoryItemMappings",
                columns: new[] { "MaterialCategoryId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialCategoryBasicLaborMappings",
                table: "MaterialCategoryBasicLaborMappings",
                columns: new[] { "MaterialCategoryId", "BasicLaborId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Material Catagory",
                table: "Material Catagory",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material Catagory_MatSubCat",
                table: "Material Catagory",
                column: "SubCatId",
                principalTable: "MatSubCat",
                principalColumn: "SubCatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material Catagory_UnitOfMeasure",
                table: "Material Catagory",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasure",
                principalColumn: "UnitOfMeasureId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategoryBasicLaborMappings_BasicLabor",
                table: "MaterialCategoryBasicLaborMappings",
                column: "BasicLaborId",
                principalTable: "BasicLabor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategoryBasicLaborMappings_MaterialCategory",
                table: "MaterialCategoryBasicLaborMappings",
                column: "MaterialCategoryId",
                principalTable: "Material Catagory",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterilCategoryItemMappings_MaterialCategory",
                table: "MaterialCategoryItemMappings",
                column: "MaterialCategoryId",
                principalTable: "Material Catagory",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategoryOptionsMappings_MaterialCategory",
                table: "MaterialCategoryOptionsMappings",
                column: "MaterialCategoryId",
                principalTable: "Material Catagory",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategoryOptionsMappings_Options",
                table: "MaterialCategoryOptionsMappings",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Material Catagory",
                table: "MaterialCost",
                column: "MaterialCatId",
                principalTable: "Material Catagory",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Material Catagory",
                table: "MaterialPrice",
                column: "MaterialCatId",
                principalTable: "Material Catagory",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
