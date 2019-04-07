using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BillDetails
    {
        public int BillDetailsId { get; set; }
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
        [Column("ClassificationID")]
        public int ClassificationId { get; set; }
        [Column("BackChargeOwnerID")]
        public int? BackChargeOwnerId { get; set; }
        [Column("ChargeBackID")]
        public int? ChargeBackId { get; set; }
        [Column("QBUid")]
        [StringLength(20)]
        public string Qbuid { get; set; }

        [ForeignKey("BackChargeOwnerId")]
        [InverseProperty("BillDetails")]
        public virtual SubContractors BackChargeOwner { get; set; }
        [ForeignKey("BillId")]
        [InverseProperty("BillDetails")]
        public virtual Bill Bill { get; set; }
        [ForeignKey("ChargeBackId")]
        [InverseProperty("BillDetails")]
        public virtual ChargeBacks ChargeBack { get; set; }
        [ForeignKey("WorkOrderId")]
        [InverseProperty("BillDetails")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
