using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Material Catagory")]
    public partial class MaterialCatagory
    {
        public MaterialCatagory()
        {
            MaterialCategoryBasicLaborMappings = new HashSet<MaterialCategoryBasicLaborMappings>();
            MaterialCategoryItemMappings = new HashSet<MaterialCategoryItemMappings>();
            MaterialCategoryOptionsMappings = new HashSet<MaterialCategoryOptionsMappings>();
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
        [InverseProperty("MaterialCatagory")]
        public virtual MatSubCat SubCat { get; set; }
        [ForeignKey("UnitOfMeasureId")]
        [InverseProperty("MaterialCatagory")]
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        [InverseProperty("MaterialCategory")]
        public virtual ICollection<MaterialCategoryBasicLaborMappings> MaterialCategoryBasicLaborMappings { get; set; }
        [InverseProperty("MaterialCategory")]
        public virtual ICollection<MaterialCategoryItemMappings> MaterialCategoryItemMappings { get; set; }
        [InverseProperty("MaterialCategory")]
        public virtual ICollection<MaterialCategoryOptionsMappings> MaterialCategoryOptionsMappings { get; set; }
        [InverseProperty("MaterialCat")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("MaterialCat")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
    }
}
