using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCategoryBasicLaborMappings
    {
        [Column("MaterialCategoryId")]
        public int MaterialCategoryId { get; set; }
        [Column("BasicLaborId")]
        public int BasicLaborId { get; set; }

        [ForeignKey("BasicLaborId")]
        [InverseProperty("MaterialCategoryBasicLaborMappings")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("MaterialCategoryId")]
        [InverseProperty("MaterialCategoryBasicLaborMappings")]
        public virtual Material MaterialCategory { get; set; }
    }
}
