using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCost
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("MaterialCatId")]
        public int MaterialCatId { get; set; }
        [Column("MarketId")]
        public int? MarketId { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column("ProgramId")]
        public int? ProgramId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "money")]
        public decimal Freight { get; set; }
        [Column(TypeName = "money")]
        public decimal SalesTax { get; set; }

        [ForeignKey("MarketId")]
        [InverseProperty("MaterialCost")]
        public virtual Market Market { get; set; }
        [ForeignKey("MaterialCatId")]
        [InverseProperty("MaterialCost")]
        public virtual Material MaterialCat { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("MaterialCost")]
        public virtual Program Program { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
