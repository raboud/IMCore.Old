using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class CapacityPoolTypes
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string PoolType { get; set; }
    }
}
