using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class WorkOrderEmails
    {
        [Column("WorkOrderId")]
        public int WorkOrderId { get; set; }
        public int EmailType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Sent { get; set; }

        [ForeignKey("WorkOrderId")]
        [InverseProperty("WorkOrderEmails")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
