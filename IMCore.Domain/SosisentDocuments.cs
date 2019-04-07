using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SOSISentDocuments")]
    public partial class SosisentDocuments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DocTypeID")]
        public int DocTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string MatchField1 { get; set; }
        [Required]
        [StringLength(255)]
        public string MatchField2 { get; set; }
        [Required]
        [StringLength(255)]
        public string MatchField3 { get; set; }
        public bool Acknowledged { get; set; }
        [StringLength(255)]
        public string DocumentFileName { get; set; }
    }
}
