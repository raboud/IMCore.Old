using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("EmailImages")]
    public partial class EmailImage
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "image")]
        public byte[] Content { get; set; }
    }
}
