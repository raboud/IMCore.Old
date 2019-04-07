using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActionQueue
    {
        public int Id { get; set; }
        public Guid? Type { get; set; }
        [Column(TypeName = "xml")]
        public string Data { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Start { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expire { get; set; }
    }
}
