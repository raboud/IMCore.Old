using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class InstallationCrewType
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("JobTypeId")]
        public int JobTypeId { get; set; }
        public double? Rating { get; set; }
        [Column("MaxSizeId")]
        public int? MaxSizeId { get; set; }

        [ForeignKey("CrewId")]
        [InverseProperty("InstallationCrewType")]
        public virtual InstallationCrew Crew { get; set; }
        [ForeignKey("JobTypeId")]
        [InverseProperty("InstallationCrewType")]
        public virtual JobTypes JobType { get; set; }
    }
}
