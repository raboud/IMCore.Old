using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserPermissions
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
        [Column("DivisionId")]
        public int DivisionId { get; set; }
        [Column("PermissionId")]
        public int PermissionId { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("UserPermissions")]
        public virtual Division Division { get; set; }
        [ForeignKey("BranchId")]
        [InverseProperty("UserPermissions")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("PermissionId")]
        [InverseProperty("UserPermissions")]
        public virtual Permission Permission { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserPermissions")]
        public virtual User User { get; set; }
    }
}
