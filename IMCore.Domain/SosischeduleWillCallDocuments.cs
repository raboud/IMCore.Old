using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SOSIScheduleWillCallDocuments")]
    public partial class SosischeduleWillCallDocuments
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        public int WillCallLineNumber { get; set; }
        [Required]
        public bool? Scheduled { get; set; }
    }
}
