using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OptionPricingOld
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OptionID")]
        public int OptionId { get; set; }
        [Column("MarketID")]
        public int? MarketId { get; set; }
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

        [ForeignKey("MarketId")]
        [InverseProperty("OptionPricingOld")]
        public virtual Market Market { get; set; }
        [ForeignKey("OptionId")]
        [InverseProperty("OptionPricingOld")]
        public virtual Options Option { get; set; }
        [ForeignKey("StoreId")]
        public virtual Stores Store { get; set; }
    }
}
