using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("PrintedPOData")]
    public partial class PrintedPodata
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PONumber")]
        [StringLength(8)]
        public string Ponumber { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column(TypeName = "text")]
        public string Data { get; set; }
        public bool? Printed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimePrinted { get; set; }
    }
}
