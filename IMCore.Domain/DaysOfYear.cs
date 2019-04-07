using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DaysOfYear
    {
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime DateValue { get; set; }
    }
}
