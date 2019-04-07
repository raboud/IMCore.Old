using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            BasicLabor = new HashSet<BasicLabor>();
            MaterialCost = new HashSet<MaterialCost>();
            MaterialPrice = new HashSet<MaterialPrice>();
            MaterialTypesMarketMapping = new HashSet<MaterialTypesMarketMapping>();
            Options = new HashSet<Options>();
            Orders = new HashSet<Orders>();
            ProgramReport = new HashSet<ProgramReport>();
        }

        [Column("MaterialTypeID")]
        public int MaterialTypeId { get; set; }
        [Column("StoreTypeID")]
        public int? StoreTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? MinimumPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? MinimumCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? MinimumRetail { get; set; }
        public double? CustomMultiplier { get; set; }
        public double? TripChargeMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
        public bool? Valid { get; set; }
        public bool? OnlyBasicToMinimum { get; set; }
        [StringLength(20)]
        public string ShortName { get; set; }
        [Column("DivisionID")]
        public int? DivisionId { get; set; }
        public bool? Active { get; set; }
        public bool Furnish { get; set; }
        [Required]
        [Column("SKU")]
        [StringLength(12)]
        public string Sku { get; set; }
        [Required]
        [Column("SKUDesc")]
        [StringLength(255)]
        public string Skudesc { get; set; }
        [Required]
        [Column("HDType")]
        [StringLength(1)]
        public string Hdtype { get; set; }
        [Required]
        [StringLength(277)]
        public string MaterialTypeName { get; set; }
        public bool InsuranceReplacement { get; set; }
        public bool AllowMaterialStatusUpdate { get; set; }
        [Column("JobTypeID")]
        public int? JobTypeId { get; set; }
        public bool WoodWaiver { get; set; }
        [Required]
        public bool? CustomCostByRetail { get; set; }
        public int? MarkDown { get; set; }
        public int? MarkDownMin { get; set; }
        public int? MarkDownMax { get; set; }

        [ForeignKey("DivisionId")]
        [InverseProperty("MaterialType")]
        public virtual Division Division { get; set; }
        [ForeignKey("JobTypeId")]
        [InverseProperty("MaterialType")]
        public virtual JobTypes JobType { get; set; }
        [ForeignKey("StoreTypeId")]
        [InverseProperty("MaterialType")]
        public virtual StoreType StoreType { get; set; }
        [InverseProperty("MaterialType")]
        public virtual ICollection<BasicLabor> BasicLabor { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
        [InverseProperty("MaterialType")]
        public virtual ICollection<MaterialTypesMarketMapping> MaterialTypesMarketMapping { get; set; }
        [InverseProperty("MaterialType")]
        public virtual ICollection<Options> Options { get; set; }
        [InverseProperty("MaterialType")]
        public virtual ICollection<Orders> Orders { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<ProgramReport> ProgramReport { get; set; }
    }
}
