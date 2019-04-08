using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SODocument")]
    public partial class Sodocument
    {
        [Column("Id")]
        public int DocumentId { get; set; }
        [Column("SOId")]
        public int Soid { get; set; }

        [ForeignKey("DocumentId")]
        [InverseProperty("Sodocument")]
        public virtual Document Document { get; set; }
        [ForeignKey("Soid")]
        [InverseProperty("Sodocument")]
        public virtual OrderSOMerchandiseDetail So { get; set; }
    }
}
