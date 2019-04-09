using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Branch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_Market",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPrice_Market",
                table: "BasicPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPricing_Market",
                table: "BasicPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicRetail_Market",
                table: "BasicRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCosting_Market",
                table: "ItemCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMatCosting_Market",
                table: "ItemMatCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPricing_Market",
                table: "ItemPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Market",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Market",
                table: "MaterialPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialTypesMarketMapping_Market",
                table: "MaterialTypesMarketMapping");

			migrationBuilder.DropForeignKey(
				name: "FK_InstallationCrew_Branch",
				table: "InstallationCrew");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_MaterialTypesMarketMapping_MaterialType",
            //    table: "MaterialTypesMarketMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionCost_Market",
                table: "OptionCost");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPrice_Market",
                table: "OptionPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPricing_Market",
                table: "OptionPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionRetail_Market",
                table: "OptionRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Market",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_SubContractors_Market_MarketId",
                table: "SubContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMarketDivisionAssignments_Division",
                table: "UserMarketDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMarketDivisionAssignments_Market",
                table: "UserMarketDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMarketDivisionAssignments_Employees",
                table: "UserMarketDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Market",
                table: "UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMarketDivisionAssignments",
                table: "UserMarketDivisionAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialTypesMarketMapping",
                table: "MaterialTypesMarketMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Market",
                table: "Market");

            migrationBuilder.RenameTable(
                name: "UserMarketDivisionAssignments",
                newName: "UserBranchDivisionAssignments");

            migrationBuilder.RenameTable(
                name: "MaterialTypesMarketMapping",
                newName: "ProgramBranchMapping");

            migrationBuilder.RenameTable(
                name: "Market",
                newName: "Branch");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "UserPermissions",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
				column: "BranchId",
                table: "UserPermissions",
                name: "IX_UserPermissions_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "SubContractors",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_SubContractors_MarketId",
                table: "SubContractors",
                newName: "IX_SubContractors_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "Stores",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "Stores",
                name: "IX_Stores_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "OptionPricingOld",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "OptionPricingOld",
                name: "IX_OptionPricingOld_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "MaterialPrice",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "MaterialPrice",
                name: "IX_MaterialPrice_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "MaterialCost",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "MaterialCost",
                name: "IX_MaterialCost_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "ItemPricing",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "ItemMatCosting",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "ItemMatCosting",
                name: "IX_ItemMatCosting_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "ItemCosting",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "DiscrepanciesPrice",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "BasicPricingOld",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "BasicPricingOld",
                name: "IX_BasicPricingOld_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "UserBranchDivisionAssignments",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "UserId",
                table: "UserBranchDivisionAssignments",
                name: "IX_UserBranchDivisionAssignments_UserId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "UserBranchDivisionAssignments",
                name: "IX_UserBranchDivisionAssignments_BranchId");

            migrationBuilder.CreateIndex(
                column: "DivisionId",
                table: "UserBranchDivisionAssignments",
                name: "IX_UserBranchDivisionAssignments_DivisionId");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "ProgramBranchMapping",
                newName: "BranchId");

            migrationBuilder.CreateIndex(
                column: "BranchId",
                table: "ProgramBranchMapping",
                name: "IX_ProgramBranchMapping_BranchId");

            migrationBuilder.RenameColumn(
                name: "MarketName",
                table: "Branch",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MarketId",
                table: "Branch",
                newName: "Id");

			migrationBuilder.CreateIndex(
				table: "Branch",
				column: "ManagerId",
                name: "IX_Branch_ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBranchDivisionAssignments",
                table: "UserBranchDivisionAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramBranchMapping",
                table: "ProgramBranchMapping",
                columns: new[] { "ProgramId", "BranchId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_Branch",
                table: "BasicCost",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPrice_Branch",
                table: "BasicPrice",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPricing_Branch",
                table: "BasicPricingOld",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicRetail_Branch",
                table: "BasicRetail",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCosting_Branch",
                table: "ItemCosting",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMatCosting_Branch",
                table: "ItemMatCosting",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPricing_Branch",
                table: "ItemPricing",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Branch",
                table: "MaterialCost",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Branch",
                table: "MaterialPrice",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionCost_Branch",
                table: "OptionCost",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPrice_Branch",
                table: "OptionPrice",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPricing_Branch",
                table: "OptionPricingOld",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionRetail_Branch",
                table: "OptionRetail",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramBranchMapping_Branch",
                table: "ProgramBranchMapping",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramBranchMapping_Program",
                table: "ProgramBranchMapping",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Branch",
                table: "Stores",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractors_Branch_BranchId",
                table: "SubContractors",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBranchDivisionAssignment_Branch",
                table: "UserBranchDivisionAssignments",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBranchDivisionAssignment_Division",
                table: "UserBranchDivisionAssignments",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBranchDivisionAssignment_Employees",
                table: "UserBranchDivisionAssignments",
                column: "UserId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Branch",
                table: "UserPermissions",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_Branch",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPrice_Branch",
                table: "BasicPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPricing_Branch",
                table: "BasicPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicRetail_Branch",
                table: "BasicRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCosting_Branch",
                table: "ItemCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMatCosting_Branch",
                table: "ItemMatCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPricing_Branch",
                table: "ItemPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Branch",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Branch",
                table: "MaterialPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionCost_Branch",
                table: "OptionCost");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPrice_Branch",
                table: "OptionPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPricing_Branch",
                table: "OptionPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionRetail_Branch",
                table: "OptionRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramBranchMapping_Branch",
                table: "ProgramBranchMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramBranchMapping_Program",
                table: "ProgramBranchMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Branch",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_SubContractors_Branch_BranchId",
                table: "SubContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBranchDivisionAssignment_Branch",
                table: "UserBranchDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBranchDivisionAssignment_Division",
                table: "UserBranchDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBranchDivisionAssignment_Employees",
                table: "UserBranchDivisionAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Branch",
                table: "UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBranchDivisionAssignments",
                table: "UserBranchDivisionAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramBranchMapping",
                table: "ProgramBranchMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "UserBranchDivisionAssignments",
                newName: "UserMarketDivisionAssignments");

            migrationBuilder.RenameTable(
                name: "ProgramBranchMapping",
                newName: "MaterialTypesMarketMapping");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Market");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "UserPermissions",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPermissions_BranchId",
                table: "UserPermissions",
                newName: "IX_UserPermissions_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "SubContractors",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_SubContractors_BranchId",
                table: "SubContractors",
                newName: "IX_SubContractors_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Stores",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_BranchId",
                table: "Stores",
                newName: "IX_Stores_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "OptionPricingOld",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_OptionPricingOld_BranchId",
                table: "OptionPricingOld",
                newName: "IX_OptionPricingOld_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "MaterialPrice",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialPrice_BranchId",
                table: "MaterialPrice",
                newName: "IX_MaterialPrice_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "MaterialCost",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialCost_BranchId",
                table: "MaterialCost",
                newName: "IX_MaterialCost_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "ItemPricing",
                newName: "MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "ItemMatCosting",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemMatCosting_BranchId",
                table: "ItemMatCosting",
                newName: "IX_ItemMatCosting_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "ItemCosting",
                newName: "MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "DiscrepanciesPrice",
                newName: "MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "BasicPricingOld",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicPricingOld_BranchId",
                table: "BasicPricingOld",
                newName: "IX_BasicPricingOld_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "UserMarketDivisionAssignments",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBranchDivisionAssignments_UserId",
                table: "UserMarketDivisionAssignments",
                newName: "IX_UserMarketDivisionAssignments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBranchDivisionAssignments_DivisionId",
                table: "UserMarketDivisionAssignments",
                newName: "IX_UserMarketDivisionAssignments_DivisionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBranchDivisionAssignments_BranchId",
                table: "UserMarketDivisionAssignments",
                newName: "IX_UserMarketDivisionAssignments_MarketId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "MaterialTypesMarketMapping",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramBranchMapping_BranchId",
                table: "MaterialTypesMarketMapping",
                newName: "IX_MaterialTypesMarketMapping_MarketId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Market",
                newName: "MarketName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Market",
                newName: "MarketId");

            migrationBuilder.RenameIndex(
                name: "IX_Branch_ManagerId",
                table: "Market",
                newName: "IX_Market_ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMarketDivisionAssignments",
                table: "UserMarketDivisionAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialTypesMarketMapping",
                table: "MaterialTypesMarketMapping",
                columns: new[] { "ProgramId", "MarketId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Market",
                table: "Market",
                column: "MarketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_Market",
                table: "BasicCost",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPrice_Market",
                table: "BasicPrice",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPricing_Market",
                table: "BasicPricingOld",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicRetail_Market",
                table: "BasicRetail",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCosting_Market",
                table: "ItemCosting",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMatCosting_Market",
                table: "ItemMatCosting",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPricing_Market",
                table: "ItemPricing",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Market",
                table: "MaterialCost",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Market",
                table: "MaterialPrice",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTypesMarketMapping_Market",
                table: "MaterialTypesMarketMapping",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialTypesMarketMapping_MaterialType",
                table: "MaterialTypesMarketMapping",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionCost_Market",
                table: "OptionCost",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPrice_Market",
                table: "OptionPrice",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPricing_Market",
                table: "OptionPricingOld",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionRetail_Market",
                table: "OptionRetail",
                column: "BranchId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Market",
                table: "Stores",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractors_Market_MarketId",
                table: "SubContractors",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMarketDivisionAssignments_Division",
                table: "UserMarketDivisionAssignments",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMarketDivisionAssignments_Market",
                table: "UserMarketDivisionAssignments",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMarketDivisionAssignments_Employees",
                table: "UserMarketDivisionAssignments",
                column: "UserId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Market",
                table: "UserPermissions",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
