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
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetail>();
            OrderCustomDetails = new HashSet<OrderCustomDetail>();
            OrderOptionsDetails = new HashSet<OrderOption>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetail>();
            OrderSomerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
            Orders = new HashSet<Order>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderBasicLaborDetail> OrderBasicLaborDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderCustomDetail> OrderCustomDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderOption> OrderOptionsDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderRegMerchandiseDetail> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
