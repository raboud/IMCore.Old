using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ItemPricing
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ItemID")]
        public int ItemId { get; set; }
        [Column("MarketID")]
        public int? MarketId { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("ItemPricing")]
        public virtual Item Item { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("ItemPricing")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreId")]
        public virtual Stores Store { get; set; }
    }
}
