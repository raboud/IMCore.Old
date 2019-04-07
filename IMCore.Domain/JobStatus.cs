using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class JobStatus
    {
        public JobStatus()
        {
            Jobs = new HashSet<Jobs>();
            Orders = new HashSet<Orders>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string JobStatusDescription { get; set; }

        [InverseProperty("JobStatus")]
        public virtual ICollection<Jobs> Jobs { get; set; }
        [InverseProperty("JobStatus")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
