using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Material Status")]
    public partial class MaterialStatus
    {
        public MaterialStatus()
        {
            OrderBasicLaborDetails = new HashSet<OrderBasicLabor>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandise>();
            OrderSomerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        public bool Billable { get; set; }
        public bool Installable { get; set; }

        [InverseProperty("MaterialStatus")]
        public virtual ICollection<OrderBasicLabor> OrderBasicLaborDetails { get; set; }
        [InverseProperty("MaterialStatus")]
        public virtual ICollection<OrderRegMerchandise> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("MaterialStatus")]
        public virtual ICollection<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
    }
}
