using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class VendorNumbers
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(30)]
        public string VendorNumber { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column("HDDescription")]
        [StringLength(50)]
        public string Hddescription { get; set; }
        public bool? PaySubWhenPaid { get; set; }
    }
}
