using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OptionPrice
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("LaborId")]
        public int LaborId { get; set; }
        [Column("BranchId")]
        public int? BranchId { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("OptionPrice")]
        public virtual Market Branch { get; set; }
        [ForeignKey("LaborId")]
        [InverseProperty("Prices")]
        public virtual Option Labor { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
