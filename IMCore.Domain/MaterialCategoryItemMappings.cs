using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MaterialsItemMapping")]
    public partial class MaterialsItemMapping
    {
        [Column("MaterialId")]
        public int MaterialId { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("MaterialItemMappings")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialId")]
        [InverseProperty("MaterialsItemMappings")]
        public virtual Material Material { get; set; }
    }
}
