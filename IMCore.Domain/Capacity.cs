using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Capacity
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("PoolId")]
        public int PoolId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime CapacityDate { get; set; }
        [Column("CapAM")]
        public int CapAm { get; set; }
        [Column("CapPM")]
        public int CapPm { get; set; }
        [Column("CapNP")]
        public int CapNp { get; set; }
        public bool NonWorkDay { get; set; }
        [Required]
        [Column("SendToHD")]
        public bool? SendToHd { get; set; }
    }
}
