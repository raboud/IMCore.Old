using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SOSIOutgoingDocuments")]
    public partial class SosioutgoingDocuments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DocumentTypeID")]
        public int DocumentTypeId { get; set; }
        [StringLength(50)]
        public string Datafield1 { get; set; }
        [StringLength(50)]
        public string Datafield2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendAfter { get; set; }
    }
}
