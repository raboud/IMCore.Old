using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class WorkOrderDocument
    {
        [Column("DocumentId")]
        public int DocumentId { get; set; }
        [Column("WorkOrderId")]
        public int WorkOrderId { get; set; }

        [ForeignKey("DocumentId")]
        [InverseProperty("WorkOrderDocument")]
        public virtual Document Document { get; set; }
        [ForeignKey("WorkOrderId")]
        [InverseProperty("WorkOrderDocument")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
