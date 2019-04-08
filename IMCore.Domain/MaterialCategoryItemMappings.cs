using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCategoryItemMappings
    {
        [Column("MaterialCategoryId")]
        public int MaterialCategoryId { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("MaterialCategoryItemMappings")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialCategoryId")]
        [InverseProperty("MaterialCategoryItemMappings")]
        public virtual Material MaterialCategory { get; set; }
    }
}
