using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("JobTypes")]
    public partial class JobType
    {
        public JobType()
        {
            InstallationCrewType = new HashSet<InstallationCrewType>();
            Programs = new HashSet<Program>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public bool AlwaysSkipInitialCall { get; set; }

        [InverseProperty("JobType")]
        public virtual ICollection<InstallationCrewType> InstallationCrewType { get; set; }
        [InverseProperty("JobType")]
        public virtual ICollection<Program> Programs { get; set; }
    }
}
