using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class IssueStatus
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string StatusDesc { get; set; }
    }
}
