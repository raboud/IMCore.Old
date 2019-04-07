using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BasicCost
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("LaborID")]
        public int LaborId { get; set; }
        [Column("BranchID")]
        public int? BranchId { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BasicCost")]
        public virtual Market Branch { get; set; }
        [ForeignKey("StoreId")]
        public virtual Stores Store { get; set; }
    }
}
