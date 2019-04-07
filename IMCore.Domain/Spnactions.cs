using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SPNActions")]
    public partial class Spnactions
    {
        public Spnactions()
        {
            SpnactionQueue = new HashSet<SpnactionQueue>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("Action")]
        public virtual ICollection<SpnactionQueue> SpnactionQueue { get; set; }
    }
}
