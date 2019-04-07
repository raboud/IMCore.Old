using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ClientTypeReports
    {
        public int Id { get; set; }
        [Column("ReportTypeID")]
        public int ReportTypeId { get; set; }
        [Column("ClientTypeID")]
        public int ClientTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [ForeignKey("ClientTypeId")]
        [InverseProperty("ClientTypeReports")]
        public virtual StoreType ClientType { get; set; }
        [ForeignKey("ReportTypeId")]
        [InverseProperty("ClientTypeReports")]
        public virtual ReportType ReportType { get; set; }
    }
}
