using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class CheckDetail
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("CheckId")]
        public int CheckId { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal Amount { get; set; }

        [ForeignKey("CheckId")]
        [InverseProperty("CheckDetails")]
        public virtual Checks Check { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("CheckDetail")]
        public virtual Order Order { get; set; }
    }
}
