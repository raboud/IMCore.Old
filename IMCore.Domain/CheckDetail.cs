using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class CheckDetail
    {
        [Column("CheckDetailID")]
        public int CheckDetailId { get; set; }
        [Column("CheckID")]
        public int CheckId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal Amount { get; set; }

        [ForeignKey("CheckId")]
        [InverseProperty("CheckDetail")]
        public virtual Checks Check { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("CheckDetail")]
        public virtual Orders Order { get; set; }
    }
}
