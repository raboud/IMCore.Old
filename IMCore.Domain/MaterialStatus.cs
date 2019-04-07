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
            OrderBasicLaborDetails = new HashSet<OrderBasicLaborDetails>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetails>();
            OrderSomerchandiseDetails = new HashSet<OrderSomerchandiseDetails>();
        }

        [Key]
        [Column("MatStatusID")]
        public int MatStatusId { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        public bool Billable { get; set; }
        public bool Installable { get; set; }

        [InverseProperty("MaterialStatus")]
        public virtual ICollection<OrderBasicLaborDetails> OrderBasicLaborDetails { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<OrderRegMerchandiseDetails> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("MaterialStatus")]
        public virtual ICollection<OrderSomerchandiseDetails> OrderSomerchandiseDetails { get; set; }
    }
}
