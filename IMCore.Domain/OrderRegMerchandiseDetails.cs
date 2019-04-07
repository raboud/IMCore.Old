using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OrderRegMerchandiseDetails
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("SKUNumber")]
        [StringLength(12)]
        public string Skunumber { get; set; }
        [StringLength(100)]
        public string ShortDescription { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Quantity { get; set; }
        [Column("UOMId")]
        public int? Uomid { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Retail { get; set; }
        [Column("HDLineNumber")]
        public int? HdlineNumber { get; set; }
        [StringLength(1024)]
        public string Notes { get; set; }
        [Column("StatusID")]
        public int? StatusId { get; set; }
        public bool Deleted { get; set; }
        [Column("EntryMethodID")]
        public int EntryMethodId { get; set; }
        public int? TransferredTo { get; set; }
        public int? TransferredFrom { get; set; }
        [Column("XMLStatusID")]
        public int? XmlstatusId { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedByID")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        [Column("OriginalOrderID")]
        public int? OriginalOrderId { get; set; }

        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual Employees ReviewedBy { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual MaterialStatus Status { get; set; }
        [ForeignKey("Uomid")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual UnitOfMeasure Uom { get; set; }
    }
}
