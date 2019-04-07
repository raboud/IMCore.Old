using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialPrice
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaterialCatID")]
        public int MaterialCatId { get; set; }
        [Column("MarketID")]
        public int? MarketId { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("MarketId")]
        [InverseProperty("MaterialPrice")]
        public virtual Market Market { get; set; }
        [ForeignKey("MaterialCatId")]
        [InverseProperty("MaterialPrice")]
        public virtual MaterialCatagory MaterialCat { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("MaterialPrice")]
        public virtual MaterialType Program { get; set; }
        [ForeignKey("StoreId")]
        public virtual Stores Store { get; set; }
    }
}
