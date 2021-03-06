﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("SPNImportedPOs")]
    public partial class SpnimportedPos
    {
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("PONumber")]
        [StringLength(50)]
        public string Ponumber { get; set; }
        [Column("StoreId")]
        public int StoreId { get; set; }
        [Column("POStatusId")]
        public int PostatusId { get; set; }
        [Required]
        [Column("XMLFilePath")]
        [StringLength(1024)]
        public string XmlfilePath { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateImported { get; set; }
    }
}
