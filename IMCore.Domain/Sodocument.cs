using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SODocument")]
    public partial class Sodocument
    {
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Column("SOID")]
        public int Soid { get; set; }

        [ForeignKey("DocumentId")]
        [InverseProperty("Sodocument")]
        public virtual Document Document { get; set; }
        [ForeignKey("Soid")]
        [InverseProperty("Sodocument")]
        public virtual OrderSomerchandiseDetails So { get; set; }
    }
}
