using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Issues
    {
        [Column("Id")]
        public int Id { get; set; }
        public int AddedByUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateAdded { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
        [Column("StatusId")]
        public int StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
    }
}
