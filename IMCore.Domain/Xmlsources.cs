using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("XMLSources")]
    public partial class Xmlsources
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string DownloadSource { get; set; }
    }
}
