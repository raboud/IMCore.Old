using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Market
    {
        public Market()
        {
            BasicCost = new HashSet<BasicCost>();
            BasicPrice = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            BasicRetail = new HashSet<BasicRetail>();
            InstallationCrew = new HashSet<InstallationCrew>();
            ItemCosting = new HashSet<ItemCosting>();
            ItemMatCosting = new HashSet<ItemMatCosting>();
            ItemPricing = new HashSet<ItemPricing>();
            MaterialCost = new HashSet<MaterialCost>();
            MaterialPrice = new HashSet<MaterialPrice>();
            MaterialTypesMarketMapping = new HashSet<MaterialTypesMarketMapping>();
            OptionCost = new HashSet<OptionCost>();
            OptionPrice = new HashSet<OptionPrice>();
            OptionPricingOld = new HashSet<OptionPricingOld>();
            OptionRetail = new HashSet<OptionRetail>();
            Stores = new HashSet<Stores>();
            UserMarketDivisionAssignments = new HashSet<UserMarketDivisionAssignments>();
            UserPermissions = new HashSet<UserPermissions>();
        }

        public int MarketId { get; set; }
        [Required]
        [StringLength(40)]
        public string MarketName { get; set; }
        [StringLength(50)]
        public string PrinterName { get; set; }
        [StringLength(50)]
        public string PrinterPort { get; set; }
        [StringLength(50)]
        public string PrinterDriver { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(13)]
        public string PhoneNumber { get; set; }
        [StringLength(13)]
        public string FaxNumber { get; set; }
        [Column("ManagerId")]
        public int? ManagerId { get; set; }
        [Required]
        public bool? Active { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string LabelPrinter { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("Market")]
        public virtual Employees Manager { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicCost> BasicCost { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicPrice> BasicPrice { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicRetail> BasicRetail { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<InstallationCrew> InstallationCrew { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<ItemCosting> ItemCosting { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<ItemMatCosting> ItemMatCosting { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<ItemPricing> ItemPricing { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<MaterialTypesMarketMapping> MaterialTypesMarketMapping { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionCost> OptionCost { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionPrice> OptionPrice { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<OptionPricingOld> OptionPricingOld { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionRetail> OptionRetail { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<Stores> Stores { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
