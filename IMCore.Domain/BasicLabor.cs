using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BasicLabor
    {
        public BasicLabor()
        {
            BasicCost = new HashSet<BasicCost>();
            BasicPrice = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            BasicRetail = new HashSet<BasicRetail>();
            MaterialCategoryBasicLaborMappings = new HashSet<MaterialCategoryBasicLaborMappings>();
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetails>();
        }

        [Column("UnitOfMeasureID")]
        public int? UnitOfMeasureId { get; set; }
        [Column("BasicLaborID")]
        public int BasicLaborId { get; set; }
        [StringLength(255)]
        public string LaborDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitCost { get; set; }
        [Column("MaterialTypeID")]
        public int MaterialTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }
        public bool Active { get; set; }
        [Column("PrintOnWO")]
        public bool? PrintOnWo { get; set; }
        [Column("ItemID")]
        public int? ItemId { get; set; }
        public bool? Size { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("BasicLabor")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("BasicLabor")]
        public virtual MaterialType MaterialType { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("BasicLabor")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<BasicCost> BasicCost { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<BasicPrice> BasicPrice { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        [InverseProperty("Labor")]
        public virtual ICollection<BasicRetail> BasicRetail { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<MaterialCategoryBasicLaborMappings> MaterialCategoryBasicLaborMappings { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<OrderBasicLaborDetails> OrderBasicLaborDetails { get; set; }
    }
}
