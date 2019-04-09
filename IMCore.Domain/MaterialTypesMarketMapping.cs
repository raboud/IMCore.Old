using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("ProgramBranchMapping")]
    public partial class ProgramBranchMapping
    {
        [Column("ProgramId")]
        public int ProgramId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
        public bool AllowEntry { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("ProgramBranchMappings")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("ProgramBranchMappings")]
        public virtual Program Program { get; set; }
    }
}
