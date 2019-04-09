using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("OrderRegMerchandise")]
    public partial class OrderRegMerchandise
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
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
        [Column("StatusId")]
        public int? StatusId { get; set; }
        public bool Deleted { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        public int? TransferredTo { get; set; }
        public int? TransferredFrom { get; set; }
        [Column("XMLStatusId")]
        public int? XmlstatusId { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        [Column("OriginalOrderId")]
        public int? OriginalOrderId { get; set; }

        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("RegMerchandises")]
        public virtual Order Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual User ReviewedBy { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual MaterialStatus MaterialStatus { get; set; }
        [ForeignKey("Uomid")]
        [InverseProperty("OrderRegMerchandiseDetails")]
        public virtual UnitOfMeasure Uom { get; set; }
    }
}
