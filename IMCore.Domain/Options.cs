using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Options
    {
        public Options()
        {
            MaterialCategoryOptionsMappings = new HashSet<MaterialCategoryOptionsMappings>();
            OptionCost = new HashSet<OptionCost>();
            OptionPrice = new HashSet<OptionPrice>();
            OptionPricingOld = new HashSet<OptionPricingOld>();
            OptionRetail = new HashSet<OptionRetail>();
            OrderOptionsDetails = new HashSet<OrderOptionsDetails>();
        }

        [Key]
        [Column("OptionID")]
        public int OptionId { get; set; }
        [StringLength(255)]
        public string OptionDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitCost { get; set; }
        [Column("UnitOfMeasureID")]
        public int? UnitOfMeasureId { get; set; }
        [Column("MaterialTypeID")]
        public int? MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }
        public bool? ApplyToMinimum { get; set; }
        public bool? PrintOnInvoice { get; set; }
        public bool? PrintOnWorkOrder { get; set; }
        [Required]
        public bool? Active { get; set; }
        [Column("ApplyToMinimumWO")]
        public bool? ApplyToMinimumWo { get; set; }
        [Column("ItemID")]
        public int? ItemId { get; set; }
        public bool? Size { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("Options")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("Options")]
        public virtual MaterialType MaterialType { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("Options")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<MaterialCategoryOptionsMappings> MaterialCategoryOptionsMappings { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionCost> OptionCost { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionPrice> OptionPrice { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<OptionPricingOld> OptionPricingOld { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionRetail> OptionRetail { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<OrderOptionsDetails> OrderOptionsDetails { get; set; }
    }
}
