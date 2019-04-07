using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Admins
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("Admins")]
        public virtual Employees Employee { get; set; }
    }
}
