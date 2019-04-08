using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("BillDetails")]
    public partial class BillDetail
    {
		[Column("Id")]
		public int Id { get; set; }
        public int BillId { get; set; }
        public bool NoRetainage { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        public int? WorkOrderId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal? PayAmount { get; set; }
        [StringLength(200)]
        public string Comments { get; set; }
        [Column("ClassificationId")]
        public int ClassificationId { get; set; }
        [Column("BackChargeOwnerId")]
        public int? BackChargeOwnerId { get; set; }
        [Column("ChargeBackId")]
        public int? ChargeBackId { get; set; }
        [Column("QBUid")]
        [StringLength(20)]
        public string Qbuid { get; set; }

        [ForeignKey("BackChargeOwnerId")]
        [InverseProperty("BillDetails")]
        public virtual SubContractor BackChargeOwner { get; set; }
        [ForeignKey("BillId")]
        [InverseProperty("BillDetails")]
        public virtual Bill Bill { get; set; }
        [ForeignKey("ChargeBackId")]
        [InverseProperty("BillDetails")]
        public virtual ChargeBack ChargeBack { get; set; }
        [ForeignKey("WorkOrderId")]
        [InverseProperty("BillDetails")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
