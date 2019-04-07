using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Weeks
    {
        [Key]
        [Column("Weeks")]
        public int Weeks1 { get; set; }
    }
}
