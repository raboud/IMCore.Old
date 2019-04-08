using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ReportType
    {
        public ReportType()
        {
            ClientTypeReports = new HashSet<ClientTypeReport>();
            ProgramReport = new HashSet<ProgramReport>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Class { get; set; }

        [InverseProperty("ReportType")]
        public virtual ICollection<ClientTypeReport> ClientTypeReports { get; set; }
        [InverseProperty("ReportType")]
        public virtual ICollection<ProgramReport> ProgramReport { get; set; }
    }
}
