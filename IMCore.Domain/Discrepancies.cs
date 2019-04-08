using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Discrepancies")]
    public partial class Discrepancy
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("DiscrepancyTypeId")]
        public int? DiscrepancyTypeId { get; set; }
        [Column("DiscrepancySubTypeId")]
        public int? DiscrepancySubTypeId { get; set; }
        [StringLength(1024)]
        public string CurrentData { get; set; }
        [StringLength(1024)]
        public string NewData { get; set; }
        [Required]
        [Column("XMLFilePath")]
        [StringLength(1024)]
        public string XmlfilePath { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateFound { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }
        [Column("DetailId")]
        public int? DetailId { get; set; }
        [Required]
        public bool? Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateReviewed { get; set; }

        [ForeignKey("DiscrepancyTypeId")]
        [InverseProperty("Discrepancies")]
        public virtual DiscrepancyType DiscrepancyType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("Discrepancies")]
        public virtual Order Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("Discrepancies")]
        public virtual User ReviewedBy { get; set; }

		[ForeignKey("DiscrepancySubTypeId")]
		public virtual DiscrepancySubType DiscrepancySubType { get; set; }

	}
}
