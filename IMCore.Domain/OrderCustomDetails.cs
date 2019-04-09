using IMCore.TypesAndInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("OrderCustomDetails")]
    public partial class OrderCustomDetail
    {
        [Key]
        [Column("OrderCustomId")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("SubContractorId")]
        public int? SubContractorId { get; set; }
        [Column("RetailPrice", TypeName = "decimal(18, 4)")]
        public decimal? UnitRetail { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitCost { get; set; }
        [Column("Quanity", TypeName = "decimal(18, 4)")]
        public decimal Quantity { get; set; }
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
        [InverseProperty("CustomLabors")]
        public virtual Order Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderCustomDetails")]
        public virtual User ReviewedBy { get; set; }
        [ForeignKey("SubContractorId")]
        [InverseProperty("OrderCustomDetails")]
        public virtual SubContractor SubContractor { get; set; }
        [ForeignKey("UnitOfMeasureId")]
		[InverseProperty("OrderCustomDetails")]
		public virtual UnitOfMeasure UnitOfMeasure { get; set; }

		public void RefreshPrice()
		{
			if (this.EntryMethodId == SPNTypes.ENTRY_METHOD_MANUAL)
			{
				if (this.Order.MarkDown.HasValue)
				{
					this.UnitPrice = this.UnitRetail.Value * (100.0m - this.Order.MarkDown.Value) / 100.0m;
				}
				else
				{
					this.UnitPrice = (decimal)((this.Order.Program.CustomMultiplier ?? 0.0) * (this.Order.Program.CostMultiplier ?? 0.0)) * (this.UnitRetail ?? 0.0m);
				}
			}
			RefreshCost();
		}

		public void RefreshCost()
		{
			if (this.Order.Program.CustomCostByRetail ?? false)
			{
				this.UnitCost = (decimal)((this.Order.Program.CostMultiplier ?? 0.0)) * (this.UnitRetail ?? 0.0m);
			}
			else
			{
				this.UnitCost = (decimal)((this.Order.Program.CustomMultiplier ?? 0.0) * (this.Order.Program.CostMultiplier ?? 0.0)) * (this.UnitRetail ?? 0.0m);
			}
		}

	}
}
