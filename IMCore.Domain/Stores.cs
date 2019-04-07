using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Stores
    {
        public Stores()
        {
            BasicCost = new HashSet<BasicCost>();
            BasicPrice = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            BasicRetail = new HashSet<BasicRetail>();
            DepartmentsStoresAssignments = new HashSet<DepartmentsStoresAssignments>();
            ItemCosting = new HashSet<ItemCosting>();
            ItemMatCosting = new HashSet<ItemMatCosting>();
            ItemPricing = new HashSet<ItemPricing>();
            MaterialCost = new HashSet<MaterialCost>();
            MaterialPrice = new HashSet<MaterialPrice>();
            OptionCost = new HashSet<OptionCost>();
            OptionPrice = new HashSet<OptionPrice>();
            OptionPricingOld = new HashSet<OptionPricingOld>();
            OptionRetail = new HashSet<OptionRetail>();
            StoreContacts = new HashSet<StoreContacts>();
        }

        [Key]
        [Column("StoreID")]
        public int StoreId { get; set; }
        [Column("StoreTypeID")]
        public int StoreTypeId { get; set; }
        [StringLength(50)]
        public string StoreNumber { get; set; }
        [StringLength(255)]
        public string BillingAddress { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [StringLength(30)]
        public string StorePhoneNumber { get; set; }
        [StringLength(30)]
        public string DirectPhoneNumber { get; set; }
        [StringLength(30)]
        public string Extension { get; set; }
        [StringLength(30)]
        public string FaxNumber { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        public int MarketId { get; set; }
        [Required]
        public bool? Active { get; set; }
        [StringLength(50)]
        public string StoreNickName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public short? MarketNumber { get; set; }
        [Column("XMLSourceID")]
        public int XmlsourceId { get; set; }
        [Required]
        public bool? IncludeInStatusReportAll { get; set; }
        [Column("AccountRepID")]
        public int? AccountRepId { get; set; }
        [Column("AccountCoorID")]
        public int? AccountCoorId { get; set; }

        [ForeignKey("AccountCoorId")]
        [InverseProperty("StoresAccountCoor")]
        public virtual Employees AccountCoor { get; set; }
        [ForeignKey("AccountRepId")]
        [InverseProperty("StoresAccountRep")]
        public virtual Employees AccountRep { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("Stores")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreTypeId")]
        [InverseProperty("Stores")]
        public virtual StoreType StoreType { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<BasicCost> BasicCost { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<BasicPrice> BasicPrice { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<BasicRetail> BasicRetail { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<DepartmentsStoresAssignments> DepartmentsStoresAssignments { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<ItemCosting> ItemCosting { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<ItemMatCosting> ItemMatCosting { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<ItemPricing> ItemPricing { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<OptionCost> OptionCost { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<OptionPrice> OptionPrice { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<OptionPricingOld> OptionPricingOld { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<OptionRetail> OptionRetail { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<StoreContacts> StoreContacts { get; set; }
    }
}
