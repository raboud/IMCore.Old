using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ProgramReport
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ReportTypeID")]
        public int ReportTypeId { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("ProgramReport")]
        public virtual MaterialType Program { get; set; }
        [ForeignKey("ReportTypeId")]
        [InverseProperty("ProgramReport")]
        public virtual ReportType ReportType { get; set; }
    }
}
