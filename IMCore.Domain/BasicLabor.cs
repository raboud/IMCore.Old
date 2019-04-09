using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IMCore.Domain
{
    public partial class BasicLabor
    {
        public BasicLabor()
        {
            Costs = new HashSet<BasicCost>();
            Prices = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            Retails = new HashSet<BasicRetail>();
            MaterialBasicLaborMappings = new HashSet<MaterialBasicLaborMapping>();
        }

        [Column("UnitOfMeasureId")]
        public int? UnitOfMeasureId { get; set; }
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(255)]
        public string LaborDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitCost { get; set; }
        [Column("ProgramId")]
        public int ProgramId { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }
        public bool Active { get; set; }
        [Column("PrintOnWorkOrder")]
        public bool? PrintOnWorkOrder { get; set; }
        [Column("ItemId")]
        public int? ItemId { get; set; }
        public bool? Size { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("BasicLabor")]
        public virtual Item Item { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("BasicLabor")]
        public virtual Program Program { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("BasicLabor")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<BasicCost> Costs { get; set; }
        public virtual ICollection<BasicPrice> Prices { get; set; }
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        public virtual ICollection<BasicRetail> Retails { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<MaterialBasicLaborMapping> MaterialBasicLaborMappings { get; set; }


		[NotMapped]
		public ReadOnlyCollection<Material> Materials => this.MaterialBasicLaborMappings.Select(m => m.Material).ToList().AsReadOnly();
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
