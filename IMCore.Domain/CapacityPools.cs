using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class CapacityPools
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("HDPoolID")]
        [StringLength(10)]
        public string HdpoolId { get; set; }
        [Column("PoolTypeID")]
        public int PoolTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string PoolName { get; set; }
        [Required]
        [StringLength(50)]
        public string ZoneName { get; set; }
        [Required]
        [StringLength(50)]
        public string ZoneNumber { get; set; }
        [Column("VendorID")]
        public int VendorId { get; set; }
    }
}
