using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class InstallCapacity
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WeekStart { get; set; }
        [Column("JobTypeID")]
        public int? JobTypeId { get; set; }
        [StringLength(10)]
        public string Slot { get; set; }
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
    }
}
