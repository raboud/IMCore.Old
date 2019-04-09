using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            Permissions = new HashSet<Permission>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("PermissionType")]
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
