using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActionReport
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReportDate { get; set; }
        [Column(TypeName = "text")]
        public string Nature { get; set; }
        [Column(TypeName = "text")]
        public string ActionRequired { get; set; }
        [Column(TypeName = "text")]
        public string Cause { get; set; }
        public bool? Closed { get; set; }
        public int? StoreError { get; set; }
        public int? MillError { get; set; }
        public int? InstallerError { get; set; }
        public int? MeasureError { get; set; }
        [StringLength(100)]
        public string StoreErrorText { get; set; }
        [StringLength(100)]
        public string MillErrorText { get; set; }
        [StringLength(100)]
        public string InstallerErrorText { get; set; }
        [StringLength(100)]
        public string MeasureErrorText { get; set; }
        public int? EnteredBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditedDate { get; set; }
        public int? LastEditedBy { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("ActionReport")]
        public virtual Orders Order { get; set; }
    }
}
