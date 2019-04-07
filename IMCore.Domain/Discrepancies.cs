using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Discrepancies
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DiscrepancyTypeID")]
        public int? DiscrepancyTypeId { get; set; }
        [Column("DiscrepancySubTypeID")]
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
        [Column("OrderID")]
        public int? OrderId { get; set; }
        [Column("DetailID")]
        public int? DetailId { get; set; }
        [Required]
        public bool? Reviewed { get; set; }
        [Column("ReviewedByID")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateReviewed { get; set; }

        [ForeignKey("DiscrepancyTypeId")]
        [InverseProperty("Discrepancies")]
        public virtual DiscrepancyType DiscrepancyType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("Discrepancies")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("Discrepancies")]
        public virtual Employees ReviewedBy { get; set; }
    }
}
