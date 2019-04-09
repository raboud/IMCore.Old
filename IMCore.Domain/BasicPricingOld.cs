using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BasicPricingOld
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("BasicLaborId")]
        public int BasicLaborId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
        [Column("StoreId")]
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
        [ForeignKey("BranchId")]
        [InverseProperty("BasicPricingOld")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
