using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("OrderSOMerchandiseDetails")]
    public partial class OrderSomerchandiseDetails
    {
        public OrderSomerchandiseDetails()
        {
            Sodocument = new HashSet<Sodocument>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("SONumber")]
        [StringLength(10)]
        public string Sonumber { get; set; }
        [Column("SKUNumber")]
        [StringLength(12)]
        public string Skunumber { get; set; }
        [Column("BasicLaborId")]
        public int? BasicLaborId { get; set; }
        [StringLength(100)]
        public string ShortDescription { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Quantity { get; set; }
        [Column("UOMId")]
        public int? Uomid { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpectedArrivalDate { get; set; }
        [Column("SOLineNumber")]
        public int? SolineNumber { get; set; }
        [Column("MaterialStatusId")]
        public int? MaterialStatusId { get; set; }
        [Column("EntryMethodId")]
        public int EntryMethodId { get; set; }
        public bool Deleted { get; set; }
        public int? TransferredTo { get; set; }
        public int? TransferredFrom { get; set; }
        [Column("SOMerLineNumber")]
        public int? SomerLineNumber { get; set; }
        [Column("OriginalId")]
        public int? OriginalId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PreSplitQty { get; set; }
        [Column("XMLStatusId")]
        public int? XmlstatusId { get; set; }
        public bool Reviewed { get; set; }
        [Column("ReviewedById")]
        public int? ReviewedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedDate { get; set; }
        public int? WillCallLineNumber { get; set; }
        [Column("OriginalOrderId")]
        public int? OriginalOrderId { get; set; }
        public bool NotNeeded { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Received { get; set; }

        [ForeignKey("EntryMethodId")]
        [InverseProperty("OrderSomerchandiseDetails")]
        public virtual EntryMethod EntryMethod { get; set; }
        [ForeignKey("MaterialStatusId")]
        [InverseProperty("OrderSomerchandiseDetails")]
        public virtual MaterialStatus MaterialStatus { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("OrderSomerchandiseDetails")]
        public virtual Orders Order { get; set; }
        [ForeignKey("ReviewedById")]
        [InverseProperty("OrderSomerchandiseDetails")]
        public virtual Employees ReviewedBy { get; set; }
        [ForeignKey("Uomid")]
        [InverseProperty("OrderSomerchandiseDetails")]
        public virtual UnitOfMeasure Uom { get; set; }
        [InverseProperty("So")]
        public virtual ICollection<Sodocument> Sodocument { get; set; }
    }
}
