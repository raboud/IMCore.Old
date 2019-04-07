using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Orders
    {
        public Orders()
        {
            ActionReport = new HashSet<ActionReport>();
            ActivityList = new HashSet<ActivityList>();
            Calls = new HashSet<Calls>();
            ChargeBacks = new HashSet<ChargeBacks>();
            CheckDetail = new HashSet<CheckDetail>();
            Discrepancies = new HashSet<Discrepancies>();
            InversePrimaryOrder = new HashSet<Orders>();
            Jobs = new HashSet<Jobs>();
            MeasureCompCalcData = new HashSet<MeasureCompCalcData>();
            MeasureCompOrderData = new HashSet<MeasureCompOrderData>();
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetails>();
            OrderCustomDetails = new HashSet<OrderCustomDetails>();
            OrderDiagrams = new HashSet<OrderDiagrams>();
            OrderDocument = new HashSet<OrderDocument>();
            OrderOptionsDetails = new HashSet<OrderOptionsDetails>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetails>();
            OrderSomerchandiseDetails = new HashSet<OrderSomerchandiseDetails>();
            Payroll = new HashSet<Payroll>();
            Ponotes = new HashSet<Ponotes>();
            Pophotos = new HashSet<Pophotos>();
            UserTasks = new HashSet<UserTasks>();
            Voc = new HashSet<Voc>();
            WorkOrder = new HashSet<WorkOrder>();
        }

        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("CustomerID")]
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
        [Column("MaterialTypeID")]
        public int MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal TripCharge { get; set; }
        [Column(TypeName = "money")]
        public decimal RetailAmount { get; set; }
        public bool NoMinimum { get; set; }
        [Column("ScheduledAM")]
        public bool ScheduledAm { get; set; }
        public bool Cancelled { get; set; }
        public bool Warrenty { get; set; }
        [Column("StoreID")]
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
        [Column("EnteredByID")]
        public int? EnteredById { get; set; }
        [Column("EntryMethodID")]
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
        [Column("ReviewedByID")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        [Column("VendorID")]
        public int? VendorId { get; set; }
        [StringLength(30)]
        public string CustomerOrderNumber { get; set; }
        [Column("CorrelationID")]
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
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }
        public bool Estimate { get; set; }
        [Column("NUMBER")]
        [StringLength(10)]
        public string Number { get; set; }
        [Column("AddressID")]
        public int? AddressId { get; set; }
        [Column("JobID")]
        public int? JobId { get; set; }
        public int? MarkDown { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? JobSize { get; set; }
        [Column("JobStatusID")]
        public int? JobStatusId { get; set; }
        [Column("AssignedToID")]
        public int? AssignedToId { get; set; }
        [Column("PrimaryOrderID")]
        public int? PrimaryOrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDateTime { get; set; }
        [Column("CreatedByID")]
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
        public virtual Employees AssignedTo { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Orders")]
        public virtual Customers Customer { get; set; }
        [ForeignKey("EnteredById")]
        [InverseProperty("OrdersEnteredBy")]
        public virtual Employees EnteredBy { get; set; }
        [ForeignKey("EntryMethodId")]
        [InverseProperty("Orders")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("JobStatusId")]
        [InverseProperty("Orders")]
        public virtual JobStatus JobStatus { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("Orders")]
        public virtual MaterialType MaterialType { get; set; }
        [ForeignKey("PrimaryOrderId")]
        [InverseProperty("InversePrimaryOrder")]
        public virtual Orders PrimaryOrder { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrdersReviewedBy")]
        public virtual Employees ReviewedBy { get; set; }
        [ForeignKey("SalesPersonId")]
        [InverseProperty("OrdersSalesPerson")]
        public virtual Employees SalesPerson { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<ActionReport> ActionReport { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<ActivityList> ActivityList { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Calls> Calls { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<ChargeBacks> ChargeBacks { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<CheckDetail> CheckDetail { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Discrepancies> Discrepancies { get; set; }
        [InverseProperty("PrimaryOrder")]
        public virtual ICollection<Orders> InversePrimaryOrder { get; set; }
        [InverseProperty("PrimaryOrder")]
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<MeasureCompCalcData> MeasureCompCalcData { get; set; }
        public virtual ICollection<MeasureCompOrderData> MeasureCompOrderData { get; set; }
        public virtual ICollection<OrderBasicLaborDetails> OrderBasicLaborDetails { get; set; }
        public virtual ICollection<OrderCustomDetails> OrderCustomDetails { get; set; }
        public virtual ICollection<OrderDiagrams> OrderDiagrams { get; set; }
        public virtual ICollection<OrderDocument> OrderDocument { get; set; }
        public virtual ICollection<OrderOptionsDetails> OrderOptionsDetails { get; set; }
        public virtual ICollection<OrderRegMerchandiseDetails> OrderRegMerchandiseDetails { get; set; }
        public virtual ICollection<OrderSomerchandiseDetails> OrderSomerchandiseDetails { get; set; }
        public virtual ICollection<Payroll> Payroll { get; set; }
        public virtual ICollection<Ponotes> Ponotes { get; set; }
        public virtual ICollection<Pophotos> Pophotos { get; set; }
        public virtual ICollection<UserTasks> UserTasks { get; set; }
        public virtual ICollection<Voc> Voc { get; set; }
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
