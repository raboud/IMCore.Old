using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("CheckCBDetail")]
    public partial class CheckCBDetail
    {
        [Column("CheckCBDetailId")]
        public int CheckCbdetailId { get; set; }
        [Column("CheckId")]
        public int CheckId { get; set; }
        [Column("ChargeBackId")]
        public int ChargeBackId { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal Amount { get; set; }

        [ForeignKey("ChargeBackId")]
        [InverseProperty("CheckCBDetails")]
        public virtual ChargeBack ChargeBack { get; set; }
        [ForeignKey("CheckId")]
        [InverseProperty("CheckCBDetails")]
        public virtual Checks Check { get; set; }
    }
}
