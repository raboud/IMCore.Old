using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SPNActionQueue")]
    public partial class SpnactionQueue
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ActionId")]
        public int ActionId { get; set; }
        [StringLength(50)]
        public string DataField1 { get; set; }
        [StringLength(50)]
        public string DataField2 { get; set; }
        [StringLength(50)]
        public string DataField3 { get; set; }
        [StringLength(50)]
        public string DataField4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendAfter { get; set; }
        [Required]
        public bool? Processed { get; set; }

        [ForeignKey("ActionId")]
        [InverseProperty("SpnactionQueue")]
        public virtual Spnactions Action { get; set; }
    }
}
