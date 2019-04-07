using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserPermissions
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("MarketID")]
        public int MarketId { get; set; }
        [Column("DivisionID")]
        public int DivisionId { get; set; }
        [Column("PermissionID")]
        public int PermissionId { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("UserPermissions")]
        public virtual Division Division { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("UserPermissions")]
        public virtual Market Market { get; set; }
        [ForeignKey("PermissionId")]
        [InverseProperty("UserPermissions")]
        public virtual Permissions Permission { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserPermissions")]
        public virtual Employees User { get; set; }
    }
}
