using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Checks
    {
        public Checks()
        {
            CheckCBDetails = new HashSet<CheckCBDetail>();
            CheckDetails = new HashSet<CheckDetail>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(10)]
        public string CheckNumber { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CheckDate { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal? Amount { get; set; }
        [Column("VendorId")]
        public int VendorId { get; set; }
        [Column("QBTxnId")]
        [StringLength(50)]
        public string QbtxnId { get; set; }

        [InverseProperty("Check")]
        public virtual ICollection<CheckCBDetail> CheckCBDetails { get; set; }
        [InverseProperty("Check")]
        public virtual ICollection<CheckDetail> CheckDetails { get; set; }
    }
}
