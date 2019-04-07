using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OrderDocument
    {
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }

        [ForeignKey("DocumentId")]
        [InverseProperty("OrderDocument")]
        public virtual Document Document { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OrderDocument")]
        public virtual Orders Order { get; set; }
    }
}
