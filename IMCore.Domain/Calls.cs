using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Calls
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public short Location { get; set; }
        public short SpokeWith { get; set; }
        [Column(TypeName = "text")]
        public string Other { get; set; }
        [Column(TypeName = "text")]
        public string Comments { get; set; }
        public bool CustomerToCallBack { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Time { get; set; }
        [Required]
        public bool? Schedule { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduledDate { get; set; }
        [Column("ScheduledAM")]
        public bool? ScheduledAm { get; set; }
        [Required]
        public bool? Unscheduled { get; set; }
        [Column("uid")]
        public short? Uid { get; set; }
        public bool? NeedLabor { get; set; }
        public bool? NeedColor { get; set; }
        public bool? NeedStyle { get; set; }
        public bool? NeedPadding { get; set; }
        public bool? NeedDrawings { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("Calls")]
        public virtual Orders Order { get; set; }
    }
}
