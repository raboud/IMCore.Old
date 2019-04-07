using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class SpokeWith
    {
        [Key]
        [Column("SpokeWith")]
        public int SpokeWith1 { get; set; }
        [Required]
        [Column("SW_Text")]
        [StringLength(50)]
        public string SwText { get; set; }
        [Required]
        public bool? ShowAlways { get; set; }
        public byte DisplayOrder { get; set; }
        [Required]
        public bool? EnableSchedulingInfo { get; set; }
    }
}
