using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("OrderDiagrams")]
	public partial class OrderDiagram
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [StringLength(20)]
        public string DiagramNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiagramDateTime { get; set; }
        [StringLength(255)]
        public string DiagramFileName { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDiagrams")]
        public virtual Order Order { get; set; }
    }
}
