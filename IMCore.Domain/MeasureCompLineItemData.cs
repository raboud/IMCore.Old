using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MeasureCompLineItemData")]
    public partial class MeasureCompLineItem
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("CalcId")]
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
        [InverseProperty("MeasureCompLineItem")]
        public virtual MeasureCompCalcs Calc { get; set; }
    }
}
