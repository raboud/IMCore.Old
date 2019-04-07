using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class LaborType
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Descriptions { get; set; }
    }
}
