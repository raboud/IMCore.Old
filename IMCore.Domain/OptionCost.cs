﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OptionCost
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
        [InverseProperty("OptionCost")]
        public virtual Market Branch { get; set; }
        [ForeignKey("LaborId")]
        [InverseProperty("OptionCost")]
        public virtual Options Labor { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("OptionCost")]
        public virtual Stores Store { get; set; }
    }
}
