using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("POStatusValues")]
    public partial class PostatusValues
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
