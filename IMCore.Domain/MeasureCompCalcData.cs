using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MeasureCompCalcData
    {
        public MeasureCompCalcData()
        {
            MeasureCompLineItemData = new HashSet<MeasureCompLineItemData>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CalcTimeStamp { get; set; }
        public bool? Assigned { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("MeasureCompCalcData")]
        public virtual Orders Order { get; set; }
        [InverseProperty("Calc")]
        public virtual ICollection<MeasureCompLineItemData> MeasureCompLineItemData { get; set; }
    }
}
