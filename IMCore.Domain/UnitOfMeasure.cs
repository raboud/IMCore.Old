﻿using System;
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
            Materials = new HashSet<Material>();
            Options = new HashSet<Option>();
            OrderCustomDetails = new HashSet<OrderCustom>();
            OrderRegMerchandiseDetails = new HashSet<OrderRegMerchandise>();
            OrderSomerchandiseDetails = new HashSet<OrderSOMerchandiseDetail>();
        }

        [Column("UnitOfMeasureId")]
        public int Id { get; set; }
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
        public virtual ICollection<Material> Materials { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<Option> Options { get; set; }
        [InverseProperty("UnitOfMeasure")]
        public virtual ICollection<OrderCustom> OrderCustomDetails { get; set; }
        [InverseProperty("Uom")]
        public virtual ICollection<OrderRegMerchandise> OrderRegMerchandiseDetails { get; set; }
        [InverseProperty("Uom")]
        public virtual ICollection<OrderSOMerchandiseDetail> OrderSomerchandiseDetails { get; set; }
    }
}
