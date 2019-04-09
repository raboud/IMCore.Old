using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MaterialTypesMarketMapping")]
    public partial class ProgramBranchMapping
    {
        [Column("ProgramId")]
        public int ProgramId { get; set; }
        [Column("MarketId")]
        public int MarketId { get; set; }
        public bool AllowEntry { get; set; }

        [ForeignKey("MarketId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual Market Market { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual Program Program { get; set; }
    }
}
