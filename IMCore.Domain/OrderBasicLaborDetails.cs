using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("OrderBasicLaborDetails")]
    public partial class OrderBasicLaborDetail
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("BasicLaborId")]
        public int BasicLaborId { get; set; }
        [Column("InstallQuantity", TypeName = "decimal(18, 4)")]
		public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitRetail { get; set; }
        [Required]
        public bool? PrintOnInvoice { get; set; }
        [Required]
        [Column("PrintOnWorkOrder")]
        public bool? PrintOnWorkOrder { get; set; }
        public int? ServiceLineNumber { get; set; }
        [Column("MaterialStatusId")]
        public int? MaterialStatusId { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        public bool Deleted { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        [Column(TypeName = "money")]
        public decimal MaterialCost { get; set; }
        [Column(TypeName = "decimal(37, 8)")]
        public decimal ExtendedPrice { get; set; }
        [Column(TypeName = "decimal(37, 8)")]
        public decimal ExtendedCost { get; set; }

        [ForeignKey("BasicLaborId")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("EntryMethodId")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("MaterialStatusId")]
        public virtual MaterialStatus MaterialStatus { get; set; }
        [ForeignKey("ReviewedById")]
        public virtual User ReviewedBy { get; set; }
    }
}
