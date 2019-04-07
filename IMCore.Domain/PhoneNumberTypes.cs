using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class PhoneNumberTypes
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
    }
}
