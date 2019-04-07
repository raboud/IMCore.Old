using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class InstallerStatus
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
    }
}
