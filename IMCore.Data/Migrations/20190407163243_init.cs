using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class init : Migration
    {
		protected override void Up(MigrationBuilder migrationBuilder)
		{
		}

		protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionQueue");

            migrationBuilder.DropTable(
                name: "ActionReport");

            migrationBuilder.DropTable(
                name: "ActivityData");

            migrationBuilder.DropTable(
                name: "ActivityPONoteMapping");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "BasicCost");

            migrationBuilder.DropTable(
                name: "BasicPrice");

            migrationBuilder.DropTable(
                name: "BasicPricingOld");

            migrationBuilder.DropTable(
                name: "BasicRetail");

            migrationBuilder.DropTable(
                name: "BillClassification");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Calls");

            migrationBuilder.DropTable(
                name: "Capacity");

            migrationBuilder.DropTable(
                name: "CapacityPools");

            migrationBuilder.DropTable(
                name: "CapacityPoolTypes");

            migrationBuilder.DropTable(
                name: "CheckCBDetail");

            migrationBuilder.DropTable(
                name: "CheckDetail");

            migrationBuilder.DropTable(
                name: "ClientTypeReports");

            migrationBuilder.DropTable(
                name: "CompanyInfo");

            migrationBuilder.DropTable(
                name: "DaysOfYear");

            migrationBuilder.DropTable(
                name: "DepartmentsContactTitles");

            migrationBuilder.DropTable(
                name: "DepartmentsStoresAssignments");

            migrationBuilder.DropTable(
                name: "Discrepancies");

            migrationBuilder.DropTable(
                name: "DiscrepanciesPrice");

            migrationBuilder.DropTable(
                name: "DiscrepancySubType");

            migrationBuilder.DropTable(
                name: "EmailImages");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "InstallationCrewType");

            migrationBuilder.DropTable(
                name: "InstallCapacity");

            migrationBuilder.DropTable(
                name: "InstallCapacityGrid");

            migrationBuilder.DropTable(
                name: "Installer Error");

            migrationBuilder.DropTable(
                name: "InstallerStatus");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "IssueStatus");

            migrationBuilder.DropTable(
                name: "IssueTypes");

            migrationBuilder.DropTable(
                name: "ItemCosting");

            migrationBuilder.DropTable(
                name: "ItemMatCosting");

            migrationBuilder.DropTable(
                name: "ItemPricing");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "LaborType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "MaterialCategoryBasicLaborMappings");

            migrationBuilder.DropTable(
                name: "MaterialCategoryItemMappings");

            migrationBuilder.DropTable(
                name: "MaterialCategoryOptionsMappings");

            migrationBuilder.DropTable(
                name: "MaterialCost");

            migrationBuilder.DropTable(
                name: "MaterialPrice");

            migrationBuilder.DropTable(
                name: "MaterialTypesMarketMapping");

            migrationBuilder.DropTable(
                name: "Measure Error");

            migrationBuilder.DropTable(
                name: "MeasureCompCustData");

            migrationBuilder.DropTable(
                name: "MeasureCompLineItemData");

            migrationBuilder.DropTable(
                name: "MeasureCompOrderData");

            migrationBuilder.DropTable(
                name: "Mill Error");

            migrationBuilder.DropTable(
                name: "OldCarpet");

            migrationBuilder.DropTable(
                name: "OptionCost");

            migrationBuilder.DropTable(
                name: "OptionPrice");

            migrationBuilder.DropTable(
                name: "OptionPricingOld");

            migrationBuilder.DropTable(
                name: "OptionRetail");

            migrationBuilder.DropTable(
                name: "Order Options Details");

            migrationBuilder.DropTable(
                name: "OrderBasicLaborDetails");

            migrationBuilder.DropTable(
                name: "OrderCustomDetails");

            migrationBuilder.DropTable(
                name: "OrderDiagrams");

            migrationBuilder.DropTable(
                name: "OrderDocument");

            migrationBuilder.DropTable(
                name: "OrderRegMerchandiseDetails");

            migrationBuilder.DropTable(
                name: "OrdersDeleted");

            migrationBuilder.DropTable(
                name: "Payroll");

            migrationBuilder.DropTable(
                name: "PayrollMessages");

            migrationBuilder.DropTable(
                name: "PhoneNumberTypes");

            migrationBuilder.DropTable(
                name: "POPhotos");

            migrationBuilder.DropTable(
                name: "POStatusValues");

            migrationBuilder.DropTable(
                name: "PrintedPOData");

            migrationBuilder.DropTable(
                name: "ProgramReport");

            migrationBuilder.DropTable(
                name: "ScheduleChangeReasonCodes");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SODocument");

            migrationBuilder.DropTable(
                name: "SOSIDocumentTypes");

            migrationBuilder.DropTable(
                name: "SOSIOutgoingDocuments");

            migrationBuilder.DropTable(
                name: "SOSIScheduleWillCallDocuments");

            migrationBuilder.DropTable(
                name: "SOSISentDocuments");

            migrationBuilder.DropTable(
                name: "SPNActionQueue");

            migrationBuilder.DropTable(
                name: "SPNImportedPOs");

            migrationBuilder.DropTable(
                name: "SpokeWith");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Store Error");

            migrationBuilder.DropTable(
                name: "StoreContacts");

            migrationBuilder.DropTable(
                name: "SubContractorsDivisionAssignments");

            migrationBuilder.DropTable(
                name: "UserMarketDivisionAssignments");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "UserTasks");

            migrationBuilder.DropTable(
                name: "VendorNumbers");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "VOC");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "WorkOrderDocument");

            migrationBuilder.DropTable(
                name: "WorkOrderEmails");

            migrationBuilder.DropTable(
                name: "XMLSources");

            migrationBuilder.DropTable(
                name: "ActivityList");

            migrationBuilder.DropTable(
                name: "PONotes");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ChargeBacks");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "ContactTitles");

            migrationBuilder.DropTable(
                name: "DiscrepancyType");

            migrationBuilder.DropTable(
                name: "Material Catagory");

            migrationBuilder.DropTable(
                name: "MeasureCompCalcData");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "BasicLabor");

            migrationBuilder.DropTable(
                name: "ReportType");

            migrationBuilder.DropTable(
                name: "OrderSOMerchandiseDetails");

            migrationBuilder.DropTable(
                name: "SPNActions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "UserTaskTypes");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "ActivityTypes");

            migrationBuilder.DropTable(
                name: "NoteTypes");

            migrationBuilder.DropTable(
                name: "MatSubCat");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Material Status");

            migrationBuilder.DropTable(
                name: "PermissionType");

            migrationBuilder.DropTable(
                name: "InstallationCrew");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "SubContractors");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "EntryMethod");

            migrationBuilder.DropTable(
                name: "JobStatus");

            migrationBuilder.DropTable(
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "StoreType");

            migrationBuilder.DropTable(
                name: "DivisionGroups");
        }
    }
}
