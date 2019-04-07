using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActivityData
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [StringLength(1024)]
        public string Data { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("ActivityData")]
        public virtual ActivityList Activity { get; set; }
    }
}
