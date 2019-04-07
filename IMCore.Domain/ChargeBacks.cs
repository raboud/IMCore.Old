using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ChargeBacks
    {
        public ChargeBacks()
        {
            BillDetails = new HashSet<BillDetails>();
            CheckCbdetail = new HashSet<CheckCbdetail>();
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
        public virtual Orders Order { get; set; }
        [InverseProperty("ChargeBack")]
        public virtual ICollection<BillDetails> BillDetails { get; set; }
        [InverseProperty("ChargeBack")]
        public virtual ICollection<CheckCbdetail> CheckCbdetail { get; set; }
    }
}
