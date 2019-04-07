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
        [Column("PrintOnWorkOrder")]
        public bool? PrintOnWorkOrder { get; set; }
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
        public virtual ICollection<BasicCost> BasicCost { get; set; }
        public virtual ICollection<BasicPrice> BasicPrice { get; set; }
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        public virtual ICollection<BasicRetail> BasicRetail { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<MaterialCategoryBasicLaborMappings> MaterialCategoryBasicLaborMappings { get; set; }
    }
}
