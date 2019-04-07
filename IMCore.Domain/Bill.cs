using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetails>();
        }

        public int BillId { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalPaid { get; set; }
        [Column(TypeName = "money")]
        public decimal Retainage { get; set; }
        [Column(TypeName = "money")]
        public decimal Insurance { get; set; }
        [Column(TypeName = "date")]
        public DateTime PayDay { get; set; }
        public bool Paid { get; set; }
        public int OwnerId { get; set; }
        [Column("QBTxnId")]
        [StringLength(50)]
        public string QbtxnId { get; set; }

        [ForeignKey("OwnerId")]
        [InverseProperty("Bill")]
        public virtual SubContractors Owner { get; set; }
        [InverseProperty("Bill")]
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}
