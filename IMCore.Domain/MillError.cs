using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Mill Error")]
    public partial class MillError
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
    }
}
