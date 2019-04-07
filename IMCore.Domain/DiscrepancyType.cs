using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DiscrepancyType
    {
        public DiscrepancyType()
        {
            Discrepancies = new HashSet<Discrepancies>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("DiscrepancyType")]
        public virtual ICollection<Discrepancies> Discrepancies { get; set; }
    }
}
