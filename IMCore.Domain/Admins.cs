using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Admins")]
    public partial class Admin
    {
        [Key]
        [Column("EmployeeId")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("Admins")]
        public virtual User Employee { get; set; }
    }
}
