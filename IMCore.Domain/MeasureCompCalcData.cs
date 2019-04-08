using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	
	[Table("MeasureCompCalcData")]
	public partial class MeasureCompCalcs
    {
        public MeasureCompCalcs()
        {
            MeasureCompLineItem = new HashSet<MeasureCompLineItem>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CalcTimeStamp { get; set; }
        public bool? Assigned { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("MeasureCompCalcData")]
        public virtual Order Order { get; set; }
        [InverseProperty("Calc")]
        public virtual ICollection<MeasureCompLineItem> MeasureCompLineItem { get; set; }
    }
}
