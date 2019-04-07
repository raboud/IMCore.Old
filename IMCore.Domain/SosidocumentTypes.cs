using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SOSIDocumentTypes")]
    public partial class SosidocumentTypes
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string DocType { get; set; }
    }
}
