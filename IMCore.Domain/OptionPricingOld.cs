using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OptionPricingOld
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OptionId")]
        public int OptionId { get; set; }
        [Column("BranchId")]
        public int? BranchId { get; set; }
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

        [ForeignKey("BranchId")]
        [InverseProperty("OptionPricingOld")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("OptionId")]
        [InverseProperty("OptionPricingOld")]
        public virtual Option Option { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
