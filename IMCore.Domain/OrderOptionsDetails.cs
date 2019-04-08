using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Order Options Details")]
    public partial class OrderOptionalLaborDetail
    {
        [Key]
        [Column("OrdeOptionslId")]
        public int OrdeOptionslId { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("OptionId")]
        public int OptionId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }
        [Column("SubContractorId")]
        public int? SubContractorId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitRetail { get; set; }
        public bool? SubContractorPaid { get; set; }
        public double? SubContractorPay { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        [Required]
        public bool? PrintOnInvoice { get; set; }
        [Required]
        [Column("PrintOnWorkOrder")]
        public bool? PrintOnWorkOrder { get; set; }
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

        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderOptionsDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("OptionId")]
        [InverseProperty("OrderOptionsDetails")]
        public virtual Option Option { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OptionalLabors")]
        public virtual Order Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderOptionsDetails")]
        public virtual User ReviewedBy { get; set; }
    }
}
