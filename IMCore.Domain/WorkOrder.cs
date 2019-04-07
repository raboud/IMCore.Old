using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            WorkOrderDocument = new HashSet<WorkOrderDocument>();
            WorkOrderEmails = new HashSet<WorkOrderEmails>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScheduleStartDate { get; set; }
        [Column("CrewID")]
        public int? CrewId { get; set; }
        [Column("JobID")]
        public int? JobId { get; set; }
        public bool Cancel { get; set; }
        [Column("ScheduledAM")]
        public bool ScheduledAm { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScheduleEndDate { get; set; }
        [Column("OrderID")]
        public int? OrderId { get; set; }

        [ForeignKey("CrewId")]
        [InverseProperty("WorkOrder")]
        public virtual InstallationCrew Crew { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("WorkOrder")]
        public virtual Orders Order { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual BillDetails BillDetails { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<WorkOrderDocument> WorkOrderDocument { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<WorkOrderEmails> WorkOrderEmails { get; set; }
    }
}
