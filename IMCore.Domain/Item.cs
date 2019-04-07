using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Item
    {
        public Item()
        {
            BasicLabor = new HashSet<BasicLabor>();
            ItemCosting = new HashSet<ItemCosting>();
            ItemMatCosting = new HashSet<ItemMatCosting>();
            ItemPricing = new HashSet<ItemPricing>();
            MaterialCategoryItemMappings = new HashSet<MaterialCategoryItemMappings>();
            Options = new HashSet<Options>();
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
        public bool ApplyToMinimumWo { get; set; }
        public bool Size { get; set; }
        public bool JobSize { get; set; }

        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("Item")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<BasicLabor> BasicLabor { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemCosting> ItemCosting { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemMatCosting> ItemMatCosting { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemPricing> ItemPricing { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<MaterialCategoryItemMappings> MaterialCategoryItemMappings { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<Options> Options { get; set; }
    }
}
