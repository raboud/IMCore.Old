using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SOSIScheduleWillCallDocuments")]
    public partial class SosischeduleWillCallDocuments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        public int WillCallLineNumber { get; set; }
        [Required]
        public bool? Scheduled { get; set; }
    }
}
