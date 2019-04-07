using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MatSubCat
    {
        public MatSubCat()
        {
            MaterialCatagory = new HashSet<MaterialCatagory>();
        }

        [Key]
        public int SubCatId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("SubCat")]
        public virtual ICollection<MaterialCatagory> MaterialCatagory { get; set; }
    }
}
