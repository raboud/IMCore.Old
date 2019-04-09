using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IMCore.Domain
{
    public partial class Item
    {
        public Item()
        {
            BasicLabor = new HashSet<BasicLabor>();
            Costs = new HashSet<ItemCosting>();
            ItemMatCosting = new HashSet<ItemMatCosting>();
            Prices = new HashSet<ItemPricing>();
            MaterialCategoryItemMappings = new HashSet<MaterialCategoryItemMappings>();
            Options = new HashSet<Option>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string WorkOrderDescription { get; set; }
        [Column("UnitOfMeasureId")]
        public int? UnitOfMeasureId { get; set; }
        public bool ApplyToMinimun { get; set; }
        public bool PrintOnWorkOrder { get; set; }
        public bool Active { get; set; }
        [Column("ApplyToMinimumWO")]
        public bool ApplyToMinimumWO { get; set; }
        public bool Size { get; set; }
        public bool JobSize { get; set; }

        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("Item")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<BasicLabor> BasicLabor { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemCosting> Costs { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemMatCosting> ItemMatCosting { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemPricing> Prices { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<MaterialCategoryItemMappings> MaterialCategoryItemMappings { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<Option> Options { get; set; }


		[NotMapped]
		public ReadOnlyCollection<Material> Materials => this.MaterialCategoryItemMappings.Select(m => m.MaterialCategory).ToList().AsReadOnly();
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
