using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IMCore.Domain
{
	[Table("Orders")]
    public partial class Order
    {
        public Order()
        {
            ActionReports = new HashSet<ActionReport>();
            ActivityList = new HashSet<Activity>();
            Calls = new HashSet<Calls>();
            ChargeBacks = new HashSet<ChargeBack>();
            CheckDetail = new HashSet<CheckDetail>();
            Discrepancies = new HashSet<Discrepancy>();
            AssociatedOrders = new HashSet<Order>();
            Jobs = new HashSet<Jobs>();
            MeasureCompCalcData = new HashSet<MeasureCompCalcs>();
            MeasureCompOrderData = new HashSet<MeasureCompOrder>();
            BasicLabors = new HashSet<OrderBasicLabor>();
            CustomLabors = new HashSet<OrderCustomDetail>();
            OrderDiagrams = new HashSet<OrderDiagram>();
            OrderDocument = new HashSet<OrderDocument>();
			OptionalLabors = new HashSet<OrderOption>();
            RegMerchandises = new HashSet<OrderRegMerchandiseDetail>();
            SOMerchandises = new HashSet<OrderSOMerchandiseDetail>();
            Payroll = new HashSet<Payroll>();
            PONotes = new HashSet<PONote>();
            Pophotos = new HashSet<POPhoto>();
            UserTasks = new HashSet<UserTask>();
            Voc = new HashSet<VOC>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(8)]
        public string PurchaseOrderNumber { get; set; }
        public string Notes { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScheduleStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BilledDate { get; set; }
        public bool Scheduled { get; set; }
        public bool Billed { get; set; }
        public bool Paid { get; set; }
        public bool Called { get; set; }
        [Column(TypeName = "text")]
        public string InternalNotes { get; set; }
        [Column(TypeName = "money")]
        public decimal CostAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal BilledAmount { get; set; }
        [Column("MaterialTypeId")]
        public int MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal TripCharge { get; set; }
        [Column(TypeName = "money")]
        public decimal RetailAmount { get; set; }
        public bool NoMinimum { get; set; }
        [Column("ScheduledAM")]
        public bool ScheduledAM { get; set; }
        public bool Cancelled { get; set; }
        public bool Warrenty { get; set; }
        [Column("StoreId")]
        public int StoreId { get; set; }
        public bool SevenDay { get; set; }
        [Column(TypeName = "text")]
        public string DrawingNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DrawingDate { get; set; }
        public bool CustomerToCall { get; set; }
        public bool Invoice { get; set; }
        [Column("OriginalPO")]
        [StringLength(8)]
        public string OriginalPo { get; set; }
        [StringLength(15)]
        public string OrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
        [Column("EnteredById")]
        public int? EnteredById { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FollowUpDate { get; set; }
        [StringLength(1024)]
        public string FollowUpAction { get; set; }
        public int? ServiceLineNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDateTime { get; set; }
        [Column("SPNNotes", TypeName = "text")]
        public string Spnnotes { get; set; }
        [Column("XMLOrderCostAmount")]
        public int XmlorderCostAmount { get; set; }
        public bool Deleted { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        [Column("VendorId")]
        public int? VendorId { get; set; }
        [StringLength(30)]
        public string CustomerOrderNumber { get; set; }
        [Column("CorrelationId")]
        [StringLength(255)]
        public string CorrelationId { get; set; }
        [StringLength(15)]
        public string KeyRecNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? KeyRecDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SvcCompleteSentDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScheduleEndDate { get; set; }
        [Column("SalesPersonId")]
        public int? SalesPersonId { get; set; }
        public bool Estimate { get; set; }
        [Column("NUMBER")]
        [StringLength(10)]
        public string NUMBER { get; set; }
        [Column("AddressId")]
        public int? AddressId { get; set; }
        [Column("JobId")]
        public int? JobId { get; set; }
        public int? MarkDown { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? JobSize { get; set; }
        [Column("JobStatusId")]
        public int? JobStatusId { get; set; }
        [Column("AssignedToId")]
        public int? AssignedToId { get; set; }
        [Column("PrimaryOrderId")]
        public int? PrimaryOrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDateTime { get; set; }
        [Column("CreatedById")]
        public int? CreatedById { get; set; }
        [Column(TypeName = "money")]
        public decimal? KeyRecAmount { get; set; }
        [Column("poStatusDesc")]
        [StringLength(50)]
        public string PoStatusDesc { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Orders")]
        public virtual Address Address { get; set; }
        [ForeignKey("AssignedToId")]
        [InverseProperty("OrdersAssignedTo")]
        public virtual User AssignedTo { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("EnteredById")]
        [InverseProperty("OrdersEnteredBy")]
        public virtual User EnteredBy { get; set; }
        [ForeignKey("EntryMethodId")]
        [InverseProperty("Orders")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("JobStatusId")]
        [InverseProperty("Orders")]
        public virtual JobStatus JobStatus { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("Orders")]
        public virtual Program Program { get; set; }
        [ForeignKey("PrimaryOrderId")]
        [InverseProperty("AssociatedOrders")]
        public virtual Order PrimaryOrder { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrdersReviewedBy")]
        public virtual User ReviewedBy { get; set; }
        [ForeignKey("SalesPersonId")]
        [InverseProperty("OrdersSalesPerson")]
        public virtual User SalesPerson { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<ActionReport> ActionReports { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Activity> ActivityList { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Calls> Calls { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<ChargeBack> ChargeBacks { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<CheckDetail> CheckDetail { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Discrepancy> Discrepancies { get; set; }
        public virtual ICollection<Order> AssociatedOrders { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<MeasureCompCalcs> MeasureCompCalcData { get; set; }
        public virtual ICollection<MeasureCompOrder> MeasureCompOrderData { get; set; }
        public virtual ICollection<OrderBasicLabor> BasicLabors { get; set; }
        public virtual ICollection<OrderCustomDetail> CustomLabors { get; set; }
        public virtual ICollection<OrderDiagram> OrderDiagrams { get; set; }
        public virtual ICollection<OrderDocument> OrderDocument { get; set; }
        public virtual ICollection<OrderOption> OptionalLabors { get; set; }
        public virtual ICollection<OrderRegMerchandiseDetail> RegMerchandises { get; set; }
        public virtual ICollection<OrderSOMerchandiseDetail> SOMerchandises { get; set; }
        public virtual ICollection<Payroll> Payroll { get; set; }
        public virtual ICollection<PONote> PONotes { get; set; }
        public virtual ICollection<POPhoto> Pophotos { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }
        public virtual ICollection<VOC> Voc { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

		[ForeignKey("StoreId")]
//		[InverseProperty("Orders")]
		public virtual Client Client { get; set; }
		public string FormatStoreAndPONumber()
		{
			return String.Format("{0} / {1}", this.Client.StoreNumber, this.NUMBER);
		}

		public bool HasAlerts()
		{
			bool hasAlerts = false;

			if (!hasAlerts && this.BasicLabors.Any(l => !l.Reviewed))
			{
				hasAlerts = true;
			}

			if (!hasAlerts && this.OptionalLabors.Any(l => !l.Reviewed))
			{
				hasAlerts = true;
			}

			if (!hasAlerts && this.CustomLabors.Any(l => !(l.Reviewed ?? false)))
			{
				hasAlerts = true;
			}

			if (!hasAlerts && this.SOMerchandises.Any(l => !l.Reviewed))
			{
				hasAlerts = true;
			}

			if (!hasAlerts && this.RegMerchandises.Any(l => !l.Reviewed))
			{
				hasAlerts = true;
			}

			if (!hasAlerts)
			{
				hasAlerts = this.Discrepancies != null && this.Discrepancies.Count > 0;
			}

			return hasAlerts;
		}

		[NotMapped]
		public decimal JobTotal
		{
			get
			{
				decimal t = 0.0M;

				t += (from b in this.BasicLabors
					  where
					  (!b.Deleted) &&
					  ((b.BasicLabor.Size != null && b.BasicLabor.Size.Value) || (b.BasicLabor.Size == null && b.BasicLabor.Item != null && b.BasicLabor.Item.JobSize))

					  select b.Quantity).Sum();

				t += (from b in this.OptionalLabors
					  where
					  (!b.Deleted) &&
					  ((b.Option.Size != null && b.Option.Size.Value) || (b.Option.Size == null && b.Option.Item != null && b.Option.Item.JobSize))
					  select b.Quantity).Sum();

				return t;
			}
		}


		[NotMapped]
		public decimal Total
		{
			get
			{
				decimal t = 0.0M;

				t += (from b in this.BasicLabors
					  where (
					  (!b.Deleted) &&
					  ((b.BasicLabor.Size != null && b.BasicLabor.Size.Value) || (b.BasicLabor.Size == null && b.BasicLabor.Item != null && b.BasicLabor.Item.Size)))
					  select b.Quantity).Sum();

				t += (from b in this.OptionalLabors
					  where (
					  (!b.Deleted) &&
					  ((b.Option.Size != null && b.Option.Size.Value) || (b.Option.Size == null && b.Option.Item != null && b.Option.Item.Size)))
					  select b.Quantity).Sum();

				return t;
			}
		}

		public bool RequiresWoodWaiver()
		{
			return this.Program.WoodWaiver;
		}

		public bool HasStorePickup()
		{
			bool bHasStorePickup = false;

			if (!bHasStorePickup)
			{
				foreach (OrderSOMerchandiseDetail somd in this.SOMerchandises)
				{
					if (!somd.Deleted && (somd.Quantity > 0) && (somd.MaterialStatus.Status == "STORE PICKUP"))
					{
						bHasStorePickup = true;
						break;
					}
				}
			}

			if (!bHasStorePickup)
			{
				foreach (OrderRegMerchandiseDetail romd in this.RegMerchandises)
				{
					if (!romd.Deleted && (romd.Quantity > 0) && (romd.MaterialStatus.Status == "STORE PICKUP"))
					{
						bHasStorePickup = true;
						break;
					}
				}
			}

			return bHasStorePickup;
		}
		public bool ValidForUser(User user)
		{
			bool valid = true;

			if (user.UserMarketDivisionAssignments.Count > 0)
			{
				valid = user.UserMarketDivisionAssignments.Any(u => u.DivisionId == this.Program.DivisionId && u.MarketId == this.Client.BranchId);
			}
			return valid;
		}

		public void GetTotalLabor(out decimal applyToMin, out decimal noMinApplied)
		{
			applyToMin = 0;
			noMinApplied = 0;
			foreach (OrderBasicLabor bl in this.BasicLabors)
			{
				if (bl.BasicLabor.PrintOnWorkOrder ?? true && !bl.Deleted)
				{
					applyToMin += bl.ExtendedCost;
				}
			}
			foreach (OrderCustomDetail cl in this.CustomLabors)
			{
				if (cl.PrintOnWorkOrder && !(cl.Deleted ?? false))
				{
					noMinApplied += cl.ExtendedCost;
				}
			}
			foreach (OrderOption ol in this.OptionalLabors)
			{
				if (ol.PrintOnWorkOrder ?? true && !ol.Deleted)
				{
					if (ol.Option.ApplyToMinimumWO ?? false)
					{
						applyToMin += ol.ExtendedCost;
					}
					else
					{
						noMinApplied += ol.ExtendedCost;
					}
				}
			}
		}


		[NotMapped]
		public decimal TotalLabor
		{
			get
			{
				decimal value = 0;
				decimal applyToMin = 0;
				decimal noMinApplied = 0;
				GetTotalLabor(out applyToMin, out noMinApplied);
				if ((Program != null) && ((Program.MinimumCost ?? 0) > applyToMin))
				{
					applyToMin = Program.MinimumCost.Value;
				}
				return value;
			}
		}
		[NotMapped]
		public string ScheduleInfo
		{
			get
			{
				string scheduleDateInfo = "";

				bool ScheduledForAM = this.ScheduledAM;

				if (this.ScheduleStartDate == null || !this.Scheduled)
				{
					scheduleDateInfo = "Not Scheduled";
				}
				else if (this.ScheduleEndDate == null || this.ScheduleStartDate.Value == this.ScheduleEndDate.Value)
				{
					scheduleDateInfo = String.Format("{0} {1}", (this.ScheduleStartDate.Value).ToString("MM/dd/yyyy"), (ScheduledForAM) ? "AM" : "PM");
				}
				else
				{
					scheduleDateInfo = String.Format("{0} ({2}) to {1}", this.ScheduleStartDate.Value.ToString("MM/dd/yyyy"), this.ScheduleEndDate.Value.ToString("MM/dd/yyyy"), (ScheduledForAM) ? "AM" : "PM");
				}

				return scheduleDateInfo;
			}
		}

	}
}
