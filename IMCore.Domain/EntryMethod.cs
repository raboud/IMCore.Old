using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class EntryMethod
    {
        public EntryMethod()
        {
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetails>();
            OrderCustomDetails = new HashSet<OrderCustomDetails>();
            OrderOptionsDetails = new HashSet<OrderOptionsDetails>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetails>();
            OrderSomerchandiseDetails = new HashSet<OrderSomerchandiseDetails>();
            Orders = new HashSet<Orders>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderBasicLaborDetails> OrderBasicLaborDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderCustomDetails> OrderCustomDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderOptionsDetails> OrderOptionsDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderRegMerchandiseDetails> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderSomerchandiseDetails> OrderSomerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
