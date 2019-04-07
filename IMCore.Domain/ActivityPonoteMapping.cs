using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("ActivityPONoteMapping")]
    public partial class ActivityPonoteMapping
    {
        [Column("ActivityId")]
        public int ActivityId { get; set; }
        [Column("PONoteId")]
        public int PonoteId { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("ActivityPonoteMapping")]
        public virtual ActivityList Activity { get; set; }
        [ForeignKey("PonoteId")]
        [InverseProperty("ActivityPonoteMapping")]
        public virtual Ponotes Ponote { get; set; }
    }
}
