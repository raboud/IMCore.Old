using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ProgramReport
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ReportTypeId")]
        public int ReportTypeId { get; set; }
        [Column("ProgramId")]
        public int ProgramId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("ProgramReport")]
        public virtual Program Program { get; set; }
        [ForeignKey("ReportTypeId")]
        [InverseProperty("ProgramReport")]
        public virtual ReportType ReportType { get; set; }
    }
}
