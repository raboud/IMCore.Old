using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Settings")]
    public partial class Setting
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Value { get; set; }
        [Column("UserId")]
        public int? UserId { get; set; }
    }
}
