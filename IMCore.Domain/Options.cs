using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IMCore.Domain
{
	[Table("Options")]
    public partial class Option
    {
        public Option()
        {
            MaterialCategoryOptionsMappings = new HashSet<MaterialCategoryOptionsMappings>();
            Costs = new HashSet<OptionCost>();
            Prices = new HashSet<OptionPrice>();
            OptionPricingOld = new HashSet<OptionPricingOld>();
            Retails = new HashSet<OptionRetail>();
            OrderOptionsDetails = new HashSet<OrderOption>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(255)]
        public string OptionDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitCost { get; set; }
        [Column("UnitOfMeasureId")]
        public int? UnitOfMeasureId { get; set; }
        [Column("MaterialTypeId")]
        public int? MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }
        public bool? ApplyToMinimum { get; set; }
        public bool? PrintOnInvoice { get; set; }
        public bool? PrintOnWorkOrder { get; set; }
        [Required]
        public bool? Active { get; set; }
        [Column("ApplyToMinimumWO")]
        public bool? ApplyToMinimumWO { get; set; }
        [Column("ItemId")]
        public int? ItemId { get; set; }
        public bool? Size { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("Options")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("Options")]
        public virtual Program MaterialType { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("Options")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<MaterialCategoryOptionsMappings> MaterialCategoryOptionsMappings { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionCost> Costs { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionPrice> Prices { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<OptionPricingOld> OptionPricingOld { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<OptionRetail> Retails { get; set; }
        [InverseProperty("Option")]
        public virtual ICollection<OrderOption> OrderOptionsDetails { get; set; }

		[NotMapped]
		public ReadOnlyCollection<Material> Materials => this.MaterialCategoryOptionsMappings.Select(m => m.MaterialCategory).ToList().AsReadOnly();
		public void ClearMaterails() { }
		public ReadOnlyCollection<Material> Add(Material m)
		{
			return this.Materials;
		}
		public ReadOnlyCollection<Material> Remove(Material m)
		{
			return this.Materials;
		}
	}
}
