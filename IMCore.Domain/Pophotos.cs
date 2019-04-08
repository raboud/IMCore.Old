using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("POPhotos")]
    public partial class POPhoto
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string FilePath { get; set; }
        [Column("EnteredByUserId")]
        public int? EnteredByUserId { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        public bool Deleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeEntered { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("Pophotos")]
        public virtual Order Order { get; set; }
    }
}
