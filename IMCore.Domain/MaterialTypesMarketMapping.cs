using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MaterialTypesMarketMapping")]
    public partial class ProgramBranchMapping
    {
        [Column("MaterialTypeId")]
        public int MaterialTypeId { get; set; }
        [Column("MarketId")]
        public int MarketId { get; set; }
        public bool AllowEntry { get; set; }

        [ForeignKey("MarketId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual Market Market { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual Program MaterialType { get; set; }
    }
}
