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
            OrderBasicLaborDetails = new HashSet<OrderBasicLabor>();
            OrderCustomDetails = new HashSet<OrderCustom>();
            OrderOptionsDetails = new HashSet<OrderOption>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandise>();
            OrderSomerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
            Orders = new HashSet<Order>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderBasicLabor> OrderBasicLaborDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderCustom> OrderCustomDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderOption> OrderOptionsDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderRegMerchandise> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
        [InverseProperty("EntryMethod")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
