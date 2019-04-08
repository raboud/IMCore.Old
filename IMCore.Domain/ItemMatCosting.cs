﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ItemMatCosting
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }
        [Column("MarketId")]
        public int MarketId { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal? MatCost { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
        public double? SalesTax { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("ItemMatCosting")]
        public virtual Item Item { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("ItemMatCosting")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
