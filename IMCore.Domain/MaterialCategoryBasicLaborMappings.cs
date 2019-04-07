using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCategoryBasicLaborMappings
    {
        [Column("MaterialCategoryID")]
        public int MaterialCategoryId { get; set; }
        [Column("BasicLaborID")]
        public int BasicLaborId { get; set; }

        [ForeignKey("BasicLaborId")]
        [InverseProperty("MaterialCategoryBasicLaborMappings")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("MaterialCategoryId")]
        [InverseProperty("MaterialCategoryBasicLaborMappings")]
        public virtual MaterialCatagory MaterialCategory { get; set; }
    }
}
