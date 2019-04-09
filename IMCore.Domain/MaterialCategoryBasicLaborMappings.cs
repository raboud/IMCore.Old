using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MaterialBasicLaborMapping")]
    public partial class MaterialBasicLaborMapping
    {
        [Column("MaterialId")]
        public int MaterialId { get; set; }
        [Column("BasicLaborId")]
        public int BasicLaborId { get; set; }

        [ForeignKey("BasicLaborId")]
        [InverseProperty("MaterialBasicLaborMappings")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("MaterialId")]
        [InverseProperty("MaterialBasicLaborMappings")]
        public virtual Material Material { get; set; }
    }
}
