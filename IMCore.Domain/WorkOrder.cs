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

        [Column("Id")]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScheduleStartDate { get; set; }
        [Column("CrewId")]
        public int? CrewId { get; set; }
        [Column("JobId")]
        public int? JobId { get; set; }
        public bool Cancel { get; set; }
        [Column("ScheduledAM")]
        public bool ScheduledAm { get; set; }
        [Column(TypeName = "date")]
        public DateTime ScheduleEndDate { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }

        [ForeignKey("CrewId")]
        [InverseProperty("WorkOrder")]
        public virtual InstallationCrew Crew { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("WorkOrders")]
        public virtual Order Order { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual BillDetail BillDetails { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<WorkOrderDocument> WorkOrderDocument { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<WorkOrderEmails> WorkOrderEmails { get; set; }
    }
}
