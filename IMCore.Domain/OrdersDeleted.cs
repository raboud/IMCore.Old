using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OrdersDeleted
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int? OrderId { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Required]
        [StringLength(8)]
        public string PurchaseOrderNumber { get; set; }
        [Column(TypeName = "text")]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BilledDate { get; set; }
        public bool Scheduled { get; set; }
        public bool Billed { get; set; }
        public bool Paid { get; set; }
        public bool Called { get; set; }
        [Column(TypeName = "text")]
        public string InternalNotes { get; set; }
        [Column(TypeName = "money")]
        public decimal? CostAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? BilledAmount { get; set; }
        [Column("MaterialTypeID")]
        public int MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? OrderAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? TripCharge { get; set; }
        public bool? NoMinimum { get; set; }
        [Column("ScheduledAM")]
        public bool? ScheduledAm { get; set; }
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
        [StringLength(10)]
        public string OrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
        public int? EnteredBy { get; set; }
        [Column("EntryMethodID")]
        public int EntryMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FollowUpDate { get; set; }
        [StringLength(1024)]
        public string FollowUpAction { get; set; }
        public int? ServiceLineNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        public int? DeletedBy { get; set; }
    }
}
