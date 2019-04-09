using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Material")]
    public partial class Material
    {
        public Material()
        {
            MaterialBasicLaborMappings = new HashSet<MaterialBasicLaborMapping>();
            MaterialsItemMappings = new HashSet<MaterialsItemMapping>();
            MaterialOptionsMappings = new HashSet<MaterialsOptionsMapping>();
            MaterialCost = new HashSet<MaterialCost>();
            MaterialPrice = new HashSet<MaterialPrice>();
        }

        [Key]
        public int CatId { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public bool IsPadding { get; set; }
        public int? YardsPerRoll { get; set; }
        [Column("UnitOfMeasureId")]
        public int UnitOfMeasureId { get; set; }
        public int? SubCatId { get; set; }
        [StringLength(512)]
        public string Manufacturer { get; set; }
        [StringLength(256)]
        public string Color { get; set; }
        [StringLength(100)]
        public string Style { get; set; }
        [Column("SKU")]
        [StringLength(11)]
        public string Sku { get; set; }
        [Required]
        public bool? Furnish { get; set; }
        [Required]
        public bool? Active { get; set; }

        [ForeignKey("SubCatId")]
        [InverseProperty("Materials")]
        public virtual MaterialSubCategory SubCat { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("Materials")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("Material")]
        public virtual ICollection<MaterialBasicLaborMapping> MaterialBasicLaborMappings { get; set; }
        [InverseProperty("Material")]
        public virtual ICollection<MaterialsItemMapping> MaterialsItemMappings { get; set; }
        [InverseProperty("Material")]
        public virtual ICollection<MaterialsOptionsMapping> MaterialOptionsMappings { get; set; }
        [InverseProperty("Material")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("Material")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
    }
}
