using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Store Error")]
    public partial class StoreError
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
    }
}
