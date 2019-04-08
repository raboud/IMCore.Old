using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ItemPricing
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }
        [Column("MarketId")]
        public int? MarketId { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("Prices")]
        public virtual Item Item { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("ItemPricing")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
