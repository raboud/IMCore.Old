using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Document
    {
        public Document()
        {
            OrderDocument = new HashSet<OrderDocument>();
            Sodocument = new HashSet<Sodocument>();
            WorkOrderDocument = new HashSet<WorkOrderDocument>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(512)]
        public string PathAndFilename { get; set; }

        [InverseProperty("Document")]
        public virtual ICollection<OrderDocument> OrderDocument { get; set; }
        [InverseProperty("Document")]
        public virtual ICollection<Sodocument> Sodocument { get; set; }
        [InverseProperty("Document")]
        public virtual ICollection<WorkOrderDocument> WorkOrderDocument { get; set; }
    }
}
