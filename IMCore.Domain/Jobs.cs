using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Jobs
    {
        [Key]
        [Column("JobID")]
        public int JobId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDateTime { get; set; }
        [Column("CreatedByID")]
        public int CreatedById { get; set; }
        public bool? Deleted { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? JobSize { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScheduledStartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScheduledEndDate { get; set; }
        [Column("ScheduledAM")]
        public bool? ScheduledAm { get; set; }
        [Column("JobStatusID")]
        public int JobStatusId { get; set; }
        [Column("AssignedToID")]
        public int? AssignedToId { get; set; }
        [Column("PrimaryOrderID")]
        public int? PrimaryOrderId { get; set; }

        [ForeignKey("AssignedToId")]
        [InverseProperty("JobsAssignedTo")]
        public virtual Employees AssignedTo { get; set; }
        [ForeignKey("CreatedById")]
        [InverseProperty("JobsCreatedBy")]
        public virtual Employees CreatedBy { get; set; }
        [ForeignKey("JobStatusId")]
        [InverseProperty("Jobs")]
        public virtual JobStatus JobStatus { get; set; }
        [ForeignKey("PrimaryOrderId")]
        [InverseProperty("Jobs")]
        public virtual Orders PrimaryOrder { get; set; }
    }
}
