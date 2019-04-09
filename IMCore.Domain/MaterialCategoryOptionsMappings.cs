using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MaterialsOptionsMapping")]
    public partial class MaterialsOptionsMapping
    {
        [Column("MaterialId")]
        public int MaterialId { get; set; }
        [Column("OptionId")]
        public int OptionId { get; set; }

        [ForeignKey("MaterialId")]
        [InverseProperty("MaterialOptionsMappings")]
        public virtual Material Material { get; set; }
        [ForeignKey("OptionId")]
        [InverseProperty("MaterialOptionsMappings")]
        public virtual Option Option { get; set; }
    }
}
