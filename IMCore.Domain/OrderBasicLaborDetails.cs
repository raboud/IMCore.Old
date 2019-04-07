using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OrderBasicLaborDetails
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("BasicLaborID")]
        public int BasicLaborId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal InstallQuantity { get; set; }
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
        [Column("MaterialStatusID")]
        public int? MaterialStatusId { get; set; }
        [Column("EntryMethodID")]
        public int EntryMethodId { get; set; }
        public bool Deleted { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedByID")]
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
        [InverseProperty("OrderBasicLaborDetails")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderBasicLaborDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("MaterialStatusId")]
        [InverseProperty("OrderBasicLaborDetails")]
        public virtual MaterialStatus MaterialStatus { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OrderBasicLaborDetails")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderBasicLaborDetails")]
        public virtual Employees ReviewedBy { get; set; }
    }
}
