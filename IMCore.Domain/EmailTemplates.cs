using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("EmailTemplates")]
    public partial class EmailTemplate
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Content { get; set; }
    }
}
