using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("ChargeBacks")]
    public partial class ChargeBack
    {
        public ChargeBack()
        {
            BillDetails = new HashSet<BillDetail>();
            CheckCBDetails = new HashSet<CheckCBDetail>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal Amount { get; set; }
        [Column("SubcontractorId")]
        public int SubcontractorId { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal AmountToSub { get; set; }
        [Required]
        [StringLength(50)]
        public string Number { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(2000)]
        public string Reason { get; set; }
        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }
        [Column("OriginalPO")]
        [StringLength(50)]
        public string OriginalPo { get; set; }
        public bool? CostAdjustment { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }
        public int ApprovalNumber { get; set; }
        [Required]
        public bool? Approved { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("ChargeBacks")]
        public virtual Order Order { get; set; }
        [InverseProperty("ChargeBack")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        [InverseProperty("ChargeBack")]
        public virtual ICollection<CheckCBDetail> CheckCBDetails { get; set; }
    }
}
