using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Permissions")]
    public partial class Permission
    {
        public Permission()
        {
            UserPermissions = new HashSet<UserPermissions>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string PermissionName { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("PermissionTypeId")]
        public int PermissionTypeId { get; set; }

        [ForeignKey("PermissionTypeId")]
        [InverseProperty("Permissions")]
        public virtual PermissionType PermissionType { get; set; }
        [InverseProperty("Permission")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
