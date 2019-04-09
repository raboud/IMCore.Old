using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ItemCosting
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ItemId")]
        public int ItemId { get; set; }
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
        [Column("DivisionId")]
        public int? DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("ItemCosting")]
        public virtual Division Division { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty("Costs")]
        public virtual Item Item { get; set; }
        [ForeignKey("BranchId")]
        [InverseProperty("ItemCosting")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
