using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DivisionGroups
    {
        public DivisionGroups()
        {
            Division = new HashSet<Division>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("DivisionGroup")]
        public virtual ICollection<Division> Division { get; set; }
    }
}
