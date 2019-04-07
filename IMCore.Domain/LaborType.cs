using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class LaborType
    {
        [Column("LaborTypeID")]
        public int LaborTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string Descriptions { get; set; }
    }
}
