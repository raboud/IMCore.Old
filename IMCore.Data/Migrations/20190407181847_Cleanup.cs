using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_Labor",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_Stores",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPrice_Stores",
                table: "BasicPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPricing_Stores",
                table: "BasicPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicRetail_Stores",
                table: "BasicRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCosting_Stores",
                table: "ItemCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMatCosting_Stores",
                table: "ItemMatCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPricing_Stores",
                table: "ItemPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Stores",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Stores",
                table: "MaterialPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionCost_Stores",
                table: "OptionCost");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPrice_Stores",
                table: "OptionPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPricing_Stores",
                table: "OptionPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionRetail_Stores",
                table: "OptionRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders",
                table: "OrderBasicLaborDetails");

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderId",
                table: "OrderBasicLaborDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasicLaborId",
                table: "BasicCost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderBasicLaborDetails_OrdersOrderId",
                table: "OrderBasicLaborDetails",
                column: "OrdersOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicCost_BasicLaborId",
                table: "BasicCost",
                column: "BasicLaborId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_BasicLabor_BasicLaborId",
                table: "BasicCost",
                column: "BasicLaborId",
                principalTable: "BasicLabor",
                principalColumn: "BasicLaborID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_Stores_StoreID",
                table: "BasicCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPrice_Stores_StoreID",
                table: "BasicPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPricingOld_Stores_StoreID",
                table: "BasicPricingOld",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicRetail_Stores_StoreID",
                table: "BasicRetail",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCosting_Stores_StoreID",
                table: "ItemCosting",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMatCosting_Stores_StoreID",
                table: "ItemMatCosting",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPricing_Stores_StoreID",
                table: "ItemPricing",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Stores_StoreID",
                table: "MaterialCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Stores_StoreID",
                table: "MaterialPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionCost_Stores_StoreID",
                table: "OptionCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPrice_Stores_StoreID",
                table: "OptionPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPricingOld_Stores_StoreID",
                table: "OptionPricingOld",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionRetail_Stores_StoreID",
                table: "OptionRetail",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborID",
                table: "OrderBasicLaborDetails",
                column: "BasicLaborID",
                principalTable: "BasicLabor",
                principalColumn: "BasicLaborID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersOrderId",
                table: "OrderBasicLaborDetails",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_BasicLabor_BasicLaborId",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicCost_Stores_StoreID",
                table: "BasicCost");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPrice_Stores_StoreID",
                table: "BasicPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicPricingOld_Stores_StoreID",
                table: "BasicPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicRetail_Stores_StoreID",
                table: "BasicRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCosting_Stores_StoreID",
                table: "ItemCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMatCosting_Stores_StoreID",
                table: "ItemMatCosting");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPricing_Stores_StoreID",
                table: "ItemPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCost_Stores_StoreID",
                table: "MaterialCost");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialPrice_Stores_StoreID",
                table: "MaterialPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionCost_Stores_StoreID",
                table: "OptionCost");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPrice_Stores_StoreID",
                table: "OptionPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionPricingOld_Stores_StoreID",
                table: "OptionPricingOld");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionRetail_Stores_StoreID",
                table: "OptionRetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborID",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders_OrdersOrderId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderBasicLaborDetails_OrdersOrderId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropIndex(
                name: "IX_BasicCost_BasicLaborId",
                table: "BasicCost");

            migrationBuilder.DropColumn(
                name: "OrdersOrderId",
                table: "OrderBasicLaborDetails");

            migrationBuilder.DropColumn(
                name: "BasicLaborId",
                table: "BasicCost");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_Labor",
                table: "BasicCost",
                column: "LaborID",
                principalTable: "BasicLabor",
                principalColumn: "BasicLaborID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicCost_Stores",
                table: "BasicCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPrice_Stores",
                table: "BasicPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicPricing_Stores",
                table: "BasicPricingOld",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicRetail_Stores",
                table: "BasicRetail",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCosting_Stores",
                table: "ItemCosting",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMatCosting_Stores",
                table: "ItemMatCosting",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPricing_Stores",
                table: "ItemPricing",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCost_Stores",
                table: "MaterialCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialPrice_Stores",
                table: "MaterialPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionCost_Stores",
                table: "OptionCost",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPrice_Stores",
                table: "OptionPrice",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionPricing_Stores",
                table: "OptionPricingOld",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionRetail_Stores",
                table: "OptionRetail",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_BasicLabor",
                table: "OrderBasicLaborDetails",
                column: "BasicLaborID",
                principalTable: "BasicLabor",
                principalColumn: "BasicLaborID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasicLaborDetails_Orders",
                table: "OrderBasicLaborDetails",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
