using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCategoryItemMappings
    {
        [Column("MaterialCategoryID")]
        public int MaterialCategoryId { get; set; }
        [Column("ItemID")]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("MaterialCategoryItemMappings")]
        public virtual Item Item { get; set; }
        [ForeignKey("MaterialCategoryId")]
        [InverseProperty("MaterialCategoryItemMappings")]
        public virtual MaterialCatagory MaterialCategory { get; set; }
    }
}
