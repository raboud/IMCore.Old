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
            Costs = new HashSet<BasicCost>();
            Prices = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            Retails = new HashSet<BasicRetail>();
            MaterialCategoryBasicLaborMappings = new HashSet<MaterialCategoryBasicLaborMappings>();
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
        [Column("MaterialTypeId")]
        public int MaterialTypeId { get; set; }
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
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("BasicLabor")]
        public virtual Program MaterialType { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("BasicLabor")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<BasicCost> Costs { get; set; }
        public virtual ICollection<BasicPrice> Prices { get; set; }
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        public virtual ICollection<BasicRetail> Retails { get; set; }
        [InverseProperty("BasicLabor")]
        public virtual ICollection<MaterialCategoryBasicLaborMappings> MaterialCategoryBasicLaborMappings { get; set; }
    }
}
