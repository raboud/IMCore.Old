using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("ActivityPONoteMapping")]
    public partial class ActivityPonoteMapping
    {
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("PONoteID")]
        public int PonoteId { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("ActivityPonoteMapping")]
        public virtual ActivityList Activity { get; set; }
        [ForeignKey("PonoteId")]
        [InverseProperty("ActivityPonoteMapping")]
        public virtual Ponotes Ponote { get; set; }
    }
}
