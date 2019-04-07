using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserMarketDivisionAssignments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("MarketID")]
        public int MarketId { get; set; }
        [Column("DivisionID")]
        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("UserMarketDivisionAssignments")]
        public virtual Division Division { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("UserMarketDivisionAssignments")]
        public virtual Market Market { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserMarketDivisionAssignments")]
        public virtual Employees User { get; set; }
    }
}
