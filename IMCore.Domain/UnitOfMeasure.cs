using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            BasicLabor = new HashSet<BasicLabor>();
            Item = new HashSet<Item>();
            MaterialCatagory = new HashSet<MaterialCatagory>();
            Options = new HashSet<Options>();
            OrderCustomDetails = new HashSet<OrderCustomDetails>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandiseDetails>();
            OrderSomerchandiseDetails = new HashSet<OrderSomerchandiseDetails>();
        }

        [Column("UnitOfMeasureId")]
        public int UnitOfMeasureId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public int Divisor { get; set; }
        public int? NumberOfDecimals { get; set; }
        [StringLength(50)]
        public string LongDescription { get; set; }
        [Column("LongDescriptionSOSI")]
        [StringLength(50)]
        public string LongDescriptionSosi { get; set; }

        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<BasicLabor> BasicLabor { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<Item> Item { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<MaterialCatagory> MaterialCatagory { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<Options> Options { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<OrderCustomDetails> OrderCustomDetails { get; set; }
        [InverseProperty("Uom")]
        public virtual ICollection<OrderRegMerchandiseDetails> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("Uom")]
        public virtual ICollection<OrderSomerchandiseDetails> OrderSomerchandiseDetails { get; set; }
    }
}
