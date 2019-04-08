using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("ClientTypeReports")]
    public partial class ClientTypeReport
    {
        public int Id { get; set; }
        [Column("ReportTypeId")]
        public int ReportTypeId { get; set; }
        [Column("ClientTypeId")]
        public int ClientTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [ForeignKey("ClientTypeId")]
        [InverseProperty("ClientTypeReports")]
        public virtual ClientType ClientType { get; set; }
        [ForeignKey("ReportTypeId")]
        [InverseProperty("ClientTypeReports")]
        public virtual ReportType ReportType { get; set; }
    }
}
