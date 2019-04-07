using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialTypesMarketMapping
    {
        [Column("MaterialTypeID")]
        public int MaterialTypeId { get; set; }
        [Column("MarketID")]
        public int MarketId { get; set; }
        public bool AllowEntry { get; set; }

        [ForeignKey("MarketId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual Market Market { get; set; }
        [ForeignKey("MaterialTypeId")]
        [InverseProperty("MaterialTypesMarketMapping")]
        public virtual MaterialType MaterialType { get; set; }
    }
}
