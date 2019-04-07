using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Location
    {
        [Key]
        [Column("Location")]
        public int Location1 { get; set; }
        [Required]
        [StringLength(50)]
        public string Text { get; set; }
    }
}
