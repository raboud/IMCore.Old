using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Version
    {
        [Column("Id")]
        public int Id { get; set; }
        public int? VersionNo { get; set; }
        public int? MinimumVersionMajor { get; set; }
        public int? MinimumVersionMinor { get; set; }
    }
}
