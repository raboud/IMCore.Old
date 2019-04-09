using System;
using IMCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IMCore.Data
{
	public interface IIMContext22 : IDisposable
	{
		EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
	where TEntity : class;

		//		ObjectResult<GetMarketAndDivisionsByPermissionAndUser_Result> GetMarketAndDivisionsByPermissionAndUser(Nullable<int> userID, string permissionName);

	}
	public partial class IMCoreContext : DbContext
	{
		public IMCoreContext()
		{
		}

		public IMCoreContext(DbContextOptions<IMCoreContext> options)
			: base(options)
		{
		}

		public virtual DbSet<ActionQueue> ActionQueue { get; set; }
		public virtual DbSet<ActionReport> ActionReport { get; set; }
		public virtual DbSet<ActivityData> ActivityData { get; set; }
		public virtual DbSet<Activity> ActivityList { get; set; }
		public virtual DbSet<ActivityPonoteMapping> ActivityPonoteMapping { get; set; }
		public virtual DbSet<ActivityTypes> ActivityTypes { get; set; }
		public virtual DbSet<Address> Address { get; set; }
		public virtual DbSet<Admin> Admins { get; set; }
		public virtual DbSet<BasicCost> BasicCost { get; set; }
		public virtual DbSet<BasicLabor> BasicLabor { get; set; }
		public virtual DbSet<BasicPrice> BasicPrice { get; set; }
		public virtual DbSet<BasicPricingOld> BasicPricingOld { get; set; }
		public virtual DbSet<BasicRetail> BasicRetail { get; set; }
		public virtual DbSet<Bill> Bill { get; set; }
		public virtual DbSet<BillClassification> BillClassification { get; set; }
		public virtual DbSet<BillDetail> BillDetails { get; set; }
		public virtual DbSet<Calls> Calls { get; set; }
		public virtual DbSet<Capacity> Capacity { get; set; }
		public virtual DbSet<CapacityPoolTypes> CapacityPoolTypes { get; set; }
		public virtual DbSet<CapacityPools> CapacityPools { get; set; }
		public virtual DbSet<ChargeBack> ChargeBacks { get; set; }
		public virtual DbSet<CheckCBDetail> CheckCbdetail { get; set; }
		public virtual DbSet<CheckDetail> CheckDetail { get; set; }
		public virtual DbSet<Checks> Checks { get; set; }
		public virtual DbSet<ClientTypeReport> ClientTypeReports { get; set; }
		public virtual DbSet<CompanyInfo> CompanyInfo { get; set; }
		public virtual DbSet<ContactTitle> ContactTitles { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<DaysOfYear> DaysOfYear { get; set; }
		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<DepartmentsContactTitles> DepartmentsContactTitles { get; set; }
		public virtual DbSet<DepartmentsStoresAssignments> DepartmentsStoresAssignments { get; set; }
		public virtual DbSet<Discrepancy> Discrepancies { get; set; }
		public virtual DbSet<DiscrepanciesPrice> DiscrepanciesPrice { get; set; }
		public virtual DbSet<DiscrepancySubType> DiscrepancySubType { get; set; }
		public virtual DbSet<DiscrepancyType> DiscrepancyType { get; set; }
		public virtual DbSet<Division> Division { get; set; }
		public virtual DbSet<DivisionGroups> DivisionGroups { get; set; }
		public virtual DbSet<Document> Document { get; set; }
		public virtual DbSet<EmailImage> EmailImages { get; set; }
		public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
		public virtual DbSet<User> Employees { get; set; }
		public virtual DbSet<EntryMethod> EntryMethod { get; set; }
		public virtual DbSet<InstallCapacity> InstallCapacity { get; set; }
		public virtual DbSet<InstallCapacityGrid> InstallCapacityGrid { get; set; }
		public virtual DbSet<InstallationCrew> InstallationCrew { get; set; }
		public virtual DbSet<InstallationCrewType> InstallationCrewType { get; set; }
		public virtual DbSet<InstallerError> InstallerError { get; set; }
		public virtual DbSet<InstallerStatus> InstallerStatus { get; set; }
		public virtual DbSet<IssueStatus> IssueStatus { get; set; }
		public virtual DbSet<IssueTypes> IssueTypes { get; set; }
		public virtual DbSet<Issues> Issues { get; set; }
		public virtual DbSet<Item> Item { get; set; }
		public virtual DbSet<ItemCosting> ItemCosting { get; set; }
		public virtual DbSet<ItemMatCosting> ItemMatCosting { get; set; }
		public virtual DbSet<ItemPricing> ItemPricing { get; set; }
		public virtual DbSet<JobStatus> JobStatus { get; set; }
		public virtual DbSet<JobType> JobTypes { get; set; }
		public virtual DbSet<Jobs> Jobs { get; set; }
		public virtual DbSet<LaborType> LaborType { get; set; }
		public virtual DbSet<Location> Location { get; set; }
		public virtual DbSet<Market> Market { get; set; }
		public virtual DbSet<MaterialSubCategory> MatSubCat { get; set; }
		public virtual DbSet<Material> MaterialCatagory { get; set; }
		public virtual DbSet<MaterialCategoryBasicLaborMappings> MaterialCategoryBasicLaborMappings { get; set; }
		public virtual DbSet<MaterialCategoryItemMappings> MaterialCategoryItemMappings { get; set; }
		public virtual DbSet<MaterialCategoryOptionsMappings> MaterialCategoryOptionsMappings { get; set; }
		public virtual DbSet<MaterialCost> MaterialCost { get; set; }
		public virtual DbSet<MaterialPrice> MaterialPrice { get; set; }
		public virtual DbSet<MaterialStatus> MaterialStatus { get; set; }
		public virtual DbSet<Program> MaterialType { get; set; }
		public virtual DbSet<ProgramBranchMapping> MaterialTypesMarketMapping { get; set; }
		public virtual DbSet<MeasureCompCalcs> MeasureCompCalcData { get; set; }
		public virtual DbSet<MeasureCompCustomers> MeasureCompCustData { get; set; }
		public virtual DbSet<MeasureCompLineItem> MeasureCompLineItemData { get; set; }
		public virtual DbSet<MeasureCompOrder> MeasureCompOrderData { get; set; }
		public virtual DbSet<MeasureError> MeasureError { get; set; }
		public virtual DbSet<MillError> MillError { get; set; }
		public virtual DbSet<NoteType> NoteTypes { get; set; }
		public virtual DbSet<OldCarpet> OldCarpet { get; set; }
		public virtual DbSet<OptionCost> OptionCost { get; set; }
		public virtual DbSet<OptionPrice> OptionPrice { get; set; }
		public virtual DbSet<OptionPricingOld> OptionPricingOld { get; set; }
		public virtual DbSet<OptionRetail> OptionRetail { get; set; }
		public virtual DbSet<Option> Options { get; set; }
		public virtual DbSet<OrderBasicLaborDetail> OrderBasicLaborDetails { get; set; }
		public virtual DbSet<OrderCustomDetail> OrderCustomDetails { get; set; }
		public virtual DbSet<OrderDiagram> OrderDiagrams { get; set; }
		public virtual DbSet<OrderDocument> OrderDocument { get; set; }
		public virtual DbSet<OrderOption> OrderOptionss { get; set; }
		public virtual DbSet<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
		public virtual DbSet<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<OrdersDeleted> OrdersDeleted { get; set; }
		public virtual DbSet<Payroll> Payroll { get; set; }
		public virtual DbSet<PayrollMessages> PayrollMessages { get; set; }
		public virtual DbSet<PermissionType> PermissionType { get; set; }
		public virtual DbSet<Permission> Permissions { get; set; }
		public virtual DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }
		public virtual DbSet<PONote> Ponotes { get; set; }
		public virtual DbSet<POPhoto> Pophotos { get; set; }
		public virtual DbSet<PostatusValues> PostatusValues { get; set; }
		public virtual DbSet<PrintedPodata> PrintedPodata { get; set; }
		public virtual DbSet<ProgramReport> ProgramReport { get; set; }
		public virtual DbSet<ReportType> ReportType { get; set; }
		public virtual DbSet<ScheduleChangeReasonCodes> ScheduleChangeReasonCodes { get; set; }
		public virtual DbSet<Setting> Settings { get; set; }
		public virtual DbSet<Sodocument> Sodocument { get; set; }
		public virtual DbSet<SosidocumentTypes> SosidocumentTypes { get; set; }
		public virtual DbSet<SosioutgoingDocuments> SosioutgoingDocuments { get; set; }
		public virtual DbSet<SosischeduleWillCallDocuments> SosischeduleWillCallDocuments { get; set; }
		public virtual DbSet<SosisentDocuments> SosisentDocuments { get; set; }
		public virtual DbSet<SPNActionQueue> SpnactionQueue { get; set; }
		public virtual DbSet<SPNActionType> Spnactions { get; set; }
		public virtual DbSet<SpnimportedPos> SpnimportedPos { get; set; }
		public virtual DbSet<SpokeWith> SpokeWith { get; set; }
		public virtual DbSet<States> States { get; set; }
		public virtual DbSet<ClientContact> StoreContacts { get; set; }
		public virtual DbSet<StoreError> StoreError { get; set; }
		public virtual DbSet<ClientType> StoreType { get; set; }
		public virtual DbSet<Client> Stores { get; set; }
		public virtual DbSet<SubContractor> SubContractors { get; set; }
		public virtual DbSet<SubContractorsDivisionAssignments> SubContractorsDivisionAssignments { get; set; }
		public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
		public virtual DbSet<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
		public virtual DbSet<UserPermissions> UserPermissions { get; set; }
		public virtual DbSet<UserTaskType> UserTaskTypes { get; set; }
		public virtual DbSet<UserTask> UserTasks { get; set; }
		public virtual DbSet<VendorNumbers> VendorNumbers { get; set; }
		public virtual DbSet<Domain.Version> Version { get; set; }
		public virtual DbSet<VOC> Voc { get; set; }
		public virtual DbSet<Weeks> Weeks { get; set; }
		public virtual DbSet<WorkOrder> WorkOrder { get; set; }
		public virtual DbSet<WorkOrderDocument> WorkOrderDocument { get; set; }
		public virtual DbSet<WorkOrderEmails> WorkOrderEmails { get; set; }
		public virtual DbSet<Xmlsources> Xmlsources { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer("Server=RANDR-LAP-01\\SQLEXPRESS;Database=IMCore;Trusted_Connection=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1");

			modelBuilder.Entity<ActionQueue>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<ActionReport>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.HasOne(d => d.Order)
					.WithMany(p => p.ActionReports)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_ActionReport_Orders");
			});

			modelBuilder.Entity<ActivityData>(entity =>
			{
				entity.HasOne(d => d.Activity)
					.WithMany(p => p.ActivityData)
					.HasForeignKey(d => d.ActivityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActivityData_ActivityList");
			});

			modelBuilder.Entity<Activity>(entity =>
			{
				entity.Property(e => e.ClosedById).HasDefaultValueSql("(null)");

				entity.Property(e => e.ClosedDate).HasDefaultValueSql("(null)");

				entity.Property(e => e.OrderId).HasDefaultValueSql("((-1))");

				entity.HasOne(d => d.ActivityType)
					.WithMany(p => p.ActivityList)
					.HasForeignKey(d => d.ActivityTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActivityList_ActivityTypes");

				entity.HasOne(d => d.CreatedBy)
					.WithMany(p => p.ActivityListCreatedBy)
					.HasForeignKey(d => d.CreatedById)
					.HasConstraintName("FK_ActivityList_Employees");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.ActivityList)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActivityList_Orders");
			});

			modelBuilder.Entity<ActivityPonoteMapping>(entity =>
			{
				entity.HasKey(e => new { e.ActivityId, e.PonoteId });

				entity.HasOne(d => d.Activity)
					.WithMany(p => p.ActivityPonoteMapping)
					.HasForeignKey(d => d.ActivityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActivityPONoteMapping_ActivityList");

				entity.HasOne(d => d.Ponote)
					.WithMany(p => p.ActivityPonoteMapping)
					.HasForeignKey(d => d.PonoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ActivityPONoteMapping_PONotes");
			});

			modelBuilder.Entity<ActivityTypes>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<Address>(entity =>
			{
				entity.Property(e => e.PhoneNumber1).IsFixedLength();

				entity.Property(e => e.PhoneNumber2).IsFixedLength();

				entity.Property(e => e.State).IsFixedLength();

				entity.Property(e => e.ZipCode).IsFixedLength();
			});

			modelBuilder.Entity<Admin>(entity =>
			{
				entity.Property(e => e.EmployeeId).ValueGeneratedNever();

				entity.HasOne(d => d.Employee)
					.WithOne(p => p.Admins)
					.HasForeignKey<Admin>(d => d.EmployeeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Admins_Employees");
			});

			modelBuilder.Entity<BasicCost>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_BasicCost_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_BasicCost_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_BasicCost_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Costs)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_BasicCost_Market");
			});

			modelBuilder.Entity<BasicLabor>(entity =>
			{
				entity.Property(e => e.PrintOnWorkOrder).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.BasicLabor)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_BasicLabor_Item");

				entity.HasOne(d => d.MaterialType)
					.WithMany(p => p.BasicLabor)
					.HasForeignKey(d => d.MaterialTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasicLabor_MaterialType");

				entity.HasOne(d => d.UnitOfMeasure)
					.WithMany(p => p.BasicLabor)
					.HasForeignKey(d => d.UnitOfMeasureId)
					.HasConstraintName("FK_BasicLabor_UnitOfMeasure");
			});

			modelBuilder.Entity<BasicPrice>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_BasicPrice_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_BasicPrice_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_BasicPrice_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Prices)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_BasicPrice_Market");

				entity.HasOne(d => d.Labor)
					.WithMany(p => p.Prices)
					.HasForeignKey(d => d.LaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasicPrice_Labor");
			});

			modelBuilder.Entity<BasicPricingOld>(entity =>
			{
				entity.HasKey(e => e.Id)
					.HasName("PK_BasicPricing");

				entity.HasOne(d => d.BasicLabor)
					.WithMany(p => p.BasicPricingOld)
					.HasForeignKey(d => d.BasicLaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasicPricing_BasicLabor");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.BasicPricingOld)
					.HasForeignKey(d => d.MarketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasicPricing_Market");
			});

			modelBuilder.Entity<BasicRetail>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_BasicRetail_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_BasicRetail_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_BasicRetail_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.Retails)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_BasicRetail_Market");

				entity.HasOne(d => d.Labor)
					.WithMany(p => p.Retails)
					.HasForeignKey(d => d.LaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasicRetail_Labor");
			});

			modelBuilder.Entity<Bill>(entity =>
			{
				entity.HasOne(d => d.Owner)
					.WithMany(p => p.Bill)
					.HasForeignKey(d => d.OwnerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Bill_SubContractors");
			});

			modelBuilder.Entity<BillClassification>(entity =>
			{
				entity.Property(e => e.Description).IsFixedLength();
			});

			modelBuilder.Entity<BillDetail>(entity =>
			{
				entity.HasIndex(e => e.WorkOrderId)
					.HasName("AK_BillDetails_WorkOrderID")
					.IsUnique();

				entity.Property(e => e.Qbuid)
					.IsUnicode(false)
					.IsFixedLength();

				entity.HasOne(d => d.BackChargeOwner)
					.WithMany(p => p.BillDetails)
					.HasForeignKey(d => d.BackChargeOwnerId)
					.HasConstraintName("FK_BillDetails_InstallationCrew");

				entity.HasOne(d => d.Bill)
					.WithMany(p => p.BillDetails)
					.HasForeignKey(d => d.BillId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BillDetails_Bill");

				entity.HasOne(d => d.ChargeBack)
					.WithMany(p => p.BillDetails)
					.HasForeignKey(d => d.ChargeBackId)
					.HasConstraintName("FK_BillDetails_ChargeBacks");

				entity.HasOne(d => d.WorkOrder)
					.WithOne(p => p.BillDetails)
					.HasForeignKey<BillDetail>(d => d.WorkOrderId)
					.HasConstraintName("FK_BillDetails_WorkOrders");
			});

			modelBuilder.Entity<Calls>(entity =>
			{
				entity.HasIndex(e => e.OrderId)
					.HasName("IX_CallsOrderID");

				entity.Property(e => e.Schedule).HasDefaultValueSql("(0)");

				entity.Property(e => e.Unscheduled).HasDefaultValueSql("(0)");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.Calls)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_Calls_Orders");
			});

			modelBuilder.Entity<Capacity>(entity =>
			{
				entity.Property(e => e.SendToHd).HasDefaultValueSql("(0)");
			});

			modelBuilder.Entity<CapacityPools>(entity =>
			{
				entity.Property(e => e.HdpoolId)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<ChargeBack>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.Amount).HasDefaultValueSql("(0)");

				entity.Property(e => e.AmountToSub).HasDefaultValueSql("(0)");

				entity.Property(e => e.ApprovalNumber).HasDefaultValueSql("(0)");

				entity.Property(e => e.Approved).HasDefaultValueSql("(1)");

				entity.Property(e => e.SubcontractorId).HasDefaultValueSql("(0)");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.ChargeBacks)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_ChargeBacks_Orders");
			});

			modelBuilder.Entity<CheckCBDetail>(entity =>
			{
				entity.HasOne(d => d.ChargeBack)
					.WithMany(p => p.CheckCBDetails)
					.HasForeignKey(d => d.ChargeBackId)
					.HasConstraintName("FK_CheckCBDetail_ChargeBacks");

				entity.HasOne(d => d.Check)
					.WithMany(p => p.CheckCBDetails)
					.HasForeignKey(d => d.CheckId)
					.HasConstraintName("FK_CheckCBDetail_Checks");
			});

			modelBuilder.Entity<CheckDetail>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.HasOne(d => d.Check)
					.WithMany(p => p.CheckDetails)
					.HasForeignKey(d => d.CheckId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CheckDetail_Checks");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.CheckDetail)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_CheckDetail_Orders");
			});

			modelBuilder.Entity<Checks>(entity =>
			{
				entity.Property(e => e.CheckNumber)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.VendorId).HasDefaultValueSql("(1)");
			});

			modelBuilder.Entity<ClientTypeReport>(entity =>
			{
				entity.HasOne(d => d.ClientType)
					.WithMany(p => p.ClientTypeReports)
					.HasForeignKey(d => d.ClientTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientTypeReports_ClientType");

				entity.HasOne(d => d.ReportType)
					.WithMany(p => p.ClientTypeReports)
					.HasForeignKey(d => d.ReportTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientTypeReports_ReportTypes");
			});

			modelBuilder.Entity<CompanyInfo>(entity =>
			{
				entity.Property(e => e.Address1).IsFixedLength();

				entity.Property(e => e.Address2).IsFixedLength();

				entity.Property(e => e.City).IsFixedLength();

				entity.Property(e => e.Fax1).IsFixedLength();

				entity.Property(e => e.Fax2).IsFixedLength();

				entity.Property(e => e.Name).IsFixedLength();

				entity.Property(e => e.Phone1).IsFixedLength();

				entity.Property(e => e.Phone2).IsFixedLength();

				entity.Property(e => e.QrcodePrefix)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.State).IsFixedLength();

				entity.Property(e => e.TollFree).IsFixedLength();

				entity.Property(e => e.VendorNumber).IsFixedLength();

				entity.Property(e => e.Zip).IsFixedLength();
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.HasIndex(e => new { e.FirstName, e.LastName })
					.HasName("CustomersFNameLName");

				entity.HasIndex(e => new { e.LastName, e.FirstName })
					.HasName("CustomersLNameFName");

				entity.HasIndex(e => new { e.Id, e.FirstName, e.LastName })
					.HasName("CustomersIDFNameLName");

				entity.Property(e => e.Extension).IsUnicode(false);

				entity.Property(e => e.MobileNumber).IsFixedLength();

				entity.Property(e => e.Name).HasComputedColumnSql("(case when [CompanyName] IS NULL then (isnull([LastName],'')+', ')+isnull([FirstName],'') else [CompanyName] end)");

				entity.Property(e => e.PhoneNumber).IsFixedLength();

				entity.Property(e => e.QbcustomerId).IsUnicode(false);

				entity.Property(e => e.State)
					.IsFixedLength()
					.HasDefaultValueSql("('GA')");

				entity.Property(e => e.WorkNumber).IsUnicode(false);

				entity.Property(e => e.ZipCode).IsFixedLength();

				entity.HasOne(d => d.AddressNavigation)
					.WithMany(p => p.Customers)
					.HasForeignKey(d => d.AddressId)
					.HasConstraintName("FK_Customers_Address");
			});

			modelBuilder.Entity<DepartmentsContactTitles>(entity =>
			{
				entity.HasKey(e => new { e.DepartmentsId, e.ContactTitlesId })
					.HasName("PK_DepartmentValidContactTitles");

				entity.HasOne(d => d.ContactTitles)
					.WithMany(p => p.DepartmentsContactTitles)
					.HasForeignKey(d => d.ContactTitlesId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DepartmentsContactTitles_ContactTitles");

				entity.HasOne(d => d.Departments)
					.WithMany(p => p.DepartmentsContactTitles)
					.HasForeignKey(d => d.DepartmentsId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DepartmentsContactTitles_Departments");
			});

			modelBuilder.Entity<DepartmentsStoresAssignments>(entity =>
			{
				entity.Property(e => e.AltFaxNumber).HasDefaultValueSql("('')");

				entity.Property(e => e.FaxStatusReportTo).HasDefaultValueSql("(0)");

				entity.HasOne(d => d.Department)
					.WithMany(p => p.DepartmentsStoresAssignments)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_DepartmentsStoresAssignments_Departments");

				entity.HasOne(d => d.Store)
					.WithMany(p => p.DepartmentsStoresAssignments)
					.HasForeignKey(d => d.StoreId)
					.HasConstraintName("FK_DepartmentsStoresAssignments_Stores");
			});

			modelBuilder.Entity<Discrepancy>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.DetailId).HasDefaultValueSql("(null)");

				entity.Property(e => e.Reviewed).HasDefaultValueSql("(0)");

				entity.Property(e => e.ReviewedById).HasDefaultValueSql("((-1))");

				entity.Property(e => e.XmlfilePath)
					.IsUnicode(false)
					.IsFixedLength();

				entity.HasOne(d => d.DiscrepancyType)
					.WithMany(p => p.Discrepancies)
					.HasForeignKey(d => d.DiscrepancyTypeId)
					.HasConstraintName("FK_Discrepancies_DiscrepancyType");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.Discrepancies)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_Discrepancies_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.Discrepancies)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_Discrepancies_Employees");
			});

			modelBuilder.Entity<DiscrepanciesPrice>(entity =>
			{
				entity.Property(e => e.CurrentPrice).HasDefaultValueSql("(0)");

				entity.Property(e => e.NewPrice).HasDefaultValueSql("(0)");

				entity.Property(e => e.XmlfilePath)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<Division>(entity =>
			{
				entity.Property(e => e.Active).HasDefaultValueSql("((1))");

				entity.Property(e => e.Name)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.DivisionGroupId).HasDefaultValueSql("(1)");

				entity.Property(e => e.MarkBilledWhenPaid).HasDefaultValueSql("(0)");

				entity.Property(e => e.PrintStatusReport).HasDefaultValueSql("(1)");

				entity.HasOne(d => d.DivisionGroup)
					.WithMany(p => p.Division)
					.HasForeignKey(d => d.DivisionGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Division_DivisionGroup");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.Property(e => e.Active).HasDefaultValueSql("(1)");

				entity.Property(e => e.State).IsFixedLength();
			});

			modelBuilder.Entity<EntryMethod>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<InstallCapacityGrid>(entity =>
			{
				entity.HasKey(e => new { e.RowType, e.WeekStart });
			});

			modelBuilder.Entity<InstallationCrew>(entity =>
			{
				entity.HasOne(d => d.Branch)
					.WithMany(p => p.InstallationCrew)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InstallationCrew_Branch");

				entity.HasOne(d => d.Lead)
					.WithMany(p => p.InstallationCrewLead)
					.HasForeignKey(d => d.LeadId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InstallationCrew_Lead");

				entity.HasOne(d => d.Owner)
					.WithMany(p => p.InstallationCrewOwner)
					.HasForeignKey(d => d.OwnerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InstallationCrew_Owner");
			});

			modelBuilder.Entity<InstallationCrewType>(entity =>
			{
				entity.HasKey(e => new { e.Id, e.JobTypeId });

				entity.HasOne(d => d.Crew)
					.WithMany(p => p.InstallationCrewType)
					.HasForeignKey(d => d.Id)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InstallationCrewType_InstallationCrew");

				entity.HasOne(d => d.JobType)
					.WithMany(p => p.InstallationCrewType)
					.HasForeignKey(d => d.JobTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InstallationCrewType_JobType");
			});

			modelBuilder.Entity<InstallerError>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<Item>(entity =>
			{
				entity.HasOne(d => d.UnitOfMeasure)
					.WithMany(p => p.Item)
					.HasForeignKey(d => d.UnitOfMeasureId)
					.HasConstraintName("FK_Item_UnitOfMeasure");
			});

			modelBuilder.Entity<ItemCosting>(entity =>
			{
				entity.HasIndex(e => e.ItemId)
					.HasName("IX_ItemCosting_Labor");

				entity.HasIndex(e => e.MarketId)
					.HasName("IX_ItemCosting_Branch");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_ItemCosting_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Division)
					.WithMany(p => p.ItemCosting)
					.HasForeignKey(d => d.DivisionId)
					.HasConstraintName("FK_ItemCosting_Division");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.Costs)
					.HasForeignKey(d => d.ItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ItemCosting_Item");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.ItemCosting)
					.HasForeignKey(d => d.MarketId)
					.HasConstraintName("FK_ItemCosting_Market");
			});

			modelBuilder.Entity<ItemMatCosting>(entity =>
			{
				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.ItemMatCosting)
					.HasForeignKey(d => d.ItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ItemMatCosting_Item");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.ItemMatCosting)
					.HasForeignKey(d => d.MarketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ItemMatCosting_Market");
			});

			modelBuilder.Entity<ItemPricing>(entity =>
			{
				entity.HasIndex(e => e.ItemId)
					.HasName("IX_ItemPricing_Labor");

				entity.HasIndex(e => e.MarketId)
					.HasName("IX_ItemPricing_Branch");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_ItemPricing_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.Prices)
					.HasForeignKey(d => d.ItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ItemPricing_Item");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.ItemPricing)
					.HasForeignKey(d => d.MarketId)
					.HasConstraintName("FK_ItemPricing_Market");
			});

			modelBuilder.Entity<Jobs>(entity =>
			{
				entity.HasOne(d => d.AssignedTo)
					.WithMany(p => p.JobsAssignedTo)
					.HasForeignKey(d => d.AssignedToId)
					.HasConstraintName("FK_Job_AssignedTo");

				entity.HasOne(d => d.CreatedBy)
					.WithMany(p => p.JobsCreatedBy)
					.HasForeignKey(d => d.CreatedById)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Job_CreatedBy");

				entity.HasOne(d => d.JobStatus)
					.WithMany(p => p.Jobs)
					.HasForeignKey(d => d.JobStatusId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Jobs_JobStatus");

				entity.HasOne(d => d.PrimaryOrder)
					.WithMany(p => p.Jobs)
					.HasForeignKey(d => d.PrimaryOrderId)
					.HasConstraintName("FK_Jobs_Orders");
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.Property(e => e.Location1).ValueGeneratedNever();

				entity.Property(e => e.Text).IsUnicode(false);
			});

			modelBuilder.Entity<Market>(entity =>
			{
				entity.Property(e => e.Active).HasDefaultValueSql("((1))");

				entity.Property(e => e.FaxNumber).IsFixedLength();

				entity.Property(e => e.PhoneNumber).IsFixedLength();

				entity.Property(e => e.State).IsFixedLength();

				entity.Property(e => e.ZipCode).IsFixedLength();

				entity.HasOne(d => d.Manager)
					.WithMany(p => p.Market)
					.HasForeignKey(d => d.ManagerId)
					.HasConstraintName("FK_Branch_Manager");
			});

			modelBuilder.Entity<MaterialSubCategory>(entity =>
			{
				entity.Property(e => e.Description).IsUnicode(false);
			});

			modelBuilder.Entity<Material>(entity =>
			{
				entity.Property(e => e.Active).HasDefaultValueSql("((1))");

				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.Furnish).HasDefaultValueSql("('false')");

				entity.HasOne(d => d.SubCat)
					.WithMany(p => p.MaterialCatagory)
					.HasForeignKey(d => d.SubCatId)
					.HasConstraintName("FK_Material Catagory_MatSubCat");

				entity.HasOne(d => d.UnitOfMeasure)
					.WithMany(p => p.MaterialCatagory)
					.HasForeignKey(d => d.UnitOfMeasureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Material Catagory_UnitOfMeasure");
			});

			modelBuilder.Entity<MaterialCategoryBasicLaborMappings>(entity =>
			{
				entity.HasKey(e => new { e.MaterialCategoryId, e.BasicLaborId });

				entity.HasOne(d => d.BasicLabor)
					.WithMany(p => p.MaterialCategoryBasicLaborMappings)
					.HasForeignKey(d => d.BasicLaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialCategoryBasicLaborMappings_BasicLabor");

				entity.HasOne(d => d.MaterialCategory)
					.WithMany(p => p.MaterialCategoryBasicLaborMappings)
					.HasForeignKey(d => d.MaterialCategoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialCategoryBasicLaborMappings_MaterialCategory");
			});

			modelBuilder.Entity<MaterialCategoryItemMappings>(entity =>
			{
				entity.HasKey(e => new { e.MaterialCategoryId, e.ItemId });

				entity.HasOne(d => d.Item)
					.WithMany(p => p.MaterialCategoryItemMappings)
					.HasForeignKey(d => d.ItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterilCategoryItemMappings_Item");

				entity.HasOne(d => d.MaterialCategory)
					.WithMany(p => p.MaterialCategoryItemMappings)
					.HasForeignKey(d => d.MaterialCategoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterilCategoryItemMappings_MaterialCategory");
			});

			modelBuilder.Entity<MaterialCategoryOptionsMappings>(entity =>
			{
				entity.HasKey(e => new { e.MaterialCategoryId, e.OptionId });

				entity.HasOne(d => d.MaterialCategory)
					.WithMany(p => p.MaterialCategoryOptionsMappings)
					.HasForeignKey(d => d.MaterialCategoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialCategoryOptionsMappings_MaterialCategory");

				entity.HasOne(d => d.Option)
					.WithMany(p => p.MaterialCategoryOptionsMappings)
					.HasForeignKey(d => d.OptionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialCategoryOptionsMappings_Options");
			});

			modelBuilder.Entity<MaterialCost>(entity =>
			{
				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.MaterialCost)
					.HasForeignKey(d => d.MarketId)
					.HasConstraintName("FK_MaterialCost_Market");

				entity.HasOne(d => d.MaterialCat)
					.WithMany(p => p.MaterialCost)
					.HasForeignKey(d => d.MaterialCatId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialCost_Material Catagory");

				entity.HasOne(d => d.Program)
					.WithMany(p => p.MaterialCost)
					.HasForeignKey(d => d.ProgramId)
					.HasConstraintName("FK_MaterialCost_Program");
			});

			modelBuilder.Entity<MaterialPrice>(entity =>
			{
				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.MaterialPrice)
					.HasForeignKey(d => d.MarketId)
					.HasConstraintName("FK_MaterialPrice_Market");

				entity.HasOne(d => d.MaterialCat)
					.WithMany(p => p.MaterialPrice)
					.HasForeignKey(d => d.MaterialCatId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialPrice_Material Catagory");

				entity.HasOne(d => d.Program)
					.WithMany(p => p.MaterialPrice)
					.HasForeignKey(d => d.ProgramId)
					.HasConstraintName("FK_MaterialPrice_MaterialType");
			});

			modelBuilder.Entity<Program>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.CostMultiplier).HasDefaultValueSql("((0.5))");

				entity.Property(e => e.CustomCostByRetail).HasDefaultValueSql("((1))");

				entity.Property(e => e.Hdtype)
					.IsFixedLength()
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MaterialTypeName)
					.IsUnicode(false)
					.HasComputedColumnSql("(((case when [HDType]='I' then 'INSTALL: ' else 'MEASURE: ' end+[SKU])+' ')+[SKUDesc])");

				entity.Property(e => e.ShortName).IsUnicode(false);

				entity.Property(e => e.Sku)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Skudesc)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.TripChargeMultiplier).HasDefaultValueSql("((0.999))");

				entity.Property(e => e.Valid).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Division)
					.WithMany(p => p.MaterialType)
					.HasForeignKey(d => d.DivisionId)
					.HasConstraintName("FK_MaterialType_Division");

				entity.HasOne(d => d.JobType)
					.WithMany(p => p.MaterialType)
					.HasForeignKey(d => d.JobTypeId)
					.HasConstraintName("FK_MaterialType_JobType");

				entity.HasOne(d => d.StoreType)
					.WithMany(p => p.MaterialType)
					.HasForeignKey(d => d.StoreTypeId)
					.HasConstraintName("FK_MaterialType_StoreType");
			});

			modelBuilder.Entity<ProgramBranchMapping>(entity =>
			{
				entity.HasKey(e => new { e.MaterialTypeId, e.MarketId });

				entity.HasOne(d => d.Market)
					.WithMany(p => p.MaterialTypesMarketMapping)
					.HasForeignKey(d => d.MarketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialTypesMarketMapping_Market");

				entity.HasOne(d => d.MaterialType)
					.WithMany(p => p.MaterialTypesMarketMapping)
					.HasForeignKey(d => d.MaterialTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaterialTypesMarketMapping_MaterialType");
			});

			modelBuilder.Entity<MeasureCompCalcs>(entity =>
			{
				entity.HasOne(d => d.Order)
					.WithMany(p => p.MeasureCompCalcData)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MeasureCompCalcData_Orders");
			});

			modelBuilder.Entity<MeasureCompCustomers>(entity =>
			{
				entity.Property(e => e.Address1).IsUnicode(false);

				entity.Property(e => e.Address2).IsUnicode(false);

				entity.Property(e => e.BusinessPhone).IsUnicode(false);

				entity.Property(e => e.CellPhone).IsUnicode(false);

				entity.Property(e => e.City).IsUnicode(false);

				entity.Property(e => e.CrossStreet1).IsUnicode(false);

				entity.Property(e => e.CrossStreet2).IsUnicode(false);

				entity.Property(e => e.CrossStreetDir1).IsUnicode(false);

				entity.Property(e => e.CrossStreetDir2).IsUnicode(false);

				entity.Property(e => e.EmailAddress).IsUnicode(false);

				entity.Property(e => e.FirstName).IsUnicode(false);

				entity.Property(e => e.HomePhone).IsUnicode(false);

				entity.Property(e => e.LastName).IsUnicode(false);

				entity.Property(e => e.Pager).IsUnicode(false);

				entity.Property(e => e.State).IsUnicode(false);

				entity.Property(e => e.Zip).IsUnicode(false);

				entity.HasOne(d => d.Customer)
					.WithMany(p => p.MeasureCompCustData)
					.HasForeignKey(d => d.CustomerId)
					.HasConstraintName("FK_MeasureCompCustData_Customers");
			});

			modelBuilder.Entity<MeasureCompLineItem>(entity =>
			{
				entity.Property(e => e.MaterialAmount).IsUnicode(false);

				entity.Property(e => e.MaterialDescription).IsUnicode(false);

				entity.Property(e => e.MaterialType).IsUnicode(false);

				entity.Property(e => e.PatternMatch).IsUnicode(false);

				entity.HasOne(d => d.Calc)
					.WithMany(p => p.MeasureCompLineItem)
					.HasForeignKey(d => d.CalcId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MeasureCompLineItemData_MeasureCompCalcData");
			});

			modelBuilder.Entity<MeasureCompOrder>(entity =>
			{
				entity.Property(e => e.Access)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.Disposal)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.MetalColor)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.SiteType)
					.IsUnicode(false)
					.IsFixedLength();

				entity.HasOne(d => d.Order)
					.WithMany(p => p.MeasureCompOrderData)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MeasureCompOrderData_Orders");
			});

			modelBuilder.Entity<MeasureError>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<MillError>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<NoteType>(entity =>
			{
				entity.Property(e => e.PermissionRequiredToSelect).HasDefaultValueSql("(0)");

				entity.Property(e => e.ShowStoreManagement).HasDefaultValueSql("(0)");
			});

			modelBuilder.Entity<OldCarpet>(entity =>
			{
				entity.Property(e => e.Comments).IsUnicode(false);

				entity.Property(e => e.Name).IsUnicode(false);

				entity.Property(e => e.PoNumberOriginal).IsUnicode(false);

				entity.Property(e => e.PoNumberReplacement).IsUnicode(false);

				entity.Property(e => e.SoNumber).IsUnicode(false);

				entity.Property(e => e.Store).IsUnicode(false);
			});

			modelBuilder.Entity<OptionCost>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_OptionCost_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_OptionCost_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_OptionCost_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.OptionCost)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_OptionCost_Market");

				entity.HasOne(d => d.Labor)
					.WithMany(p => p.Costs)
					.HasForeignKey(d => d.LaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OptionCost_Labor");
			});

			modelBuilder.Entity<OptionPrice>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_OptionPrice_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_OptionPrice_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_OptionPrice_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.OptionPrice)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_OptionPrice_Market");

				entity.HasOne(d => d.Labor)
					.WithMany(p => p.Prices)
					.HasForeignKey(d => d.LaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OptionPrice_Labor");
			});

			modelBuilder.Entity<OptionPricingOld>(entity =>
			{
				entity.HasOne(d => d.Market)
					.WithMany(p => p.OptionPricingOld)
					.HasForeignKey(d => d.MarketId)
					.HasConstraintName("FK_OptionPricing_Market");

				entity.HasOne(d => d.Option)
					.WithMany(p => p.OptionPricingOld)
					.HasForeignKey(d => d.OptionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OptionPricing_Options");
			});

			modelBuilder.Entity<OptionRetail>(entity =>
			{
				entity.HasIndex(e => e.BranchId)
					.HasName("IX_OptionRetail_Branch");

				entity.HasIndex(e => e.LaborId)
					.HasName("IX_OptionRetail_Labor");

				entity.HasIndex(e => e.StoreId)
					.HasName("IX_OptionRetail_Store");

				entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.Branch)
					.WithMany(p => p.OptionRetail)
					.HasForeignKey(d => d.BranchId)
					.HasConstraintName("FK_OptionRetail_Market");

				entity.HasOne(d => d.Labor)
					.WithMany(p => p.Retails)
					.HasForeignKey(d => d.LaborId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OptionRetail_Labor");
			});

			modelBuilder.Entity<Option>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.Active).HasDefaultValueSql("((1))");

				entity.Property(e => e.ApplyToMinimum).HasDefaultValueSql("((0))");

				entity.Property(e => e.PrintOnInvoice).HasDefaultValueSql("((1))");

				entity.Property(e => e.PrintOnWorkOrder).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.Item)
					.WithMany(p => p.Options)
					.HasForeignKey(d => d.ItemId)
					.HasConstraintName("FK_Options_Item");

				entity.HasOne(d => d.MaterialType)
					.WithMany(p => p.Options)
					.HasForeignKey(d => d.MaterialTypeId)
					.HasConstraintName("FK_Options_MaterialType");

				entity.HasOne(d => d.UnitOfMeasure)
					.WithMany(p => p.Options)
					.HasForeignKey(d => d.UnitOfMeasureId)
					.HasConstraintName("FK_Options_UnitOfMeasure");
			});

			modelBuilder.Entity<OrderBasicLaborDetail>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.EntryMethodId).HasDefaultValueSql("((1))");

				entity.Property(e => e.ExtendedCost).HasComputedColumnSql("(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[InstallQuantity] else (0) end,(0.0)))");

				entity.Property(e => e.ExtendedPrice).HasComputedColumnSql("(isnull(case when [PrintOnInvoice]='1' then [UnitPrice]*[InstallQuantity] else (0) end,(0.0)))");

				entity.Property(e => e.PrintOnInvoice).HasDefaultValueSql("((1))");

				entity.Property(e => e.PrintOnWorkOrder).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.OrderBasicLaborDetails)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderBasicLaborDetail_EntryMethod");

				entity.HasOne(d => d.MaterialStatus)
					.WithMany(p => p.OrderBasicLaborDetails)
					.HasForeignKey(d => d.MaterialStatusId)
					.HasConstraintName("FK_OrderBasicLaborDetail_MaterialStatus");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrderBasicLaborDetails)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_OrderBasicLaborDetail_ReviewedBy");
			});

			modelBuilder.Entity<OrderCustomDetail>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);

				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.Deleted).HasDefaultValueSql("(0)");

				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.EntryMethodId).HasDefaultValueSql("(1)");

				entity.Property(e => e.ExtendedCost).HasComputedColumnSql("(isnull(case when [NotOnWorkOrder]='0' then [UnitCost]*[Quanity] else (0) end,(0.0)))");

				entity.Property(e => e.ExtendedPrice).HasComputedColumnSql("(isnull(case when [NotOnInvoice]='0' then [UnitPrice]*[Quanity] else (0) end,(0.0)))");

				entity.Property(e => e.NotOnInvoice).HasDefaultValueSql("(0)");

				entity.Property(e => e.NotOnWorkOrder).HasDefaultValueSql("(0)");

				entity.Property(e => e.PrintOnInvoice).HasComputedColumnSql("(isnull(CONVERT([bit],case when [NotOnInvoice]=(1) then (0) else (1) end),(0)))");

				entity.Property(e => e.PrintOnWorkOrder).HasComputedColumnSql("(isnull(CONVERT([bit],case when [NotOnWorkOrder]=(1) then (0) else (1) end),(0)))");

				entity.Property(e => e.Reviewed).HasDefaultValueSql("(0)");

				entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.OrderCustomDetails)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderCustomDetails_EntryMethod");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.CustomLabors)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_OrderCustomDetails_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrderCustomDetails)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_OrderCustomDetails_Employees");

				entity.HasOne(d => d.SubContractor)
					.WithMany(p => p.OrderCustomDetails)
					.HasForeignKey(d => d.SubContractorId)
					.HasConstraintName("FK_OrderCustomDetails_SubContractor");

				entity.HasOne(d => d.UnitOfMeasure)
					.WithMany(p => p.OrderCustomDetails)
					.HasForeignKey(d => d.UnitOfMeasureId)
					.HasConstraintName("FK_OrderCustomDetails_UnitOfMeasure");
			});

			modelBuilder.Entity<OrderDiagram>(entity =>
			{
				entity.Property(e => e.DiagramFileName).IsUnicode(false);

				entity.Property(e => e.DiagramNumber).IsUnicode(false);

				entity.HasOne(d => d.Order)
					.WithMany(p => p.OrderDiagrams)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderDiagrams_Orders");
			});

			modelBuilder.Entity<OrderDocument>(entity =>
			{
				entity.HasKey(e => new { e.OrderId, e.DocumentId });

				entity.HasOne(d => d.Document)
					.WithMany(p => p.OrderDocument)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderDocument_Document");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.OrderDocument)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderDocument_Order");
			});

			modelBuilder.Entity<OrderOption>(entity =>
			{
				entity.HasKey(e => e.OrdeOptionslId)
					.ForSqlServerIsClustered(false);

				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.EntryMethodId).HasDefaultValueSql("((1))");

				entity.Property(e => e.ExtendedCost).HasComputedColumnSql("(isnull(case when [PrintOnWorkOrder]='1' then [UnitCost]*[Quantity] else (0) end,(0.0)))");

				entity.Property(e => e.ExtendedPrice).HasComputedColumnSql("(isnull(case when [PrintOnInvoice]='1' then [UnitPrice]*[Quantity] else (0) end,(0.0)))");

				entity.Property(e => e.PrintOnInvoice).HasDefaultValueSql("((1))");

				entity.Property(e => e.PrintOnWorkOrder).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.OrderOptionsDetails)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderOptionsDetails_EntryMethod");

				entity.HasOne(d => d.Option)
					.WithMany(p => p.OrderOptionsDetails)
					.HasForeignKey(d => d.OptionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Order Options Details_Options");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.OptionalLabors)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_Order Options Details_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrderOptionsDetails)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_OrderOptionsDetails_Employees");
			});

			modelBuilder.Entity<OrderRegMerchandiseDetail>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.Notes).IsUnicode(false);

				entity.Property(e => e.ShortDescription).IsUnicode(false);

				entity.Property(e => e.Skunumber).IsUnicode(false);

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.OrderRegMerchandiseDetails)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderRegMerchandiseDetails_EntryMethod");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.RegMerchandises)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_OrderRegMerchandiseDetails_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrderRegMerchandiseDetails)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_OrderRegMerchandiseDetails_ReviewedBy");

				entity.HasOne(d => d.MaterialStatus)
					.WithMany(p => p.OrderRegMerchandiseDetails)
					.HasForeignKey(d => d.StatusId)
					.HasConstraintName("FK_OrderRegMerchandiseDetails_Material Status");

				entity.HasOne(d => d.Uom)
					.WithMany(p => p.OrderRegMerchandiseDetails)
					.HasForeignKey(d => d.Uomid)
					.HasConstraintName("FK_OrderRegMerchandiseDetails_UnitOfMeasure");
			});

			modelBuilder.Entity<OrderSOMerchandiseDetail>(entity =>
			{
				entity.HasIndex(e => e.OrderId);

				entity.HasIndex(e => e.SONumber)
					.HasName("OrderSOMerchandiseDetailsSONumber");

				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.EntryMethodId).HasDefaultValueSql("((1))");

				entity.Property(e => e.MaterialStatusId).HasDefaultValueSql("((16))");

				entity.Property(e => e.OriginalId).HasDefaultValueSql("((-1))");

				entity.Property(e => e.ShortDescription).IsUnicode(false);

				entity.Property(e => e.SKUNumber).IsUnicode(false);

				entity.Property(e => e.SONumber).IsUnicode(false);

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.OrderSomerchandiseDetails)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderSOMerchandiseDetails_EntryMethod");

				entity.HasOne(d => d.MaterialStatus)
					.WithMany(p => p.OrderSomerchandiseDetails)
					.HasForeignKey(d => d.MaterialStatusId)
					.HasConstraintName("FK_OrderSOMerchandiseDetails_Material Status");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.SOMerchandises)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_OrderSOMerchandiseDetails_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrderSomerchandiseDetails)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_OrderSOMerchandiseDetails_ReviewedBy");

				entity.HasOne(d => d.Uom)
					.WithMany(p => p.OrderSomerchandiseDetails)
					.HasForeignKey(d => d.Uomid)
					.HasConstraintName("FK_OrderSOMerchandiseDetails_UnitOfMeasure");
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasIndex(e => e.CustomerId);

				entity.HasIndex(e => e.JobId)
					.HasName("IX_Orders_Job");

				entity.HasIndex(e => e.PurchaseOrderNumber)
					.HasName("OrdersPO");

				entity.HasIndex(e => e.StoreId);

				entity.Property(e => e.EntryMethodId).HasDefaultValueSql("((1))");

				entity.Property(e => e.FollowUpAction).IsUnicode(false);

				entity.Property(e => e.Notes).IsUnicode(false);

				entity.Property(e => e.NUMBER)
					.IsUnicode(false)
					.HasComputedColumnSql("(case when [Estimate]='1' OR len([PurchaseOrderNumber])<>(8) OR [PurchaseOrderNumber] IS NULL then str([OrderID]) else [PurchaseOrderNumber] end)");

				entity.Property(e => e.OrderNo)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.OriginalPo)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.PurchaseOrderNumber)
					.IsUnicode(false)
					.IsFixedLength();

				entity.HasOne(d => d.Address)
					.WithMany(p => p.Orders)
					.HasForeignKey(d => d.AddressId)
					.HasConstraintName("FK_Orders_Address");

				entity.HasOne(d => d.AssignedTo)
					.WithMany(p => p.OrdersAssignedTo)
					.HasForeignKey(d => d.AssignedToId)
					.HasConstraintName("FK_Orders_AssignedTo");

				entity.HasOne(d => d.Customer)
					.WithMany(p => p.Orders)
					.HasForeignKey(d => d.CustomerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Orders_Customers");

				entity.HasOne(d => d.EnteredBy)
					.WithMany(p => p.OrdersEnteredBy)
					.HasForeignKey(d => d.EnteredById)
					.HasConstraintName("FK_Orders_EnteredBy");

				entity.HasOne(d => d.EntryMethod)
					.WithMany(p => p.Orders)
					.HasForeignKey(d => d.EntryMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Orders_EntryMethod");

				entity.HasOne(d => d.JobStatus)
					.WithMany(p => p.Orders)
					.HasForeignKey(d => d.JobStatusId)
					.HasConstraintName("FK_Orders_JobStatus");

				entity.HasOne(d => d.Program)
					.WithMany(p => p.Orders)
					.HasForeignKey(d => d.MaterialTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Orders_MaterialType");

				entity.HasOne(d => d.PrimaryOrder)
					.WithMany(p => p.AssociatedOrders)
					.HasForeignKey(d => d.PrimaryOrderId)
					.HasConstraintName("FK_Orders_Orders");

				entity.HasOne(d => d.ReviewedBy)
					.WithMany(p => p.OrdersReviewedBy)
					.HasForeignKey(d => d.ReviewedById)
					.HasConstraintName("FK_Orders_ReviewedBy");

				entity.HasOne(d => d.SalesPerson)
					.WithMany(p => p.OrdersSalesPerson)
					.HasForeignKey(d => d.SalesPersonId)
					.HasConstraintName("FK_Orders_SalesPerson");
			});

			modelBuilder.Entity<OrdersDeleted>(entity =>
			{
				entity.Property(e => e.FollowUpAction).IsUnicode(false);

				entity.Property(e => e.OrderNo)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.OriginalPo)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.PurchaseOrderNumber)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<Payroll>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.HasOne(d => d.Order)
					.WithMany(p => p.Payroll)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_Payroll_Orders");

				entity.HasOne(d => d.SubContractor)
					.WithMany(p => p.Payroll)
					.HasForeignKey(d => d.SubContractorId)
					.HasConstraintName("FK_Payroll_SubContractors");
			});

			modelBuilder.Entity<Permission>(entity =>
			{
				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.PermissionName).IsUnicode(false);

				entity.Property(e => e.PermissionTypeId).HasDefaultValueSql("(1)");

				entity.HasOne(d => d.PermissionType)
					.WithMany(p => p.Permissions)
					.HasForeignKey(d => d.PermissionTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Permissions_ToTable");
			});

			modelBuilder.Entity<PONote>(entity =>
			{
				entity.HasIndex(e => e.NoteTypeId);

				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.ContactName).IsUnicode(false);

				entity.Property(e => e.NoteText).IsUnicode(false);

				entity.HasOne(d => d.EnteredByUser)
					.WithMany(p => p.Ponotes)
					.HasForeignKey(d => d.EnteredByUserId)
					.HasConstraintName("FK_PONote_EnteredBy");

				entity.HasOne(d => d.NoteType)
					.WithMany(p => p.Ponotes)
					.HasForeignKey(d => d.NoteTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PONotes_NoteTypes");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.PONotes)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PONotes_Orders");
			});

			modelBuilder.Entity<POPhoto>(entity =>
			{
				entity.HasOne(d => d.Order)
					.WithMany(p => p.Pophotos)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_POPhotos_Orders");
			});

			modelBuilder.Entity<PrintedPodata>(entity =>
			{
				entity.Property(e => e.Ponumber)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.Printed).HasDefaultValueSql("(0)");
			});

			modelBuilder.Entity<ProgramReport>(entity =>
			{
				entity.HasOne(d => d.Program)
					.WithMany(p => p.ProgramReport)
					.HasForeignKey(d => d.ProgramId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ProgramReport_Program");

				entity.HasOne(d => d.ReportType)
					.WithMany(p => p.ProgramReport)
					.HasForeignKey(d => d.ReportTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ProgramReport_ReportTypes");
			});

			modelBuilder.Entity<Setting>(entity =>
			{
				entity.HasIndex(e => e.UserId);
			});

			modelBuilder.Entity<Sodocument>(entity =>
			{
				entity.HasKey(e => new { e.Soid, e.DocumentId });

				entity.HasOne(d => d.Document)
					.WithMany(p => p.Sodocument)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SODocument_Document");

				entity.HasOne(d => d.So)
					.WithMany(p => p.Sodocument)
					.HasForeignKey(d => d.Soid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SODocument_Order");
			});

			modelBuilder.Entity<SosioutgoingDocuments>(entity =>
			{
				entity.Property(e => e.SendAfter).HasDefaultValueSql("(null)");
			});

			modelBuilder.Entity<SosischeduleWillCallDocuments>(entity =>
			{
				entity.Property(e => e.Scheduled).HasDefaultValueSql("(0)");
			});

			modelBuilder.Entity<SPNActionQueue>(entity =>
			{
				entity.Property(e => e.Processed).HasDefaultValueSql("(1)");

				entity.HasOne(d => d.Action)
					.WithMany(p => p.SpnactionQueue)
					.HasForeignKey(d => d.ActionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SPNActionQueue_SPNActions");
			});

			modelBuilder.Entity<SPNActionType>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<SpnimportedPos>(entity =>
			{
				entity.Property(e => e.Ponumber)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.XmlfilePath)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<SpokeWith>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.DisplayOrder).HasDefaultValueSql("(0)");

				entity.Property(e => e.EnableSchedulingInfo).HasDefaultValueSql("(0)");

				entity.Property(e => e.ShowAlways).HasDefaultValueSql("(0)");

				entity.Property(e => e.SwText).IsUnicode(false);
			});

			modelBuilder.Entity<States>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<ClientContact>(entity =>
			{
				entity.HasOne(d => d.Department)
					.WithMany(p => p.StoreContacts)
					.HasForeignKey(d => d.DepartmentId)
					.HasConstraintName("FK_StoreContacts_Departments");

				entity.HasOne(d => d.Store)
					.WithMany(p => p.StoreContacts)
					.HasForeignKey(d => d.StoreId)
					.HasConstraintName("FK_StoreContacts_Stores");
			});

			modelBuilder.Entity<StoreError>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsUnicode(false)
					.IsFixedLength();
			});

			modelBuilder.Entity<ClientType>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);
			});

			modelBuilder.Entity<Client>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.Active).HasDefaultValueSql("((1))");

				entity.Property(e => e.IncludeInStatusReportAll).HasDefaultValueSql("((1))");

				entity.Property(e => e.XmlsourceId).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.AccountCoor)
					.WithMany(p => p.StoresAccountCoor)
					.HasForeignKey(d => d.AccountCoorId)
					.HasConstraintName("FK_Stores_AccountCoor");

				entity.HasOne(d => d.AccountRep)
					.WithMany(p => p.StoresAccountRep)
					.HasForeignKey(d => d.AccountRepId)
					.HasConstraintName("FK_Stores_AccountRep");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.Stores)
					.HasForeignKey(d => d.BranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Stores_Market");

				entity.HasOne(d => d.StoreType)
					.WithMany(p => p.Stores)
					.HasForeignKey(d => d.StoreTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Stores_StoreType");
			});

			modelBuilder.Entity<SubContractor>(entity =>
			{
				entity.HasKey(e => e.SubContractorId)
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.BackgroundRptRequested).HasDefaultValueSql("(0)");

				entity.Property(e => e.BadgeStatus).HasDefaultValueSql("(null)");

				entity.Property(e => e.Helper).HasDefaultValueSql("(0)");

				entity.Property(e => e.InsuranceDollarAmount).HasDefaultValueSql("(0.0)");

				entity.Property(e => e.InsuranceRate).HasDefaultValueSql("(0.0)");

				entity.Property(e => e.LiabilityInsuranceOk).HasDefaultValueSql("(0)");

				entity.Property(e => e.MarketId).HasDefaultValueSql("(1)");

				entity.Property(e => e.Name).HasComputedColumnSql("((isnull([LastName],'')+', ')+isnull([FirstName],''))");

				entity.Property(e => e.QbsubContractorId).IsUnicode(false);

				entity.Property(e => e.RetainageRate).HasDefaultValueSql("(0.1)");

				entity.Property(e => e.SavingsRate).HasDefaultValueSql("(0)");

				entity.Property(e => e.StateId).HasDefaultValueSql("((-1))");

				entity.Property(e => e.Status).HasDefaultValueSql("(1)");

				entity.Property(e => e.WorkmansCompInsuranceOk).HasDefaultValueSql("(0)");
			});

			modelBuilder.Entity<SubContractorsDivisionAssignments>(entity =>
			{
				entity.Property(e => e.SubDivisionId).HasDefaultValueSql("((-1))");
			});

			modelBuilder.Entity<UnitOfMeasure>(entity =>
			{
				entity.HasKey(e => e.Id)
					.ForSqlServerIsClustered(false);
			});

			modelBuilder.Entity<UserMarketDivisionAssignments>(entity =>
			{
				entity.HasOne(d => d.Division)
					.WithMany(p => p.UserMarketDivisionAssignments)
					.HasForeignKey(d => d.DivisionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserMarketDivisionAssignments_Division");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.UserMarketDivisionAssignments)
					.HasForeignKey(d => d.MarketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserMarketDivisionAssignments_Market");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserMarketDivisionAssignments)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserMarketDivisionAssignments_Employees");
			});

			modelBuilder.Entity<UserPermissions>(entity =>
			{
				entity.HasOne(d => d.Division)
					.WithMany(p => p.UserPermissions)
					.HasForeignKey(d => d.DivisionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPermissions_Division");

				entity.HasOne(d => d.Market)
					.WithMany(p => p.UserPermissions)
					.HasForeignKey(d => d.MarketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPermissions_Market");

				entity.HasOne(d => d.Permission)
					.WithMany(p => p.UserPermissions)
					.HasForeignKey(d => d.PermissionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPermissions_Permissions");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserPermissions)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPermissions_Employees");
			});

			modelBuilder.Entity<UserTask>(entity =>
			{
				entity.Property(e => e.OrderId).HasDefaultValueSql("((0))");

				entity.HasOne(d => d.AddedBy)
					.WithMany(p => p.UserTasksAddedBy)
					.HasForeignKey(d => d.AddedById)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserTasks_AddedBy");

				entity.HasOne(d => d.AssignedTo)
					.WithMany(p => p.UserTasksAssignedTo)
					.HasForeignKey(d => d.AssignedToId)
					.HasConstraintName("FK_UserTasks_AssignedTo");

				entity.HasOne(d => d.CompletedBy)
					.WithMany(p => p.UserTasksCompletedBy)
					.HasForeignKey(d => d.CompletedById)
					.HasConstraintName("FK_UserTasks_CompletedBy");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.UserTasks)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_UserTasks_Orders");

				entity.HasOne(d => d.UserTaskType)
					.WithMany(p => p.UserTasks)
					.HasForeignKey(d => d.UserTaskTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserTasks_UserTaskTypes");
			});

			modelBuilder.Entity<Domain.Version>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();
			});

			modelBuilder.Entity<VOC>(entity =>
			{
				entity.Property(e => e.DivisionName).IsUnicode(false);

				entity.Property(e => e.FinalComments).IsUnicode(false);

				entity.Property(e => e.GeneralComment).IsUnicode(false);

				entity.Property(e => e.InstallerOtherComments).IsUnicode(false);

				entity.Property(e => e.IssueOther).IsUnicode(false);

				entity.Property(e => e.MarketName).IsUnicode(false);

				entity.Property(e => e.MvendorName).IsUnicode(false);

				entity.Property(e => e.ProjectName).IsUnicode(false);

				entity.Property(e => e.PvendorName).IsUnicode(false);

				entity.Property(e => e.RegionName).IsUnicode(false);

				entity.HasOne(d => d.Order)
					.WithMany(p => p.Voc)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_VOC_Orders");
			});

			modelBuilder.Entity<Weeks>(entity =>
			{
				entity.Property(e => e.Weeks1).ValueGeneratedNever();
			});

			modelBuilder.Entity<WorkOrder>(entity =>
			{
				entity.HasIndex(e => e.CrewId)
					.HasName("WorkOrder_Crew");

				entity.HasIndex(e => e.ScheduleStartDate)
					.HasName("WorkOrder_StartDate");

				entity.HasOne(d => d.Crew)
					.WithMany(p => p.WorkOrder)
					.HasForeignKey(d => d.CrewId)
					.HasConstraintName("FK_WorkOrder_Crews");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.WorkOrders)
					.HasForeignKey(d => d.OrderId)
					.HasConstraintName("FK_WorkOrder_Orders");
			});

			modelBuilder.Entity<WorkOrderDocument>(entity =>
			{
				entity.HasKey(e => new { e.WorkOrderId, e.DocumentId });

				entity.HasOne(d => d.Document)
					.WithMany(p => p.WorkOrderDocument)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WorkOrderDocument_Document");

				entity.HasOne(d => d.WorkOrder)
					.WithMany(p => p.WorkOrderDocument)
					.HasForeignKey(d => d.WorkOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WorkOrderDocument_WorkOrder");
			});

			modelBuilder.Entity<WorkOrderEmails>(entity =>
			{
				entity.HasKey(e => new { e.WorkOrderId, e.EmailType })
					.HasName("PK__WorkOrde__CBC1E3941E45FB72");

				entity.HasOne(d => d.WorkOrder)
					.WithMany(p => p.WorkOrderEmails)
					.HasForeignKey(d => d.WorkOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WorkOrderEmails_ToTable");
			});

			modelBuilder.Entity<Xmlsources>(entity =>
			{
				entity.Property(e => e.DownloadSource)
					.IsUnicode(false)
					.IsFixedLength();
			});


		}
	}
}
