using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MeasureCompOrderData")]
    public partial class MeasureCompOrder
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        public bool? Heat { get; set; }
        public bool? Pets { get; set; }
        public bool? Electricity { get; set; }
        public bool? FurnitureMoving { get; set; }
        public bool? NewPaint { get; set; }
        public bool? Removal { get; set; }
        public bool? PavedDriveway { get; set; }
        public bool? Garage { get; set; }
        public bool? Elevator { get; set; }
        [StringLength(100)]
        public string Disposal { get; set; }
        [StringLength(100)]
        public string Access { get; set; }
        [StringLength(100)]
        public string SiteType { get; set; }
        [StringLength(50)]
        public string MetalColor { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("MeasureCompOrderData")]
        public virtual Order Order { get; set; }
    }
}
