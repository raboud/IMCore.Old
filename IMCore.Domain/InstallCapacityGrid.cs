using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class InstallCapacityGrid
    {
        public int RowType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WeekStart { get; set; }
        [StringLength(10)]
        public string Sun { get; set; }
        [StringLength(10)]
        public string Mon { get; set; }
        [StringLength(10)]
        public string Tue { get; set; }
        [StringLength(10)]
        public string Wed { get; set; }
        [StringLength(10)]
        public string Thu { get; set; }
        [StringLength(10)]
        public string Fri { get; set; }
        [StringLength(10)]
        public string Sat { get; set; }
        [StringLength(10)]
        public string Slot { get; set; }
    }
}
