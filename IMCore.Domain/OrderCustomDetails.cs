using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OrderCustomDetails
    {
        [Key]
        [Column("OrderCustomId")]
        public int OrderCustomId { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("SubContractorId")]
        public int? SubContractorId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? RetailPrice { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Quanity { get; set; }
        [Column("UnitOfMeasureId")]
        public int? UnitOfMeasureId { get; set; }
        public bool? NotOnInvoice { get; set; }
        public bool? NotOnWorkOrder { get; set; }
        public bool? SubContractorPaid { get; set; }
        public double? SubContractorPay { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        public int? CustomItemNumber { get; set; }
        [Required]
        public bool? Deleted { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }
        [Required]
        public bool? Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        public bool PrintOnWorkOrder { get; set; }
        public bool PrintOnInvoice { get; set; }
        [Column(TypeName = "decimal(37, 8)")]
        public decimal ExtendedPrice { get; set; }
        [Column(TypeName = "decimal(37, 8)")]
        public decimal ExtendedCost { get; set; }

        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderCustomDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OrderCustomDetails")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderCustomDetails")]
        public virtual Employees ReviewedBy { get; set; }
        [ForeignKey("SubContractorId")]
        [InverseProperty("OrderCustomDetails")]
        public virtual SubContractors SubContractor { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("OrderCustomDetails")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
