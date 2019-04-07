using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Data.SqlClient;

namespace IMCore.Data.Migrations
{
	public partial class Id : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_ActivityList_Employees_ClosedByID",
				table: "ActivityList");

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

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "XMLSources",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "WorkOrderID",
				table: "WorkOrderEmails",
				newName: "WorkOrderId");

			migrationBuilder.RenameColumn(
				name: "DocumentID",
				table: "WorkOrderDocument",
				newName: "DocumentId");

			migrationBuilder.RenameColumn(
				name: "WorkOrderID",
				table: "WorkOrderDocument",
				newName: "WorkOrderId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "WorkOrder",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "JobID",
				table: "WorkOrder",
				newName: "JobId");

			migrationBuilder.RenameColumn(
				name: "CrewID",
				table: "WorkOrder",
				newName: "CrewId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "WorkOrder",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VOCID",
				table: "VOC",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VersionID",
				table: "Version",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VendorID",
				table: "VendorNumbers",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UserTaskTypeID",
				table: "UserTaskTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UserTaskTypeID",
				table: "UserTasks",
				newName: "UserTaskTypeId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "UserTasks",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "JobID",
				table: "UserTasks",
				newName: "JobId");

			migrationBuilder.RenameColumn(
				name: "CompletedByID",
				table: "UserTasks",
				newName: "CompletedById");

			migrationBuilder.RenameColumn(
				name: "AssignedToID",
				table: "UserTasks",
				newName: "AssignedToId");

			migrationBuilder.RenameColumn(
				name: "AddedByID",
				table: "UserTasks",
				newName: "AddedById");

			migrationBuilder.RenameColumn(
				name: "UserTaskID",
				table: "UserTasks",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UserID",
				table: "UserPermissions",
				newName: "UserId");

			migrationBuilder.RenameColumn(
				name: "PermissionID",
				table: "UserPermissions",
				newName: "PermissionId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "UserPermissions",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "UserPermissions",
				newName: "DivisionId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "UserPermissions",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UserID",
				table: "UserMarketDivisionAssignments",
				newName: "UserId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "UserMarketDivisionAssignments",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "UserMarketDivisionAssignments",
				newName: "DivisionId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "UserMarketDivisionAssignments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "UnitOfMeasure",
				newName: "UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "SubDivisionID",
				table: "SubContractorsDivisionAssignments",
				newName: "SubDivisionId");

			migrationBuilder.RenameColumn(
				name: "SubContractorID",
				table: "SubContractorsDivisionAssignments",
				newName: "SubContractorId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "SubContractorsDivisionAssignments",
				newName: "DivisionId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SubContractorsDivisionAssignments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StateID",
				table: "SubContractors",
				newName: "StateId");

			migrationBuilder.RenameColumn(
				name: "QBSubContractorID",
				table: "SubContractors",
				newName: "QBSubContractorId");

			migrationBuilder.RenameColumn(
				name: "SubContractorID",
				table: "SubContractors",
				newName: "SubContractorId");

			migrationBuilder.RenameColumn(
				name: "StoreTypeID",
				table: "StoreType",
				newName: "StoreTypeId");

			migrationBuilder.RenameColumn(
				name: "XMLSourceID",
				table: "Stores",
				newName: "XMLSourceId");

			migrationBuilder.RenameColumn(
				name: "StoreTypeID",
				table: "Stores",
				newName: "StoreTypeId");

			migrationBuilder.RenameColumn(
				name: "AccountRepID",
				table: "Stores",
				newName: "AccountRepId");

			migrationBuilder.RenameColumn(
				name: "AccountCoorID",
				table: "Stores",
				newName: "AccountCoorId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "Stores",
				newName: "Id");

			migrationBuilder.CreateIndex(
				table: "Stores",
				name: "IX_Stores_AccountCoorId",
				column: "AccountCoorId");

			migrationBuilder.RenameColumn(
				name: "TitleID",
				table: "StoreContacts",
				newName: "TitleId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "StoreContacts",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "DepartmentID",
				table: "StoreContacts",
				newName: "DepartmentId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "StoreContacts",
				newName: "Id");

			migrationBuilder.CreateIndex(
				table: "StoreContacts",
				name: "IX_StoreContacts_StoreId",
				column: "StoreId");

			migrationBuilder.CreateIndex(
				table: "StoreContacts",
				name: "IX_StoreContacts_DepartmentId",
				column: "DepartmentId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "States",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "SPNImportedPOs",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "POStatusID",
				table: "SPNImportedPOs",
				newName: "POStatusId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SPNImportedPOs",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SPNActions",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ActionID",
				table: "SPNActionQueue",
				newName: "ActionId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SPNActionQueue",
				newName: "Id");

			migrationBuilder.CreateIndex(
				table: "SPNActionQueue",
				name: "IX_SPNActionQueue_ActionId",
				column: "ActionId");

			migrationBuilder.RenameColumn(
				name: "DocTypeID",
				table: "SOSISentDocuments",
				newName: "DocTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SOSISentDocuments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "SOSIScheduleWillCallDocuments",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SOSIScheduleWillCallDocuments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "DocumentTypeID",
				table: "SOSIOutgoingDocuments",
				newName: "DocumentTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SOSIOutgoingDocuments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "SOSIDocumentTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "SOID",
				table: "SODocument",
				newName: "SOId");

			migrationBuilder.RenameColumn(
				name: "DocumentID",
				table: "SODocument",
				newName: "Id");

			migrationBuilder.CreateIndex(
				table: "SODocument",
				name: "IX_SODocument_Id",
				column: "Id");

			migrationBuilder.RenameColumn(
				name: "UserID",
				table: "Settings",
				newName: "UserId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Settings",
				newName: "Id");

			migrationBuilder.RenameIndex(
				name: "IX_Settings_UserID",
				table: "Settings",
				newName: "IX_Settings_UserId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ScheduleChangeReasonCodes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ReportTypeID",
				table: "ProgramReport",
				newName: "ReportTypeId");

			migrationBuilder.RenameColumn(
				name: "ProgramID",
				table: "ProgramReport",
				newName: "ProgramId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ProgramReport",
				newName: "Id");

			migrationBuilder.CreateIndex(
				table: "ProgramReport",
				name: "IX_ProgramReport_ReportTypeId",
				column: "ReportTypeId");

			migrationBuilder.CreateIndex(
					table: "ProgramReport",
					name: "IX_ProgramReport_ProgramId",
					column: "ProgramId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "PrintedPOData",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "PrintedPOData",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "POStatusValues",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "POPhotos",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "EnteredByUserID",
				table: "POPhotos",
				newName: "EnteredByUserId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "POPhotos",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_POPhotos_OrderID",
			//    table: "POPhotos",
			//    newName: "IX_POPhotos_OrderId");

			migrationBuilder.RenameColumn(
				name: "SpokeWithID",
				table: "PONotes",
				newName: "SpokeWithId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "PONotes",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "NoteTypeID",
				table: "PONotes",
				newName: "NoteTypeId");

			migrationBuilder.RenameColumn(
				name: "EnteredByUserID",
				table: "PONotes",
				newName: "EnteredByUserId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "PONotes",
				newName: "Id");

			migrationBuilder.RenameIndex(
				name: "IX_PONotes_OrderID",
				table: "PONotes",
				newName: "IX_PONotes_OrderId");

			migrationBuilder.RenameIndex(
				name: "IX_PONotes_NoteTypeID",
				table: "PONotes",
				newName: "IX_PONotes_NoteTypeId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_PONotes_EnteredByUserID",
			//    table: "PONotes",
			//    newName: "IX_PONotes_EnteredByUserId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "PhoneNumberTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "PermissionType",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "PermissionTypeID",
				table: "Permissions",
				newName: "PermissionTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Permissions",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Permissions_PermissionTypeID",
			//	table: "Permissions",
			//	newName: "IX_Permissions_PermissionTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "PayrollMessages",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "XMLStatusID",
				table: "OrderSOMerchandiseDetails",
				newName: "XMLStatusId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "OrderSOMerchandiseDetails",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OriginalOrderID",
				table: "OrderSOMerchandiseDetails",
				newName: "OriginalOrderId");

			migrationBuilder.RenameColumn(
				name: "OriginalID",
				table: "OrderSOMerchandiseDetails",
				newName: "OriginalId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderSOMerchandiseDetails",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "MaterialStatusID",
				table: "OrderSOMerchandiseDetails",
				newName: "MaterialStatusId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "OrderSOMerchandiseDetails",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "BasicLaborID",
				table: "OrderSOMerchandiseDetails",
				newName: "BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OrderSOMerchandiseDetails",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderSOMerchandiseDetails_ReviewedByID",
			//    table: "OrderSOMerchandiseDetails",
			//    newName: "IX_OrderSOMerchandiseDetails_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_OrderSOMerchandiseDetails_OrderID",
				table: "OrderSOMerchandiseDetails",
				newName: "IX_OrderSOMerchandiseDetails_OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderSOMerchandiseDetails_MaterialStatusID",
			//    table: "OrderSOMerchandiseDetails",
			//    newName: "IX_OrderSOMerchandiseDetails_MaterialStatusId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderSOMerchandiseDetails_EntryMethodID",
			//    table: "OrderSOMerchandiseDetails",
			//    newName: "IX_OrderSOMerchandiseDetails_EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "OrdersDeleted",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrdersDeleted",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "OrdersDeleted",
				newName: "MaterialTypeId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "OrdersDeleted",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "CustomerID",
				table: "OrdersDeleted",
				newName: "CustomerId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OrdersDeleted",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VendorID",
				table: "Orders",
				newName: "VendorId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "Orders",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "SalesPersonID",
				table: "Orders",
				newName: "SalesPersonId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "Orders",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "PrimaryOrderID",
				table: "Orders",
				newName: "PrimaryOrderId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "Orders",
				newName: "MaterialTypeId");

			migrationBuilder.RenameColumn(
				name: "JobStatusID",
				table: "Orders",
				newName: "JobStatusId");

			migrationBuilder.RenameColumn(
				name: "JobID",
				table: "Orders",
				newName: "JobId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "Orders",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "EnteredByID",
				table: "Orders",
				newName: "EnteredById");

			migrationBuilder.RenameColumn(
				name: "CustomerID",
				table: "Orders",
				newName: "CustomerId");

			migrationBuilder.RenameColumn(
				name: "CreatedByID",
				table: "Orders",
				newName: "CreatedById");

			migrationBuilder.RenameColumn(
				name: "CorrelationID",
				table: "Orders",
				newName: "CorrelationId");

			migrationBuilder.RenameColumn(
				name: "AssignedToID",
				table: "Orders",
				newName: "AssignedToId");

			migrationBuilder.RenameColumn(
				name: "AddressID",
				table: "Orders",
				newName: "AddressId");

			migrationBuilder.DropColumn(
				name: "NUMBER",
				table: "Orders");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "Orders",
				newName: "Id");

			migrationBuilder.AddColumn<string>(
				name: "NUMBER",
				table: "Orders",
				maxLength: 10,
				computedColumnSql: "(case when [Estimate]='1' OR len([PurchaseOrderNumber])<>(8) OR [PurchaseOrderNumber] IS NULL then str([Id]) else [PurchaseOrderNumber] end)");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_StoreID",
				table: "Orders",
				newName: "IX_Orders_StoreId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_SalesPersonID",
			//    table: "Orders",
			//    newName: "IX_Orders_SalesPersonId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_ReviewedByID",
			//    table: "Orders",
			//    newName: "IX_Orders_ReviewedById");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_PrimaryOrderID",
			//    table: "Orders",
			//    newName: "IX_Orders_PrimaryOrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_MaterialTypeID",
			//    table: "Orders",
			//    newName: "IX_Orders_MaterialTypeId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_JobStatusID",
			//    table: "Orders",
			//    newName: "IX_Orders_JobStatusId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_EntryMethodID",
			//    table: "Orders",
			//    newName: "IX_Orders_EntryMethodId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_EnteredByID",
			//    table: "Orders",
			//    newName: "IX_Orders_EnteredById");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_CustomerID",
				table: "Orders",
				newName: "IX_Orders_CustomerId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_AssignedToID",
			//    table: "Orders",
			//    newName: "IX_Orders_AssignedToId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Orders_AddressID",
			//    table: "Orders",
			//    newName: "IX_Orders_AddressId");

			migrationBuilder.RenameColumn(
				name: "XMLStatusID",
				table: "OrderRegMerchandiseDetails",
				newName: "XMLStatusId");

			migrationBuilder.RenameColumn(
				name: "StatusID",
				table: "OrderRegMerchandiseDetails",
				newName: "StatusId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "OrderRegMerchandiseDetails",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OriginalOrderID",
				table: "OrderRegMerchandiseDetails",
				newName: "OriginalOrderId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderRegMerchandiseDetails",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "OrderRegMerchandiseDetails",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OrderRegMerchandiseDetails",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderRegMerchandiseDetails_StatusID",
			//    table: "OrderRegMerchandiseDetails",
			//    newName: "IX_OrderRegMerchandiseDetails_StatusId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderRegMerchandiseDetails_ReviewedByID",
			//    table: "OrderRegMerchandiseDetails",
			//    newName: "IX_OrderRegMerchandiseDetails_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_OrderRegMerchandiseDetails_OrderID",
				table: "OrderRegMerchandiseDetails",
				newName: "IX_OrderRegMerchandiseDetails_OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderRegMerchandiseDetails_EntryMethodID",
			//    table: "OrderRegMerchandiseDetails",
			//    newName: "IX_OrderRegMerchandiseDetails_EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "DocumentID",
				table: "OrderDocument",
				newName: "DocumentId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderDocument",
				newName: "OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderDocument_DocumentID",
			//    table: "OrderDocument",
			//    newName: "IX_OrderDocument_DocumentId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderDiagrams",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OrderDiagrams",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderDiagrams_OrderID",
			//    table: "OrderDiagrams",
			//    newName: "IX_OrderDiagrams_OrderId");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "OrderCustomDetails",
				newName: "UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "SubContractorID",
				table: "OrderCustomDetails",
				newName: "SubContractorId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "OrderCustomDetails",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderCustomDetails",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "OrderCustomDetails",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "OrderCustomID",
				table: "OrderCustomDetails",
				newName: "OrderCustomId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderCustomDetails_UnitOfMeasureID",
			//    table: "OrderCustomDetails",
			//    newName: "IX_OrderCustomDetails_UnitOfMeasureId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderCustomDetails_SubContractorID",
			//    table: "OrderCustomDetails",
			//    newName: "IX_OrderCustomDetails_SubContractorId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderCustomDetails_ReviewedByID",
			//    table: "OrderCustomDetails",
			//    newName: "IX_OrderCustomDetails_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_OrderID",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderCustomDetails_EntryMethodID",
			//    table: "OrderCustomDetails",
			//    newName: "IX_OrderCustomDetails_EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "OrderBasicLaborDetails",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "OrderBasicLaborDetails",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "MaterialStatusID",
				table: "OrderBasicLaborDetails",
				newName: "MaterialStatusId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "OrderBasicLaborDetails",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "BasicLaborID",
				table: "OrderBasicLaborDetails",
				newName: "BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OrderBasicLaborDetails",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderBasicLaborDetails_ReviewedByID",
			//    table: "OrderBasicLaborDetails",
			//    newName: "IX_OrderBasicLaborDetails_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_OrderID",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderBasicLaborDetails_MaterialStatusID",
			//    table: "OrderBasicLaborDetails",
			//    newName: "IX_OrderBasicLaborDetails_MaterialStatusId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderBasicLaborDetails_EntryMethodID",
			//    table: "OrderBasicLaborDetails",
			//    newName: "IX_OrderBasicLaborDetails_EntryMethodId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_OrderBasicLaborDetails_BasicLaborID",
			//    table: "OrderBasicLaborDetails",
			//    newName: "IX_OrderBasicLaborDetails_BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "SubContractorID",
				table: "Order Options Details",
				newName: "SubContractorId");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "Order Options Details",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "Order Options Details",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "OptionID",
				table: "Order Options Details",
				newName: "OptionId");

			migrationBuilder.RenameColumn(
				name: "EntryMethodID",
				table: "Order Options Details",
				newName: "EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "OrdeOptionslID",
				table: "Order Options Details",
				newName: "OrdeOptionslId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Order Options Details_ReviewedByID",
			//    table: "Order Options Details",
			//    newName: "IX_Order Options Details_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_OrderID",
				table: "Order Options Details",
				newName: "IX_Order Options Details_OrderId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Order Options Details_OptionID",
			//    table: "Order Options Details",
			//    newName: "IX_Order Options Details_OptionId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Order Options Details_EntryMethodID",
			//    table: "Order Options Details",
			//    newName: "IX_Order Options Details_EntryMethodId");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "Options",
				newName: "UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "Options",
				newName: "MaterialTypeId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "Options",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "OptionID",
				table: "Options",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Options_UnitOfMeasureID",
			//    table: "Options",
			//    newName: "IX_Options_UnitOfMeasureId");

			//migrationBuilder.RenameIndex(
			//    name: "IX_Options_MaterialTypeID",
			//    table: "Options",
			//    newName: "IX_Options_MaterialTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Options_ItemID",
			//	table: "Options",
			//	newName: "IX_Options_ItemId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "OptionRetail",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "OptionRetail",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "OptionRetail",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OptionRetail",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "OptionPricingOld",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "OptionID",
				table: "OptionPricingOld",
				newName: "OptionId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "OptionPricingOld",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OptionPricingOld",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_OptionPricingOld_StoreID",
			//	table: "OptionPricingOld",
			//	newName: "IX_OptionPricingOld_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_OptionPricingOld_OptionID",
			//	table: "OptionPricingOld",
			//	newName: "IX_OptionPricingOld_OptionId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_OptionPricingOld_MarketID",
			//	table: "OptionPricingOld",
			//	newName: "IX_OptionPricingOld_MarketId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "OptionPrice",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "OptionPrice",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "OptionPrice",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OptionPrice",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "OptionCost",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "OptionCost",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "OptionCost",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "OptionCost",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "NoteTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "MeasureCompOrderData",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MeasureCompOrderData",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MeasureCompOrderData_OrderID",
			//	table: "MeasureCompOrderData",
			//	newName: "IX_MeasureCompOrderData_OrderId");

			migrationBuilder.RenameColumn(
				name: "CalcID",
				table: "MeasureCompLineItemData",
				newName: "CalcId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MeasureCompLineItemData",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MeasureCompLineItemData_CalcID",
			//	table: "MeasureCompLineItemData",
			//	newName: "IX_MeasureCompLineItemData_CalcId");

			migrationBuilder.RenameColumn(
				name: "CustomerID",
				table: "MeasureCompCustData",
				newName: "CustomerId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MeasureCompCustData",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MeasureCompCustData_CustomerID",
			//	table: "MeasureCompCustData",
			//	newName: "IX_MeasureCompCustData_CustomerId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "MeasureCompCalcData",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MeasureCompCalcData",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MeasureCompCalcData_OrderID",
			//	table: "MeasureCompCalcData",
			//	newName: "IX_MeasureCompCalcData_OrderId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "MaterialTypesMarketMapping",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "MaterialTypesMarketMapping",
				newName: "MaterialTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialTypesMarketMapping_MarketID",
			//	table: "MaterialTypesMarketMapping",
			//	newName: "IX_MaterialTypesMarketMapping_MarketId");

			migrationBuilder.RenameColumn(
				name: "StoreTypeID",
				table: "MaterialType",
				newName: "StoreTypeId");

			migrationBuilder.RenameColumn(
				name: "JobTypeID",
				table: "MaterialType",
				newName: "JobTypeId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "MaterialType",
				newName: "DivisionId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "MaterialType",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialType_StoreTypeID",
			//	table: "MaterialType",
			//	newName: "IX_MaterialType_StoreTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialType_JobTypeID",
			//	table: "MaterialType",
			//	newName: "IX_MaterialType_JobTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialType_DivisionID",
			//	table: "MaterialType",
			//	newName: "IX_MaterialType_DivisionId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "MaterialPrice",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "ProgramID",
				table: "MaterialPrice",
				newName: "ProgramId");

			migrationBuilder.RenameColumn(
				name: "MaterialCatID",
				table: "MaterialPrice",
				newName: "MaterialCatId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "MaterialPrice",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MaterialPrice",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialPrice_StoreID",
			//	table: "MaterialPrice",
			//	newName: "IX_MaterialPrice_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialPrice_ProgramID",
			//	table: "MaterialPrice",
			//	newName: "IX_MaterialPrice_ProgramId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialPrice_MaterialCatID",
			//	table: "MaterialPrice",
			//	newName: "IX_MaterialPrice_MaterialCatId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialPrice_MarketID",
			//	table: "MaterialPrice",
			//	newName: "IX_MaterialPrice_MarketId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "MaterialCost",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "ProgramID",
				table: "MaterialCost",
				newName: "ProgramId");

			migrationBuilder.RenameColumn(
				name: "MaterialCatID",
				table: "MaterialCost",
				newName: "MaterialCatId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "MaterialCost",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "MaterialCost",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCost_StoreID",
			//	table: "MaterialCost",
			//	newName: "IX_MaterialCost_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCost_ProgramID",
			//	table: "MaterialCost",
			//	newName: "IX_MaterialCost_ProgramId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCost_MaterialCatID",
			//	table: "MaterialCost",
			//	newName: "IX_MaterialCost_MaterialCatId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCost_MarketID",
			//	table: "MaterialCost",
			//	newName: "IX_MaterialCost_MarketId");

			migrationBuilder.RenameColumn(
				name: "OptionID",
				table: "MaterialCategoryOptionsMappings",
				newName: "OptionId");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryID",
				table: "MaterialCategoryOptionsMappings",
				newName: "MaterialCategoryId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCategoryOptionsMappings_OptionID",
			//	table: "MaterialCategoryOptionsMappings",
			//	newName: "IX_MaterialCategoryOptionsMappings_OptionId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "MaterialCategoryItemMappings",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryID",
				table: "MaterialCategoryItemMappings",
				newName: "MaterialCategoryId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCategoryItemMappings_ItemID",
			//	table: "MaterialCategoryItemMappings",
			//	newName: "IX_MaterialCategoryItemMappings_ItemId");

			migrationBuilder.RenameColumn(
				name: "BasicLaborID",
				table: "MaterialCategoryBasicLaborMappings",
				newName: "BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryID",
				table: "MaterialCategoryBasicLaborMappings",
				newName: "MaterialCategoryId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_MaterialCategoryBasicLaborMappings_BasicLaborID",
			//	table: "MaterialCategoryBasicLaborMappings",
			//	newName: "IX_MaterialCategoryBasicLaborMappings_BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "MatStatusID",
				table: "Material Status",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "Material Catagory",
				newName: "UnitOfMeasureId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Material Catagory_UnitOfMeasureID",
			//	table: "Material Catagory",
			//	newName: "IX_Material Catagory_UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "ManagerID",
				table: "Market",
				newName: "ManagerId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Market_ManagerID",
			//	table: "Market",
			//	newName: "IX_Market_ManagerId");

			migrationBuilder.RenameColumn(
				name: "LaborTypeID",
				table: "LaborType",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "JobTypeID",
				table: "JobTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "JobStatusID",
				table: "JobStatus",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "PrimaryOrderID",
				table: "Jobs",
				newName: "PrimaryOrderId");

			migrationBuilder.RenameColumn(
				name: "JobStatusID",
				table: "Jobs",
				newName: "JobStatusId");

			migrationBuilder.RenameColumn(
				name: "CreatedByID",
				table: "Jobs",
				newName: "CreatedById");

			migrationBuilder.RenameColumn(
				name: "AssignedToID",
				table: "Jobs",
				newName: "AssignedToId");

			migrationBuilder.RenameColumn(
				name: "JobID",
				table: "Jobs",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Jobs_PrimaryOrderID",
			//	table: "Jobs",
			//	newName: "IX_Jobs_PrimaryOrderId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Jobs_JobStatusID",
			//	table: "Jobs",
			//	newName: "IX_Jobs_JobStatusId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Jobs_CreatedByID",
			//	table: "Jobs",
			//	newName: "IX_Jobs_CreatedById");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Jobs_AssignedToID",
			//	table: "Jobs",
			//	newName: "IX_Jobs_AssignedToId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "ItemPricing",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "ItemPricing",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "ItemPricing",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ItemPricing",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "ItemMatCosting",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "ItemMatCosting",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "ItemMatCosting",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "ItemMatCostingID",
				table: "ItemMatCosting",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ItemMatCosting_StoreID",
			//	table: "ItemMatCosting",
			//	newName: "IX_ItemMatCosting_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ItemMatCosting_MarketID",
			//	table: "ItemMatCosting",
			//	newName: "IX_ItemMatCosting_MarketId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ItemMatCosting_ItemID",
			//	table: "ItemMatCosting",
			//	newName: "IX_ItemMatCosting_ItemId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "ItemCosting",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "ItemCosting",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "ItemCosting",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "ItemCosting",
				newName: "DivisionId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ItemCosting",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ItemCosting_DivisionID",
			//	table: "ItemCosting",
			//	newName: "IX_ItemCosting_DivisionId");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "Item",
				newName: "UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "Item",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Item_UnitOfMeasureID",
			//	table: "Item",
			//	newName: "IX_Item_UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "IssueTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "IssueStatus",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StatusID",
				table: "Issues",
				newName: "StatusId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Issues",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "InstallerStatus",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "JobTypeID",
				table: "InstallCapacity",
				newName: "JobTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "InstallCapacity",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "MaxSizeID",
				table: "InstallationCrewType",
				newName: "MaxSizeId");

			migrationBuilder.RenameColumn(
				name: "JobTypeID",
				table: "InstallationCrewType",
				newName: "JobTypeId");

			migrationBuilder.RenameColumn(
				name: "CrewID",
				table: "InstallationCrewType",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_InstallationCrewType_JobTypeID",
			//	table: "InstallationCrewType",
			//	newName: "IX_InstallationCrewType_JobTypeId");

			migrationBuilder.RenameColumn(
				name: "OwnerID",
				table: "InstallationCrew",
				newName: "OwnerId");

			migrationBuilder.RenameColumn(
				name: "LeadID",
				table: "InstallationCrew",
				newName: "LeadId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "InstallationCrew",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "InstallationCrew",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_InstallationCrew_OwnerID",
			//	table: "InstallationCrew",
			//	newName: "IX_InstallationCrew_OwnerId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_InstallationCrew_LeadID",
			//	table: "InstallationCrew",
			//	newName: "IX_InstallationCrew_LeadId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_InstallationCrew_BranchID",
			//	table: "InstallationCrew",
			//	newName: "IX_InstallationCrew_BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "EntryMethod",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Employees",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "EmailTemplates",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "EmailImages",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Document",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "DivisionGroups",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VendorID",
				table: "Division",
				newName: "VendorId");

			migrationBuilder.RenameColumn(
				name: "DivisionGroupID",
				table: "Division",
				newName: "DivisionGroupId");

			migrationBuilder.RenameColumn(
				name: "DivisionID",
				table: "Division",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Division_DivisionGroupID",
			//	table: "Division",
			//	newName: "IX_Division_DivisionGroupId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "DiscrepancyType",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "DiscrepancySubType",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "DiscrepanciesPrice",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "DiscrepanciesPrice",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "DiscrepancyTypeID",
				table: "DiscrepanciesPrice",
				newName: "DiscrepancyTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "DiscrepanciesPrice",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ReviewedByID",
				table: "Discrepancies",
				newName: "ReviewedById");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "Discrepancies",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "DiscrepancyTypeID",
				table: "Discrepancies",
				newName: "DiscrepancyTypeId");

			migrationBuilder.RenameColumn(
				name: "DiscrepancySubTypeID",
				table: "Discrepancies",
				newName: "DiscrepancySubTypeId");

			migrationBuilder.RenameColumn(
				name: "DetailID",
				table: "Discrepancies",
				newName: "DetailId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Discrepancies",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Discrepancies_ReviewedByID",
			//	table: "Discrepancies",
			//	newName: "IX_Discrepancies_ReviewedById");

			migrationBuilder.RenameIndex(
				name: "IX_Discrepancies_OrderID",
				table: "Discrepancies",
				newName: "IX_Discrepancies_OrderId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Discrepancies_DiscrepancyTypeID",
			//	table: "Discrepancies",
			//	newName: "IX_Discrepancies_DiscrepancyTypeId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "DepartmentsStoresAssignments",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "DepartmentID",
				table: "DepartmentsStoresAssignments",
				newName: "DepartmentId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "DepartmentsStoresAssignments",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_DepartmentsStoresAssignments_StoreID",
			//	table: "DepartmentsStoresAssignments",
			//	newName: "IX_DepartmentsStoresAssignments_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_DepartmentsStoresAssignments_DepartmentID",
			//	table: "DepartmentsStoresAssignments",
			//	newName: "IX_DepartmentsStoresAssignments_DepartmentId");

			migrationBuilder.RenameColumn(
				name: "ContactTitlesID",
				table: "DepartmentsContactTitles",
				newName: "ContactTitlesId");

			migrationBuilder.RenameColumn(
				name: "DepartmentsID",
				table: "DepartmentsContactTitles",
				newName: "DepartmentsId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_DepartmentsContactTitles_ContactTitlesID",
			//	table: "DepartmentsContactTitles",
			//	newName: "IX_DepartmentsContactTitles_ContactTitlesId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Departments",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "QBCustomerID",
				table: "Customers",
				newName: "QBCustomerId");

			migrationBuilder.RenameColumn(
				name: "AddressID",
				table: "Customers",
				newName: "AddressId");

			migrationBuilder.RenameColumn(
				name: "CustomerID",
				table: "Customers",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_Customers_AddressID",
			//	table: "Customers",
			//	newName: "IX_Customers_AddressId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ContactTitles",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "CompanyInfo",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ReportTypeID",
				table: "ClientTypeReports",
				newName: "ReportTypeId");

			migrationBuilder.RenameColumn(
				name: "ClientTypeID",
				table: "ClientTypeReports",
				newName: "ClientTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ClientTypeReports_ReportTypeID",
			//	table: "ClientTypeReports",
			//	newName: "IX_ClientTypeReports_ReportTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ClientTypeReports_ClientTypeID",
			//	table: "ClientTypeReports",
			//	newName: "IX_ClientTypeReports_ClientTypeId");

			migrationBuilder.RenameColumn(
				name: "VendorID",
				table: "Checks",
				newName: "VendorId");

			migrationBuilder.RenameColumn(
				name: "CheckID",
				table: "Checks",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "CheckDetail",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "CheckID",
				table: "CheckDetail",
				newName: "CheckId");

			migrationBuilder.RenameColumn(
				name: "CheckDetailID",
				table: "CheckDetail",
				newName: "Id");

			migrationBuilder.RenameIndex(
				name: "IX_CheckDetail_OrderID",
				table: "CheckDetail",
				newName: "IX_CheckDetail_OrderId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_CheckDetail_CheckID",
			//	table: "CheckDetail",
			//	newName: "IX_CheckDetail_CheckId");

			migrationBuilder.RenameColumn(
				name: "CheckID",
				table: "CheckCBDetail",
				newName: "CheckId");

			migrationBuilder.RenameColumn(
				name: "ChargeBackID",
				table: "CheckCBDetail",
				newName: "ChargeBackId");

			migrationBuilder.RenameColumn(
				name: "CheckCBDetailID",
				table: "CheckCBDetail",
				newName: "CheckCBDetailId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_CheckCBDetail_CheckID",
			//	table: "CheckCBDetail",
			//	newName: "IX_CheckCBDetail_CheckId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_CheckCBDetail_ChargeBackID",
			//	table: "CheckCBDetail",
			//	newName: "IX_CheckCBDetail_ChargeBackId");

			migrationBuilder.RenameColumn(
				name: "SubcontractorID",
				table: "ChargeBacks",
				newName: "SubcontractorId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "ChargeBacks",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ChargeBackID",
				table: "ChargeBacks",
				newName: "Id");

			migrationBuilder.RenameIndex(
				name: "IX_ChargeBacks_OrderID",
				table: "ChargeBacks",
				newName: "IX_ChargeBacks_OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "CapacityPoolTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "VendorID",
				table: "CapacityPools",
				newName: "VendorId");

			migrationBuilder.RenameColumn(
				name: "PoolTypeID",
				table: "CapacityPools",
				newName: "PoolTypeId");

			migrationBuilder.RenameColumn(
				name: "HDPoolID",
				table: "CapacityPools",
				newName: "HDPoolId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "CapacityPools",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "PoolID",
				table: "Capacity",
				newName: "PoolId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Capacity",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ClassificationID",
				table: "BillDetails",
				newName: "ClassificationId");

			migrationBuilder.RenameColumn(
				name: "ChargeBackID",
				table: "BillDetails",
				newName: "ChargeBackId");

			migrationBuilder.RenameColumn(
				name: "BackChargeOwnerID",
				table: "BillDetails",
				newName: "BackChargeOwnerId");

			migrationBuilder.RenameColumn(
				name: "BillDetailsId",
				table: "BillDetails",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BillDetails_ChargeBackID",
			//	table: "BillDetails",
			//	newName: "IX_BillDetails_ChargeBackId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BillDetails_BackChargeOwnerID",
			//	table: "BillDetails",
			//	newName: "IX_BillDetails_BackChargeOwnerId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "BasicRetail",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "BasicRetail",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "BasicRetail",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "BasicRetail",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "BasicPricingOld",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "MarketID",
				table: "BasicPricingOld",
				newName: "MarketId");

			migrationBuilder.RenameColumn(
				name: "BasicLaborID",
				table: "BasicPricingOld",
				newName: "BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "BasicPricingID",
				table: "BasicPricingOld",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicPricingOld_StoreID",
			//	table: "BasicPricingOld",
			//	newName: "IX_BasicPricingOld_StoreId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicPricingOld_MarketID",
			//	table: "BasicPricingOld",
			//	newName: "IX_BasicPricingOld_MarketId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicPricingOld_BasicLaborID",
			//	table: "BasicPricingOld",
			//	newName: "IX_BasicPricingOld_BasicLaborId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "BasicPrice",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "BasicPrice",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "BasicPrice",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "BasicPrice",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureID",
				table: "BasicLabor",
				newName: "UnitOfMeasureId");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeID",
				table: "BasicLabor",
				newName: "MaterialTypeId");

			migrationBuilder.RenameColumn(
				name: "ItemID",
				table: "BasicLabor",
				newName: "ItemId");

			migrationBuilder.RenameColumn(
				name: "BasicLaborID",
				table: "BasicLabor",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicLabor_UnitOfMeasureID",
			//	table: "BasicLabor",
			//	newName: "IX_BasicLabor_UnitOfMeasureId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicLabor_MaterialTypeID",
			//	table: "BasicLabor",
			//	newName: "IX_BasicLabor_MaterialTypeId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_BasicLabor_ItemID",
			//	table: "BasicLabor",
			//	newName: "IX_BasicLabor_ItemId");

			migrationBuilder.RenameColumn(
				name: "StoreID",
				table: "BasicCost",
				newName: "StoreId");

			migrationBuilder.RenameColumn(
				name: "LaborID",
				table: "BasicCost",
				newName: "LaborId");

			migrationBuilder.RenameColumn(
				name: "BranchID",
				table: "BasicCost",
				newName: "BranchId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "BasicCost",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "EmployeeID",
				table: "Admins",
				newName: "EmployeeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "Address",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ActivityTypes",
				newName: "Id");

			migrationBuilder.RenameColumn(
				name: "PONoteID",
				table: "ActivityPONoteMapping",
				newName: "PONoteId");

			migrationBuilder.RenameColumn(
				name: "ActivityID",
				table: "ActivityPONoteMapping",
				newName: "ActivityId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityPONoteMapping_PONoteID",
			//	table: "ActivityPONoteMapping",
			//	newName: "IX_ActivityPONoteMapping_PONoteId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "ActivityList",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "CreatedByID",
				table: "ActivityList",
				newName: "CreatedById");

			migrationBuilder.RenameColumn(
				name: "ClosedByID",
				table: "ActivityList",
				newName: "ClosedById");

			migrationBuilder.RenameColumn(
				name: "ActivityTypeID",
				table: "ActivityList",
				newName: "ActivityTypeId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ActivityList",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityList_OrderID",
			//	table: "ActivityList",
			//	newName: "IX_ActivityList_OrderId");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityList_CreatedByID",
			//	table: "ActivityList",
			//	newName: "IX_ActivityList_CreatedById");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityList_ClosedByID",
			//	table: "ActivityList",
			//	newName: "IX_ActivityList_ClosedById");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityList_ActivityTypeID",
			//	table: "ActivityList",
			//	newName: "IX_ActivityList_ActivityTypeId");

			migrationBuilder.RenameColumn(
				name: "ActivityID",
				table: "ActivityData",
				newName: "ActivityId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ActivityData",
				newName: "Id");

			//migrationBuilder.RenameIndex(
			//	name: "IX_ActivityData_ActivityID",
			//	table: "ActivityData",
			//	newName: "IX_ActivityData_ActivityId");

			migrationBuilder.RenameColumn(
				name: "OrderID",
				table: "ActionReport",
				newName: "OrderId");

			migrationBuilder.RenameColumn(
				name: "ID",
				table: "ActionReport",
				newName: "Id");

			migrationBuilder.RenameIndex(
				name: "IX_ActionReport_OrderID",
				table: "ActionReport",
				newName: "IX_ActionReport_OrderId");

			migrationBuilder.AddForeignKey(
				name: "FK_ActivityList_Employees_ClosedById",
				table: "ActivityList",
				column: "ClosedById",
				principalTable: "Employees",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BasicCost_Stores_StoreId",
				table: "BasicCost",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BasicPrice_Stores_StoreId",
				table: "BasicPrice",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BasicPricingOld_Stores_StoreId",
				table: "BasicPricingOld",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BasicRetail_Stores_StoreId",
				table: "BasicRetail",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_ItemCosting_Stores_StoreId",
				table: "ItemCosting",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_ItemMatCosting_Stores_StoreId",
				table: "ItemMatCosting",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_ItemPricing_Stores_StoreId",
				table: "ItemPricing",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_MaterialCost_Stores_StoreId",
				table: "MaterialCost",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_MaterialPrice_Stores_StoreId",
				table: "MaterialPrice",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_OptionCost_Stores_StoreId",
				table: "OptionCost",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_OptionPrice_Stores_StoreId",
				table: "OptionPrice",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_OptionPricingOld_Stores_StoreId",
				table: "OptionPricingOld",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_OptionRetail_Stores_StoreId",
				table: "OptionRetail",
				column: "StoreId",
				principalTable: "Stores",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborId",
				table: "OrderBasicLaborDetails",
				column: "BasicLaborId",
				principalTable: "BasicLabor",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_ActivityList_Employees_ClosedById",
				table: "ActivityList");

			migrationBuilder.DropForeignKey(
				name: "FK_BasicCost_Stores_StoreId",
				table: "BasicCost");

			migrationBuilder.DropForeignKey(
				name: "FK_BasicPrice_Stores_StoreId",
				table: "BasicPrice");

			migrationBuilder.DropForeignKey(
				name: "FK_BasicPricingOld_Stores_StoreId",
				table: "BasicPricingOld");

			migrationBuilder.DropForeignKey(
				name: "FK_BasicRetail_Stores_StoreId",
				table: "BasicRetail");

			migrationBuilder.DropForeignKey(
				name: "FK_ItemCosting_Stores_StoreId",
				table: "ItemCosting");

			migrationBuilder.DropForeignKey(
				name: "FK_ItemMatCosting_Stores_StoreId",
				table: "ItemMatCosting");

			migrationBuilder.DropForeignKey(
				name: "FK_ItemPricing_Stores_StoreId",
				table: "ItemPricing");

			migrationBuilder.DropForeignKey(
				name: "FK_MaterialCost_Stores_StoreId",
				table: "MaterialCost");

			migrationBuilder.DropForeignKey(
				name: "FK_MaterialPrice_Stores_StoreId",
				table: "MaterialPrice");

			migrationBuilder.DropForeignKey(
				name: "FK_OptionCost_Stores_StoreId",
				table: "OptionCost");

			migrationBuilder.DropForeignKey(
				name: "FK_OptionPrice_Stores_StoreId",
				table: "OptionPrice");

			migrationBuilder.DropForeignKey(
				name: "FK_OptionPricingOld_Stores_StoreId",
				table: "OptionPricingOld");

			migrationBuilder.DropForeignKey(
				name: "FK_OptionRetail_Stores_StoreId",
				table: "OptionRetail");

			migrationBuilder.DropForeignKey(
				name: "FK_OrderBasicLaborDetails_BasicLabor_BasicLaborId",
				table: "OrderBasicLaborDetails");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "XMLSources",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "WorkOrderId",
				table: "WorkOrderEmails",
				newName: "WorkOrderID");

			migrationBuilder.RenameColumn(
				name: "DocumentId",
				table: "WorkOrderDocument",
				newName: "DocumentID");

			migrationBuilder.RenameColumn(
				name: "WorkOrderId",
				table: "WorkOrderDocument",
				newName: "WorkOrderID");

			migrationBuilder.RenameIndex(
				name: "IX_WorkOrderDocument_DocumentId",
				table: "WorkOrderDocument",
				newName: "IX_WorkOrderDocument_DocumentID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "WorkOrder",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "JobId",
				table: "WorkOrder",
				newName: "JobID");

			migrationBuilder.RenameColumn(
				name: "CrewId",
				table: "WorkOrder",
				newName: "CrewID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "WorkOrder",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_WorkOrder_OrderId",
				table: "WorkOrder",
				newName: "IX_WorkOrder_OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "VOC",
				newName: "VOCID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Version",
				newName: "VersionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "VendorNumbers",
				newName: "VendorID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "UserTaskTypes",
				newName: "UserTaskTypeID");

			migrationBuilder.RenameColumn(
				name: "UserTaskTypeId",
				table: "UserTasks",
				newName: "UserTaskTypeID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "UserTasks",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "JobId",
				table: "UserTasks",
				newName: "JobID");

			migrationBuilder.RenameColumn(
				name: "CompletedById",
				table: "UserTasks",
				newName: "CompletedByID");

			migrationBuilder.RenameColumn(
				name: "AssignedToId",
				table: "UserTasks",
				newName: "AssignedToID");

			migrationBuilder.RenameColumn(
				name: "AddedById",
				table: "UserTasks",
				newName: "AddedByID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "UserTasks",
				newName: "UserTaskID");

			migrationBuilder.RenameIndex(
				name: "IX_UserTasks_UserTaskTypeId",
				table: "UserTasks",
				newName: "IX_UserTasks_UserTaskTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_UserTasks_OrderId",
				table: "UserTasks",
				newName: "IX_UserTasks_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_UserTasks_CompletedById",
				table: "UserTasks",
				newName: "IX_UserTasks_CompletedByID");

			migrationBuilder.RenameIndex(
				name: "IX_UserTasks_AssignedToId",
				table: "UserTasks",
				newName: "IX_UserTasks_AssignedToID");

			migrationBuilder.RenameIndex(
				name: "IX_UserTasks_AddedById",
				table: "UserTasks",
				newName: "IX_UserTasks_AddedByID");

			migrationBuilder.RenameColumn(
				name: "UserId",
				table: "UserPermissions",
				newName: "UserID");

			migrationBuilder.RenameColumn(
				name: "PermissionId",
				table: "UserPermissions",
				newName: "PermissionID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "UserPermissions",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "DivisionId",
				table: "UserPermissions",
				newName: "DivisionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "UserPermissions",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_UserPermissions_UserId",
				table: "UserPermissions",
				newName: "IX_UserPermissions_UserID");

			migrationBuilder.RenameIndex(
				name: "IX_UserPermissions_PermissionId",
				table: "UserPermissions",
				newName: "IX_UserPermissions_PermissionID");

			migrationBuilder.RenameIndex(
				name: "IX_UserPermissions_MarketId",
				table: "UserPermissions",
				newName: "IX_UserPermissions_MarketID");

			migrationBuilder.RenameIndex(
				name: "IX_UserPermissions_DivisionId",
				table: "UserPermissions",
				newName: "IX_UserPermissions_DivisionID");

			migrationBuilder.RenameColumn(
				name: "UserId",
				table: "UserMarketDivisionAssignments",
				newName: "UserID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "UserMarketDivisionAssignments",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "DivisionId",
				table: "UserMarketDivisionAssignments",
				newName: "DivisionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "UserMarketDivisionAssignments",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_UserMarketDivisionAssignments_UserId",
				table: "UserMarketDivisionAssignments",
				newName: "IX_UserMarketDivisionAssignments_UserID");

			migrationBuilder.RenameIndex(
				name: "IX_UserMarketDivisionAssignments_MarketId",
				table: "UserMarketDivisionAssignments",
				newName: "IX_UserMarketDivisionAssignments_MarketID");

			migrationBuilder.RenameIndex(
				name: "IX_UserMarketDivisionAssignments_DivisionId",
				table: "UserMarketDivisionAssignments",
				newName: "IX_UserMarketDivisionAssignments_DivisionID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "UnitOfMeasure",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "SubDivisionId",
				table: "SubContractorsDivisionAssignments",
				newName: "SubDivisionID");

			migrationBuilder.RenameColumn(
				name: "SubContractorId",
				table: "SubContractorsDivisionAssignments",
				newName: "SubContractorID");

			migrationBuilder.RenameColumn(
				name: "DivisionId",
				table: "SubContractorsDivisionAssignments",
				newName: "DivisionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SubContractorsDivisionAssignments",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StateId",
				table: "SubContractors",
				newName: "StateID");

			migrationBuilder.RenameColumn(
				name: "QBSubContractorId",
				table: "SubContractors",
				newName: "QBSubContractorID");

			migrationBuilder.RenameColumn(
				name: "SubContractorId",
				table: "SubContractors",
				newName: "SubContractorID");

			migrationBuilder.RenameColumn(
				name: "StoreTypeId",
				table: "StoreType",
				newName: "StoreTypeID");

			migrationBuilder.RenameColumn(
				name: "XMLSourceId",
				table: "Stores",
				newName: "XMLSourceID");

			migrationBuilder.RenameColumn(
				name: "StoreTypeId",
				table: "Stores",
				newName: "StoreTypeID");

			migrationBuilder.RenameColumn(
				name: "AccountRepId",
				table: "Stores",
				newName: "AccountRepID");

			migrationBuilder.RenameColumn(
				name: "AccountCoorId",
				table: "Stores",
				newName: "AccountCoorID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Stores",
				newName: "StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_Stores_StoreTypeId",
				table: "Stores",
				newName: "IX_Stores_StoreTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_Stores_AccountRepId",
				table: "Stores",
				newName: "IX_Stores_AccountRepID");

			migrationBuilder.RenameIndex(
				name: "IX_Stores_AccountCoorId",
				table: "Stores",
				newName: "IX_Stores_AccountCoorID");

			migrationBuilder.RenameColumn(
				name: "TitleId",
				table: "StoreContacts",
				newName: "TitleID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "StoreContacts",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "DepartmentId",
				table: "StoreContacts",
				newName: "DepartmentID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "StoreContacts",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_StoreContacts_StoreId",
				table: "StoreContacts",
				newName: "IX_StoreContacts_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_StoreContacts_DepartmentId",
				table: "StoreContacts",
				newName: "IX_StoreContacts_DepartmentID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "States",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "SPNImportedPOs",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "POStatusId",
				table: "SPNImportedPOs",
				newName: "POStatusID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SPNImportedPOs",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SPNActions",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "ActionId",
				table: "SPNActionQueue",
				newName: "ActionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SPNActionQueue",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_SPNActionQueue_ActionId",
				table: "SPNActionQueue",
				newName: "IX_SPNActionQueue_ActionID");

			migrationBuilder.RenameColumn(
				name: "DocTypeId",
				table: "SOSISentDocuments",
				newName: "DocTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SOSISentDocuments",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "SOSIScheduleWillCallDocuments",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SOSIScheduleWillCallDocuments",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "DocumentTypeId",
				table: "SOSIOutgoingDocuments",
				newName: "DocumentTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SOSIOutgoingDocuments",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SOSIDocumentTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "SOId",
				table: "SODocument",
				newName: "SOID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "SODocument",
				newName: "DocumentID");

			migrationBuilder.RenameIndex(
				name: "IX_SODocument_Id",
				table: "SODocument",
				newName: "IX_SODocument_DocumentID");

			migrationBuilder.RenameColumn(
				name: "UserId",
				table: "Settings",
				newName: "UserID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Settings",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_Settings_UserId",
				table: "Settings",
				newName: "IX_Settings_UserID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ScheduleChangeReasonCodes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "ReportTypeId",
				table: "ProgramReport",
				newName: "ReportTypeID");

			migrationBuilder.RenameColumn(
				name: "ProgramId",
				table: "ProgramReport",
				newName: "ProgramID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ProgramReport",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_ProgramReport_ReportTypeId",
				table: "ProgramReport",
				newName: "IX_ProgramReport_ReportTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_ProgramReport_ProgramId",
				table: "ProgramReport",
				newName: "IX_ProgramReport_ProgramID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "PrintedPOData",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "PrintedPOData",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "POStatusValues",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "POPhotos",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "EnteredByUserId",
				table: "POPhotos",
				newName: "EnteredByUserID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "POPhotos",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_POPhotos_OrderId",
				table: "POPhotos",
				newName: "IX_POPhotos_OrderID");

			migrationBuilder.RenameColumn(
				name: "SpokeWithId",
				table: "PONotes",
				newName: "SpokeWithID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "PONotes",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "NoteTypeId",
				table: "PONotes",
				newName: "NoteTypeID");

			migrationBuilder.RenameColumn(
				name: "EnteredByUserId",
				table: "PONotes",
				newName: "EnteredByUserID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "PONotes",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_PONotes_OrderId",
				table: "PONotes",
				newName: "IX_PONotes_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_PONotes_NoteTypeId",
				table: "PONotes",
				newName: "IX_PONotes_NoteTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_PONotes_EnteredByUserId",
				table: "PONotes",
				newName: "IX_PONotes_EnteredByUserID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "PhoneNumberTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "PermissionType",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "PermissionTypeId",
				table: "Permissions",
				newName: "PermissionTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Permissions",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_Permissions_PermissionTypeId",
				table: "Permissions",
				newName: "IX_Permissions_PermissionTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "PayrollMessages",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "XMLStatusId",
				table: "OrderSOMerchandiseDetails",
				newName: "XMLStatusID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "OrderSOMerchandiseDetails",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OriginalOrderId",
				table: "OrderSOMerchandiseDetails",
				newName: "OriginalOrderID");

			migrationBuilder.RenameColumn(
				name: "OriginalId",
				table: "OrderSOMerchandiseDetails",
				newName: "OriginalID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderSOMerchandiseDetails",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "MaterialStatusId",
				table: "OrderSOMerchandiseDetails",
				newName: "MaterialStatusID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "OrderSOMerchandiseDetails",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "BasicLaborId",
				table: "OrderSOMerchandiseDetails",
				newName: "BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OrderSOMerchandiseDetails",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderSOMerchandiseDetails_ReviewedById",
				table: "OrderSOMerchandiseDetails",
				newName: "IX_OrderSOMerchandiseDetails_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderSOMerchandiseDetails_OrderId",
				table: "OrderSOMerchandiseDetails",
				newName: "IX_OrderSOMerchandiseDetails_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderSOMerchandiseDetails_MaterialStatusId",
				table: "OrderSOMerchandiseDetails",
				newName: "IX_OrderSOMerchandiseDetails_MaterialStatusID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderSOMerchandiseDetails_EntryMethodId",
				table: "OrderSOMerchandiseDetails",
				newName: "IX_OrderSOMerchandiseDetails_EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "OrdersDeleted",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrdersDeleted",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeId",
				table: "OrdersDeleted",
				newName: "MaterialTypeID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "OrdersDeleted",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "CustomerId",
				table: "OrdersDeleted",
				newName: "CustomerID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OrdersDeleted",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "VendorId",
				table: "Orders",
				newName: "VendorID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "Orders",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "SalesPersonId",
				table: "Orders",
				newName: "SalesPersonID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "Orders",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "PrimaryOrderId",
				table: "Orders",
				newName: "PrimaryOrderID");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeId",
				table: "Orders",
				newName: "MaterialTypeID");

			migrationBuilder.RenameColumn(
				name: "JobStatusId",
				table: "Orders",
				newName: "JobStatusID");

			migrationBuilder.RenameColumn(
				name: "JobId",
				table: "Orders",
				newName: "JobID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "Orders",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "EnteredById",
				table: "Orders",
				newName: "EnteredByID");

			migrationBuilder.RenameColumn(
				name: "CustomerId",
				table: "Orders",
				newName: "CustomerID");

			migrationBuilder.RenameColumn(
				name: "CreatedById",
				table: "Orders",
				newName: "CreatedByID");

			migrationBuilder.RenameColumn(
				name: "CorrelationId",
				table: "Orders",
				newName: "CorrelationID");

			migrationBuilder.RenameColumn(
				name: "AssignedToId",
				table: "Orders",
				newName: "AssignedToID");

			migrationBuilder.RenameColumn(
				name: "AddressId",
				table: "Orders",
				newName: "AddressID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Orders",
				newName: "OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_StoreId",
				table: "Orders",
				newName: "IX_Orders_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_SalesPersonId",
				table: "Orders",
				newName: "IX_Orders_SalesPersonID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_ReviewedById",
				table: "Orders",
				newName: "IX_Orders_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_PrimaryOrderId",
				table: "Orders",
				newName: "IX_Orders_PrimaryOrderID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_MaterialTypeId",
				table: "Orders",
				newName: "IX_Orders_MaterialTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_JobStatusId",
				table: "Orders",
				newName: "IX_Orders_JobStatusID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_EntryMethodId",
				table: "Orders",
				newName: "IX_Orders_EntryMethodID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_EnteredById",
				table: "Orders",
				newName: "IX_Orders_EnteredByID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_CustomerId",
				table: "Orders",
				newName: "IX_Orders_CustomerID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_AssignedToId",
				table: "Orders",
				newName: "IX_Orders_AssignedToID");

			migrationBuilder.RenameIndex(
				name: "IX_Orders_AddressId",
				table: "Orders",
				newName: "IX_Orders_AddressID");

			migrationBuilder.RenameColumn(
				name: "XMLStatusId",
				table: "OrderRegMerchandiseDetails",
				newName: "XMLStatusID");

			migrationBuilder.RenameColumn(
				name: "StatusId",
				table: "OrderRegMerchandiseDetails",
				newName: "StatusID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "OrderRegMerchandiseDetails",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OriginalOrderId",
				table: "OrderRegMerchandiseDetails",
				newName: "OriginalOrderID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderRegMerchandiseDetails",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "OrderRegMerchandiseDetails",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OrderRegMerchandiseDetails",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderRegMerchandiseDetails_StatusId",
				table: "OrderRegMerchandiseDetails",
				newName: "IX_OrderRegMerchandiseDetails_StatusID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderRegMerchandiseDetails_ReviewedById",
				table: "OrderRegMerchandiseDetails",
				newName: "IX_OrderRegMerchandiseDetails_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderRegMerchandiseDetails_OrderId",
				table: "OrderRegMerchandiseDetails",
				newName: "IX_OrderRegMerchandiseDetails_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderRegMerchandiseDetails_EntryMethodId",
				table: "OrderRegMerchandiseDetails",
				newName: "IX_OrderRegMerchandiseDetails_EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "DocumentId",
				table: "OrderDocument",
				newName: "DocumentID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderDocument",
				newName: "OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderDocument_DocumentId",
				table: "OrderDocument",
				newName: "IX_OrderDocument_DocumentID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderDiagrams",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OrderDiagrams",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderDiagrams_OrderId",
				table: "OrderDiagrams",
				newName: "IX_OrderDiagrams_OrderID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "OrderCustomDetails",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "SubContractorId",
				table: "OrderCustomDetails",
				newName: "SubContractorID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "OrderCustomDetails",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderCustomDetails",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "OrderCustomDetails",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "OrderCustomId",
				table: "OrderCustomDetails",
				newName: "OrderCustomID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_UnitOfMeasureId",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_UnitOfMeasureID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_SubContractorId",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_SubContractorID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_ReviewedById",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_OrderId",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderCustomDetails_EntryMethodId",
				table: "OrderCustomDetails",
				newName: "IX_OrderCustomDetails_EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "OrderBasicLaborDetails",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "OrderBasicLaborDetails",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "MaterialStatusId",
				table: "OrderBasicLaborDetails",
				newName: "MaterialStatusID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "OrderBasicLaborDetails",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "BasicLaborId",
				table: "OrderBasicLaborDetails",
				newName: "BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OrderBasicLaborDetails",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_ReviewedById",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_OrderId",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_MaterialStatusId",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_MaterialStatusID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_EntryMethodId",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_EntryMethodID");

			migrationBuilder.RenameIndex(
				name: "IX_OrderBasicLaborDetails_BasicLaborId",
				table: "OrderBasicLaborDetails",
				newName: "IX_OrderBasicLaborDetails_BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "SubContractorId",
				table: "Order Options Details",
				newName: "SubContractorID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "Order Options Details",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "Order Options Details",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "OptionId",
				table: "Order Options Details",
				newName: "OptionID");

			migrationBuilder.RenameColumn(
				name: "EntryMethodId",
				table: "Order Options Details",
				newName: "EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "OrdeOptionslId",
				table: "Order Options Details",
				newName: "OrdeOptionslID");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_ReviewedById",
				table: "Order Options Details",
				newName: "IX_Order Options Details_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_OrderId",
				table: "Order Options Details",
				newName: "IX_Order Options Details_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_OptionId",
				table: "Order Options Details",
				newName: "IX_Order Options Details_OptionID");

			migrationBuilder.RenameIndex(
				name: "IX_Order Options Details_EntryMethodId",
				table: "Order Options Details",
				newName: "IX_Order Options Details_EntryMethodID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "Options",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeId",
				table: "Options",
				newName: "MaterialTypeID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "Options",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Options",
				newName: "OptionID");

			migrationBuilder.RenameIndex(
				name: "IX_Options_UnitOfMeasureId",
				table: "Options",
				newName: "IX_Options_UnitOfMeasureID");

			migrationBuilder.RenameIndex(
				name: "IX_Options_MaterialTypeId",
				table: "Options",
				newName: "IX_Options_MaterialTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_Options_ItemId",
				table: "Options",
				newName: "IX_Options_ItemID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "OptionRetail",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "OptionRetail",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "OptionRetail",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OptionRetail",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "OptionPricingOld",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "OptionId",
				table: "OptionPricingOld",
				newName: "OptionID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "OptionPricingOld",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OptionPricingOld",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_OptionPricingOld_StoreId",
				table: "OptionPricingOld",
				newName: "IX_OptionPricingOld_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_OptionPricingOld_OptionId",
				table: "OptionPricingOld",
				newName: "IX_OptionPricingOld_OptionID");

			migrationBuilder.RenameIndex(
				name: "IX_OptionPricingOld_MarketId",
				table: "OptionPricingOld",
				newName: "IX_OptionPricingOld_MarketID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "OptionPrice",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "OptionPrice",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "OptionPrice",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OptionPrice",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "OptionCost",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "OptionCost",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "OptionCost",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "OptionCost",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "NoteTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "MeasureCompOrderData",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MeasureCompOrderData",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MeasureCompOrderData_OrderId",
				table: "MeasureCompOrderData",
				newName: "IX_MeasureCompOrderData_OrderID");

			migrationBuilder.RenameColumn(
				name: "CalcId",
				table: "MeasureCompLineItemData",
				newName: "CalcID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MeasureCompLineItemData",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MeasureCompLineItemData_CalcId",
				table: "MeasureCompLineItemData",
				newName: "IX_MeasureCompLineItemData_CalcID");

			migrationBuilder.RenameColumn(
				name: "CustomerId",
				table: "MeasureCompCustData",
				newName: "CustomerID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MeasureCompCustData",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MeasureCompCustData_CustomerId",
				table: "MeasureCompCustData",
				newName: "IX_MeasureCompCustData_CustomerID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "MeasureCompCalcData",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MeasureCompCalcData",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MeasureCompCalcData_OrderId",
				table: "MeasureCompCalcData",
				newName: "IX_MeasureCompCalcData_OrderID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "MaterialTypesMarketMapping",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeId",
				table: "MaterialTypesMarketMapping",
				newName: "MaterialTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialTypesMarketMapping_MarketId",
				table: "MaterialTypesMarketMapping",
				newName: "IX_MaterialTypesMarketMapping_MarketID");

			migrationBuilder.RenameColumn(
				name: "StoreTypeId",
				table: "MaterialType",
				newName: "StoreTypeID");

			migrationBuilder.RenameColumn(
				name: "JobTypeId",
				table: "MaterialType",
				newName: "JobTypeID");

			migrationBuilder.RenameColumn(
				name: "DivisionId",
				table: "MaterialType",
				newName: "DivisionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MaterialType",
				newName: "MaterialTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialType_StoreTypeId",
				table: "MaterialType",
				newName: "IX_MaterialType_StoreTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialType_JobTypeId",
				table: "MaterialType",
				newName: "IX_MaterialType_JobTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialType_DivisionId",
				table: "MaterialType",
				newName: "IX_MaterialType_DivisionID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "MaterialPrice",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "ProgramId",
				table: "MaterialPrice",
				newName: "ProgramID");

			migrationBuilder.RenameColumn(
				name: "MaterialCatId",
				table: "MaterialPrice",
				newName: "MaterialCatID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "MaterialPrice",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MaterialPrice",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialPrice_StoreId",
				table: "MaterialPrice",
				newName: "IX_MaterialPrice_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialPrice_ProgramId",
				table: "MaterialPrice",
				newName: "IX_MaterialPrice_ProgramID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialPrice_MaterialCatId",
				table: "MaterialPrice",
				newName: "IX_MaterialPrice_MaterialCatID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialPrice_MarketId",
				table: "MaterialPrice",
				newName: "IX_MaterialPrice_MarketID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "MaterialCost",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "ProgramId",
				table: "MaterialCost",
				newName: "ProgramID");

			migrationBuilder.RenameColumn(
				name: "MaterialCatId",
				table: "MaterialCost",
				newName: "MaterialCatID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "MaterialCost",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "MaterialCost",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCost_StoreId",
				table: "MaterialCost",
				newName: "IX_MaterialCost_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCost_ProgramId",
				table: "MaterialCost",
				newName: "IX_MaterialCost_ProgramID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCost_MaterialCatId",
				table: "MaterialCost",
				newName: "IX_MaterialCost_MaterialCatID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCost_MarketId",
				table: "MaterialCost",
				newName: "IX_MaterialCost_MarketID");

			migrationBuilder.RenameColumn(
				name: "OptionId",
				table: "MaterialCategoryOptionsMappings",
				newName: "OptionID");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryId",
				table: "MaterialCategoryOptionsMappings",
				newName: "MaterialCategoryID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCategoryOptionsMappings_OptionId",
				table: "MaterialCategoryOptionsMappings",
				newName: "IX_MaterialCategoryOptionsMappings_OptionID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "MaterialCategoryItemMappings",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryId",
				table: "MaterialCategoryItemMappings",
				newName: "MaterialCategoryID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCategoryItemMappings_ItemId",
				table: "MaterialCategoryItemMappings",
				newName: "IX_MaterialCategoryItemMappings_ItemID");

			migrationBuilder.RenameColumn(
				name: "BasicLaborId",
				table: "MaterialCategoryBasicLaborMappings",
				newName: "BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "MaterialCategoryId",
				table: "MaterialCategoryBasicLaborMappings",
				newName: "MaterialCategoryID");

			migrationBuilder.RenameIndex(
				name: "IX_MaterialCategoryBasicLaborMappings_BasicLaborId",
				table: "MaterialCategoryBasicLaborMappings",
				newName: "IX_MaterialCategoryBasicLaborMappings_BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Material Status",
				newName: "MatStatusID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "Material Catagory",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameIndex(
				name: "IX_Material Catagory_UnitOfMeasureId",
				table: "Material Catagory",
				newName: "IX_Material Catagory_UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "ManagerId",
				table: "Market",
				newName: "ManagerID");

			migrationBuilder.RenameIndex(
				name: "IX_Market_ManagerId",
				table: "Market",
				newName: "IX_Market_ManagerID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "LaborType",
				newName: "LaborTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "JobTypes",
				newName: "JobTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "JobStatus",
				newName: "JobStatusID");

			migrationBuilder.RenameColumn(
				name: "PrimaryOrderId",
				table: "Jobs",
				newName: "PrimaryOrderID");

			migrationBuilder.RenameColumn(
				name: "JobStatusId",
				table: "Jobs",
				newName: "JobStatusID");

			migrationBuilder.RenameColumn(
				name: "CreatedById",
				table: "Jobs",
				newName: "CreatedByID");

			migrationBuilder.RenameColumn(
				name: "AssignedToId",
				table: "Jobs",
				newName: "AssignedToID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Jobs",
				newName: "JobID");

			migrationBuilder.RenameIndex(
				name: "IX_Jobs_PrimaryOrderId",
				table: "Jobs",
				newName: "IX_Jobs_PrimaryOrderID");

			migrationBuilder.RenameIndex(
				name: "IX_Jobs_JobStatusId",
				table: "Jobs",
				newName: "IX_Jobs_JobStatusID");

			migrationBuilder.RenameIndex(
				name: "IX_Jobs_CreatedById",
				table: "Jobs",
				newName: "IX_Jobs_CreatedByID");

			migrationBuilder.RenameIndex(
				name: "IX_Jobs_AssignedToId",
				table: "Jobs",
				newName: "IX_Jobs_AssignedToID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "ItemPricing",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "ItemPricing",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "ItemPricing",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ItemPricing",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "ItemMatCosting",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "ItemMatCosting",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "ItemMatCosting",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ItemMatCosting",
				newName: "ItemMatCostingID");

			migrationBuilder.RenameIndex(
				name: "IX_ItemMatCosting_StoreId",
				table: "ItemMatCosting",
				newName: "IX_ItemMatCosting_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_ItemMatCosting_MarketId",
				table: "ItemMatCosting",
				newName: "IX_ItemMatCosting_MarketID");

			migrationBuilder.RenameIndex(
				name: "IX_ItemMatCosting_ItemId",
				table: "ItemMatCosting",
				newName: "IX_ItemMatCosting_ItemID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "ItemCosting",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "ItemCosting",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "ItemCosting",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "DivisionId",
				table: "ItemCosting",
				newName: "DivisionID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ItemCosting",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_ItemCosting_DivisionId",
				table: "ItemCosting",
				newName: "IX_ItemCosting_DivisionID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "Item",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Item",
				newName: "ItemID");

			migrationBuilder.RenameIndex(
				name: "IX_Item_UnitOfMeasureId",
				table: "Item",
				newName: "IX_Item_UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "IssueTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "IssueStatus",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StatusId",
				table: "Issues",
				newName: "StatusID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Issues",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "InstallerStatus",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "JobTypeId",
				table: "InstallCapacity",
				newName: "JobTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "InstallCapacity",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "MaxSizeId",
				table: "InstallationCrewType",
				newName: "MaxSizeID");

			migrationBuilder.RenameColumn(
				name: "JobTypeId",
				table: "InstallationCrewType",
				newName: "JobTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "InstallationCrewType",
				newName: "CrewID");

			migrationBuilder.RenameIndex(
				name: "IX_InstallationCrewType_JobTypeId",
				table: "InstallationCrewType",
				newName: "IX_InstallationCrewType_JobTypeID");

			migrationBuilder.RenameColumn(
				name: "OwnerId",
				table: "InstallationCrew",
				newName: "OwnerID");

			migrationBuilder.RenameColumn(
				name: "LeadId",
				table: "InstallationCrew",
				newName: "LeadID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "InstallationCrew",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "InstallationCrew",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_InstallationCrew_OwnerId",
				table: "InstallationCrew",
				newName: "IX_InstallationCrew_OwnerID");

			migrationBuilder.RenameIndex(
				name: "IX_InstallationCrew_LeadId",
				table: "InstallationCrew",
				newName: "IX_InstallationCrew_LeadID");

			migrationBuilder.RenameIndex(
				name: "IX_InstallationCrew_BranchId",
				table: "InstallationCrew",
				newName: "IX_InstallationCrew_BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "EntryMethod",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Employees",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "EmailTemplates",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "EmailImages",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Document",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "DivisionGroups",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "VendorId",
				table: "Division",
				newName: "VendorID");

			migrationBuilder.RenameColumn(
				name: "DivisionGroupId",
				table: "Division",
				newName: "DivisionGroupID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Division",
				newName: "DivisionID");

			migrationBuilder.RenameIndex(
				name: "IX_Division_DivisionGroupId",
				table: "Division",
				newName: "IX_Division_DivisionGroupID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "DiscrepancyType",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "DiscrepancySubType",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "DiscrepanciesPrice",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "DiscrepanciesPrice",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "DiscrepancyTypeId",
				table: "DiscrepanciesPrice",
				newName: "DiscrepancyTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "DiscrepanciesPrice",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "ReviewedById",
				table: "Discrepancies",
				newName: "ReviewedByID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "Discrepancies",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "DiscrepancyTypeId",
				table: "Discrepancies",
				newName: "DiscrepancyTypeID");

			migrationBuilder.RenameColumn(
				name: "DiscrepancySubTypeId",
				table: "Discrepancies",
				newName: "DiscrepancySubTypeID");

			migrationBuilder.RenameColumn(
				name: "DetailId",
				table: "Discrepancies",
				newName: "DetailID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Discrepancies",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_Discrepancies_ReviewedById",
				table: "Discrepancies",
				newName: "IX_Discrepancies_ReviewedByID");

			migrationBuilder.RenameIndex(
				name: "IX_Discrepancies_OrderId",
				table: "Discrepancies",
				newName: "IX_Discrepancies_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_Discrepancies_DiscrepancyTypeId",
				table: "Discrepancies",
				newName: "IX_Discrepancies_DiscrepancyTypeID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "DepartmentsStoresAssignments",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "DepartmentId",
				table: "DepartmentsStoresAssignments",
				newName: "DepartmentID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "DepartmentsStoresAssignments",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_DepartmentsStoresAssignments_StoreId",
				table: "DepartmentsStoresAssignments",
				newName: "IX_DepartmentsStoresAssignments_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_DepartmentsStoresAssignments_DepartmentId",
				table: "DepartmentsStoresAssignments",
				newName: "IX_DepartmentsStoresAssignments_DepartmentID");

			migrationBuilder.RenameColumn(
				name: "ContactTitlesId",
				table: "DepartmentsContactTitles",
				newName: "ContactTitlesID");

			migrationBuilder.RenameColumn(
				name: "DepartmentsId",
				table: "DepartmentsContactTitles",
				newName: "DepartmentsID");

			migrationBuilder.RenameIndex(
				name: "IX_DepartmentsContactTitles_ContactTitlesId",
				table: "DepartmentsContactTitles",
				newName: "IX_DepartmentsContactTitles_ContactTitlesID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Departments",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "QBCustomerId",
				table: "Customers",
				newName: "QBCustomerID");

			migrationBuilder.RenameColumn(
				name: "AddressId",
				table: "Customers",
				newName: "AddressID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Customers",
				newName: "CustomerID");

			migrationBuilder.RenameIndex(
				name: "IX_Customers_AddressId",
				table: "Customers",
				newName: "IX_Customers_AddressID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ContactTitles",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "CompanyInfo",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "ReportTypeId",
				table: "ClientTypeReports",
				newName: "ReportTypeID");

			migrationBuilder.RenameColumn(
				name: "ClientTypeId",
				table: "ClientTypeReports",
				newName: "ClientTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_ClientTypeReports_ReportTypeId",
				table: "ClientTypeReports",
				newName: "IX_ClientTypeReports_ReportTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_ClientTypeReports_ClientTypeId",
				table: "ClientTypeReports",
				newName: "IX_ClientTypeReports_ClientTypeID");

			migrationBuilder.RenameColumn(
				name: "VendorId",
				table: "Checks",
				newName: "VendorID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Checks",
				newName: "CheckID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "CheckDetail",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "CheckId",
				table: "CheckDetail",
				newName: "CheckID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "CheckDetail",
				newName: "CheckDetailID");

			migrationBuilder.RenameIndex(
				name: "IX_CheckDetail_OrderId",
				table: "CheckDetail",
				newName: "IX_CheckDetail_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_CheckDetail_CheckId",
				table: "CheckDetail",
				newName: "IX_CheckDetail_CheckID");

			migrationBuilder.RenameColumn(
				name: "CheckId",
				table: "CheckCBDetail",
				newName: "CheckID");

			migrationBuilder.RenameColumn(
				name: "ChargeBackId",
				table: "CheckCBDetail",
				newName: "ChargeBackID");

			migrationBuilder.RenameColumn(
				name: "CheckCBDetailId",
				table: "CheckCBDetail",
				newName: "CheckCBDetailID");

			migrationBuilder.RenameIndex(
				name: "IX_CheckCBDetail_CheckId",
				table: "CheckCBDetail",
				newName: "IX_CheckCBDetail_CheckID");

			migrationBuilder.RenameIndex(
				name: "IX_CheckCBDetail_ChargeBackId",
				table: "CheckCBDetail",
				newName: "IX_CheckCBDetail_ChargeBackID");

			migrationBuilder.RenameColumn(
				name: "SubcontractorId",
				table: "ChargeBacks",
				newName: "SubcontractorID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "ChargeBacks",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ChargeBacks",
				newName: "ChargeBackID");

			migrationBuilder.RenameIndex(
				name: "IX_ChargeBacks_OrderId",
				table: "ChargeBacks",
				newName: "IX_ChargeBacks_OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "CapacityPoolTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "VendorId",
				table: "CapacityPools",
				newName: "VendorID");

			migrationBuilder.RenameColumn(
				name: "PoolTypeId",
				table: "CapacityPools",
				newName: "PoolTypeID");

			migrationBuilder.RenameColumn(
				name: "HDPoolId",
				table: "CapacityPools",
				newName: "HDPoolID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "CapacityPools",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "PoolId",
				table: "Capacity",
				newName: "PoolID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Capacity",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "ClassificationId",
				table: "BillDetails",
				newName: "ClassificationID");

			migrationBuilder.RenameColumn(
				name: "ChargeBackId",
				table: "BillDetails",
				newName: "ChargeBackID");

			migrationBuilder.RenameColumn(
				name: "BackChargeOwnerId",
				table: "BillDetails",
				newName: "BackChargeOwnerID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BillDetails",
				newName: "BillDetailsId");

			migrationBuilder.RenameIndex(
				name: "IX_BillDetails_ChargeBackId",
				table: "BillDetails",
				newName: "IX_BillDetails_ChargeBackID");

			migrationBuilder.RenameIndex(
				name: "IX_BillDetails_BackChargeOwnerId",
				table: "BillDetails",
				newName: "IX_BillDetails_BackChargeOwnerID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "BasicRetail",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "BasicRetail",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "BasicRetail",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BasicRetail",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "BasicPricingOld",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "MarketId",
				table: "BasicPricingOld",
				newName: "MarketID");

			migrationBuilder.RenameColumn(
				name: "BasicLaborId",
				table: "BasicPricingOld",
				newName: "BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BasicPricingOld",
				newName: "BasicPricingID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicPricingOld_StoreId",
				table: "BasicPricingOld",
				newName: "IX_BasicPricingOld_StoreID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicPricingOld_MarketId",
				table: "BasicPricingOld",
				newName: "IX_BasicPricingOld_MarketID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicPricingOld_BasicLaborId",
				table: "BasicPricingOld",
				newName: "IX_BasicPricingOld_BasicLaborID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "BasicPrice",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "BasicPrice",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "BasicPrice",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BasicPrice",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "UnitOfMeasureId",
				table: "BasicLabor",
				newName: "UnitOfMeasureID");

			migrationBuilder.RenameColumn(
				name: "MaterialTypeId",
				table: "BasicLabor",
				newName: "MaterialTypeID");

			migrationBuilder.RenameColumn(
				name: "ItemId",
				table: "BasicLabor",
				newName: "ItemID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BasicLabor",
				newName: "BasicLaborID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicLabor_UnitOfMeasureId",
				table: "BasicLabor",
				newName: "IX_BasicLabor_UnitOfMeasureID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicLabor_MaterialTypeId",
				table: "BasicLabor",
				newName: "IX_BasicLabor_MaterialTypeID");

			migrationBuilder.RenameIndex(
				name: "IX_BasicLabor_ItemId",
				table: "BasicLabor",
				newName: "IX_BasicLabor_ItemID");

			migrationBuilder.RenameColumn(
				name: "StoreId",
				table: "BasicCost",
				newName: "StoreID");

			migrationBuilder.RenameColumn(
				name: "LaborId",
				table: "BasicCost",
				newName: "LaborID");

			migrationBuilder.RenameColumn(
				name: "BranchId",
				table: "BasicCost",
				newName: "BranchID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "BasicCost",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "EmployeeId",
				table: "Admins",
				newName: "EmployeeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "Address",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ActivityTypes",
				newName: "ID");

			migrationBuilder.RenameColumn(
				name: "PONoteId",
				table: "ActivityPONoteMapping",
				newName: "PONoteID");

			migrationBuilder.RenameColumn(
				name: "ActivityId",
				table: "ActivityPONoteMapping",
				newName: "ActivityID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityPONoteMapping_PONoteId",
				table: "ActivityPONoteMapping",
				newName: "IX_ActivityPONoteMapping_PONoteID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "ActivityList",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "CreatedById",
				table: "ActivityList",
				newName: "CreatedByID");

			migrationBuilder.RenameColumn(
				name: "ClosedById",
				table: "ActivityList",
				newName: "ClosedByID");

			migrationBuilder.RenameColumn(
				name: "ActivityTypeId",
				table: "ActivityList",
				newName: "ActivityTypeID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ActivityList",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityList_OrderId",
				table: "ActivityList",
				newName: "IX_ActivityList_OrderID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityList_CreatedById",
				table: "ActivityList",
				newName: "IX_ActivityList_CreatedByID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityList_ClosedById",
				table: "ActivityList",
				newName: "IX_ActivityList_ClosedByID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityList_ActivityTypeId",
				table: "ActivityList",
				newName: "IX_ActivityList_ActivityTypeID");

			migrationBuilder.RenameColumn(
				name: "ActivityId",
				table: "ActivityData",
				newName: "ActivityID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ActivityData",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_ActivityData_ActivityId",
				table: "ActivityData",
				newName: "IX_ActivityData_ActivityID");

			migrationBuilder.RenameColumn(
				name: "OrderId",
				table: "ActionReport",
				newName: "OrderID");

			migrationBuilder.RenameColumn(
				name: "Id",
				table: "ActionReport",
				newName: "ID");

			migrationBuilder.RenameIndex(
				name: "IX_ActionReport_OrderId",
				table: "ActionReport",
				newName: "IX_ActionReport_OrderID");

			migrationBuilder.AddForeignKey(
				name: "FK_ActivityList_Employees_ClosedByID",
				table: "ActivityList",
				column: "ClosedByID",
				principalTable: "Employees",
				principalColumn: "ID",
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
		}
	}
}
