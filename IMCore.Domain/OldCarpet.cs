using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class OldCarpet
    {
        public int Id { get; set; }
        [Column("PoNumber_Original")]
        [StringLength(8)]
        public string PoNumberOriginal { get; set; }
        [StringLength(8)]
        public string SoNumber { get; set; }
        [Column("PoNumber_Replacement")]
        [StringLength(8)]
        public string PoNumberReplacement { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(4)]
        public string Store { get; set; }
        public int? MaterialStatusId { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
    }
}
