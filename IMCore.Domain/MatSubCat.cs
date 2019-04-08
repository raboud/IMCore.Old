using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MatSubCat")]
    public partial class MaterialSubCategory
    {
        public MaterialSubCategory()
        {
            MaterialCatagory = new HashSet<Material>();
        }

        [Key]
        public int SubCatId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("SubCat")]
        public virtual ICollection<Material> MaterialCatagory { get; set; }
    }
}
