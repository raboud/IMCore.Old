using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("UserBranchDivisionAssignments")]
    public partial class UserBranchDivisionAssignment
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
        [Column("DivisionId")]
        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("UserBranchDivisionAssignments")]
        public virtual Division Division { get; set; }
        [ForeignKey("BranchId")]
        [InverseProperty("UserBranchDivisionAssignments")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserBranchDivisionAssignments")]
        public virtual User User { get; set; }
    }
}
