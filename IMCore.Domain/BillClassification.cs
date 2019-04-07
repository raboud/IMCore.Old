using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BillClassification
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        public bool SubjectToRetainage { get; set; }
        public bool SubjectToInsurance { get; set; }
    }
}
