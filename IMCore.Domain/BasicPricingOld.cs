using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BasicPricingOld
    {
        [Column("BasicPricingID")]
        public int BasicPricingId { get; set; }
        [Column("BasicLaborID")]
        public int BasicLaborId { get; set; }
        [Column("MarketID")]
        public int MarketId { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Retail { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("BasicLaborId")]
        [InverseProperty("BasicPricingOld")]
        public virtual BasicLabor BasicLabor { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("BasicPricingOld")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("BasicPricingOld")]
        public virtual Stores Store { get; set; }
    }
}
