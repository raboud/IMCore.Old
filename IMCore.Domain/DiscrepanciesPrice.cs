using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DiscrepanciesPrice
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("DiscrepancyTypeId")]
        public int DiscrepancyTypeId { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
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
