using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MeasureCompLineItemData
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CalcID")]
        public int CalcId { get; set; }
        public int LineItemNumber { get; set; }
        [StringLength(20)]
        public string MaterialType { get; set; }
        [StringLength(30)]
        public string MaterialDescription { get; set; }
        public int? MaterialWidth { get; set; }
        [StringLength(20)]
        public string PatternMatch { get; set; }
        [StringLength(20)]
        public string MaterialAmount { get; set; }

        [ForeignKey("CalcId")]
        [InverseProperty("MeasureCompLineItemData")]
        public virtual MeasureCompCalcData Calc { get; set; }
    }
}
