using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SPNActions")]
    public partial class SPNActionType
    {
        public SPNActionType()
        {
            SpnactionQueue = new HashSet<SPNActionQueue>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("Action")]
        public virtual ICollection<SPNActionQueue> SpnactionQueue { get; set; }
    }
}
