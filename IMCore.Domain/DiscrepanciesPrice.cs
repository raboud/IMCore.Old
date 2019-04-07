using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DiscrepanciesPrice
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DiscrepancyTypeID")]
        public int DiscrepancyTypeId { get; set; }
        [Column("ItemID")]
        public int ItemId { get; set; }
        [Column("MarketID")]
        public int MarketId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CurrentPrice { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? NewPrice { get; set; }
        [Column("XMLFilePath")]
        [StringLength(1024)]
        public string XmlfilePath { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateFound { get; set; }
    }
}
