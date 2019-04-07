using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class JobTypes
    {
        public JobTypes()
        {
            InstallationCrewType = new HashSet<InstallationCrewType>();
            MaterialType = new HashSet<MaterialType>();
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
        public virtual ICollection<MaterialType> MaterialType { get; set; }
    }
}
