using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IMCore.Domain
{
	public interface IIMContext : IDisposable
	{
		DbSet<ActionReport> ActionReports { get; set; }
		DbSet<Activity> SPNActivities { get; set; }
		DbSet<ActivityTypes> ActivityTypes { get; set; }
		DbSet<BasicLabor> BasicLabors { get; set; }
		DbSet<ChargeBack> ChargeBacks { get; set; }
		DbSet<CheckCBDetail> CheckCBDetails { get; set; }
		DbSet<CheckDetail> CheckDetails { get; set; }
		DbSet<Checks> Checks { get; set; }
		DbSet<ContactTitle> ContactTitles { get; set; }
		DbSet<Customer> Customers { get; set; }
		DbSet<Department> Departments { get; set; }
		DbSet<DepartmentsContactTitles> DepartmentsContactTitles { get; set; }
		DbSet<DepartmentsStoresAssignments> DepartmentsStoresAssignments { get; set; }
		DbSet<Division> Divisions { get; set; }
		DbSet<User> Users { get; set; }
		//        DbSet<Job> Jobs { get; set; }
		DbSet<Market> Markets { get; set; }
		DbSet<MaterialStatus> MaterialStatus { get; set; }
		DbSet<Program> Programs { get; set; }
		DbSet<NoteType> NoteTypes { get; set; }
		DbSet<Option> OptionalLabor { get; set; }
		DbSet<OrderOptionalLaborDetail> OrderOptionalLaborDetails { get; set; }
		//        DbSet<OrderAttachment> OrderAttachments { get; set; }
		DbSet<OrderBasicLaborDetail> OrderBasicLaborDetails { get; set; }
		DbSet<OrderCustomDetail> OrderCustomLaborDetails { get; set; }
		DbSet<OrderDiagram> OrderDiagrams { get; set; }
		DbSet<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
		DbSet<Order> Orders { get; set; }
		DbSet<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
		DbSet<Permissions> Permissions { get; set; }
		DbSet<PONote> PONotes { get; set; }
		DbSet<ClientContact> ClientContacts { get; set; }
		DbSet<Client> Clients { get; set; }
		DbSet<ClientType> ClientTypes { get; set; }
		DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
		DbSet<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
		DbSet<UserPermissions> UserPermissions { get; set; }
		DbSet<EmailTemplate> EmailTemplates { get; set; }
		DbSet<UserTask> UserTasks { get; set; }
		DbSet<UserTaskType> UserTaskTypes { get; set; }
		//        DbSet<vwUserTask> vwUserTasks { get; set; }
		DbSet<CompanyInfo> CompanySettings { get; set; }
		DbSet<MeasureCompCalcs> MeasureCompCalcs { get; set; }
		DbSet<MeasureCompCustomers> MeasureCompCustomers { get; set; }
		DbSet<MeasureCompLineItem> MeasureCompLineItems { get; set; }
		DbSet<MeasureCompOrder> MeasureCompOrders { get; set; }
		DbSet<States> States { get; set; }
		//        DbSet<vwPOPickList> vwPOPickLists { get; set; }
		DbSet<Material> Materials { get; set; }
		DbSet<MaterialSubCategory> MaterialSubCategories { get; set; }
		//        DbSet<vwStoreContact> vwStoreContacts { get; set; }
		DbSet<SPNActionQueue> QueuedSPNActions { get; set; }
		DbSet<SPNActionType> SPNActionTypes { get; set; }
		//        DbSet<vwPONotesWithName> vwPONotesWithNames { get; set; }
		//        DbSet<vwOpenUserTasksWithCustomerID> vwOpenUserTasksWithCustomerIDs { get; set; }
		DbSet<JobStatus> JobStatus { get; set; }
		DbSet<JobType> JobTypes { get; set; }
		//        DbSet<vwUnassignedActivePOs> vwUnassignedActivePOs { get; set; }
		DbSet<SpokeWith> SpokeWiths { get; set; }
		DbSet<Admin> Admins { get; set; }
		DbSet<Item> Items { get; set; }
		DbSet<ItemPricing> ItemPricings { get; set; }
		DbSet<ItemCosting> ItemCostings { get; set; }
		DbSet<MaterialCost> MaterialCosts { get; set; }
		DbSet<Settings> Settings { get; set; }
		//        DbSet<vwUserPermission> vwUserPermissions { get; set; }
		DbSet<Version> Versions { get; set; }
		DbSet<InstallationCrew> InstallationCrews { get; set; }
		DbSet<InstallCapacity> InstallCapacities { get; set; }
		DbSet<ActivityData> ActivityDatas { get; set; }
		DbSet<DiscrepancySubType> DiscrepancySubTypes { get; set; }
		DbSet<DiscrepancyType> DiscrepancyTypes { get; set; }
		DbSet<Discrepancy> Discrepancies { get; set; }
		DbSet<DiscrepanciesPrice> DiscrepanciesPrices { get; set; }
		DbSet<BasicCost> BasicCosts { get; set; }
		DbSet<BasicRetail> BasicRetails { get; set; }
		DbSet<BasicPrice> BasicPrices { get; set; }
		DbSet<OptionCost> OptionCosts { get; set; }
		DbSet<OptionRetail> OptionRetails { get; set; }
		DbSet<OptionPrice> OptionPrices { get; set; }
		DbSet<ProgramBranchMapping> ProgramBranchMappings { get; set; }
		DbSet<InstallCapacityGrid> InstallCapacityGrids { get; set; }
		DbSet<POPhoto> POPhotos { get; set; }
		DbSet<VOC> VOCs { get; set; }
		//        DbSet<vwOrderIDsFromDiscrepanciesTable> vwOrderIDsFromDiscrepanciesTables { get; set; }
		DbSet<Bill> Bills { get; set; }
		DbSet<BillDetail> BillDetails { get; set; }
		DbSet<SubContractor> SubContractors { get; set; }
		DbSet<EmailImage> EmailImages { get; set; }
		DbSet<WorkOrder> WorkOrders { get; set; }
		DbSet<InstallationCrewType> InstallationCrewTypes { get; set; }
		DbSet<ReportType> ReportTypes { get; set; }
		DbSet<EntryMethod> EntryMethods { get; set; }
		DbSet<Document> Documents { get; set; }


		DbSet<ClientTypeReport> ClientTypeReports { get; set; }
		DbSet<ProgramReport> ProgramReports { get; set; }
		DbSet<BillClassification> BillClassifications { get; set; }




		void SetCommandTimeout(int Timeout);
		int SaveChanges();

		EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
			where TEntity : class;

		DbSet<TEntity> GetIDbSet<TEntity>()
			where TEntity : class, new();

		IQueryable<TEntity> GetNonTrackedIDbSet<TEntity>()
			where TEntity : class;

		TEntity AddEntity<TEntity>(TEntity T)
			where TEntity : class;

		TEntity RemoveEntity<TEntity>(TEntity T)
			where TEntity : class;

		int UserPermissionsSetAndClearMultiple(Nullable<int> userID, Nullable<int> marketID, Nullable<int> divisionID, string clearPermissionIDs, string setPermissionIDs);
		int UserPermissionsClearAll(Nullable<int> userID);

////		ObjectResult<GetMarketAndDivisionsByPermissionAndUser_Result> GetMarketAndDivisionsByPermissionAndUser(Nullable<int> userID, string permissionName);
		int MergeJobs(Nullable<int> mainJobID, Nullable<int> jobIDToMerge);
		int RemovePOsFromJob(Nullable<int> jobID);
		int CreateStatusDetails(string storefilter);

		IEnumerable<TEntity> SqlQuery<TEntity>(string sqlCommand, params object[] parameters) where TEntity : class;

		IIMContext Clone();
		bool IsDirty { get; }

		string ToString();
		string ODBCConnestionString { get; }
	}
}
