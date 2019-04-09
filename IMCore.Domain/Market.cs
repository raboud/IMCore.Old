using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Branch")]
    public partial class Branch
    {
        public Branch()
        {
            Costs = new HashSet<BasicCost>();
            Prices = new HashSet<BasicPrice>();
            BasicPricingOld = new HashSet<BasicPricingOld>();
            Retails = new HashSet<BasicRetail>();
            InstallationCrew = new HashSet<InstallationCrew>();
            ItemCosting = new HashSet<ItemCosting>();
            ItemMatCosting = new HashSet<ItemMatCosting>();
            ItemPricing = new HashSet<ItemPricing>();
            MaterialCost = new HashSet<MaterialCost>();
            MaterialPrice = new HashSet<MaterialPrice>();
            ProgramBranchMappings = new HashSet<ProgramBranchMapping>();
            OptionCost = new HashSet<OptionCost>();
            OptionPrice = new HashSet<OptionPrice>();
            OptionPricingOld = new HashSet<OptionPricingOld>();
            OptionRetail = new HashSet<OptionRetail>();
            Stores = new HashSet<Client>();
            UserBranchDivisionAssignments = new HashSet<UserBranchDivisionAssignment>();
            UserPermissions = new HashSet<UserPermissions>();
        }

		[Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
		[Column("Name")]
		public string Name { get; set; }
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
        [InverseProperty("Branches")]
        public virtual User Manager { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicCost> Costs { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicPrice> Prices { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicPricingOld> BasicPricingOld { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<BasicRetail> Retails { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<InstallationCrew> InstallationCrew { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<ItemCosting> ItemCosting { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<ItemMatCosting> ItemMatCosting { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<ItemPricing> ItemPricing { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<MaterialCost> MaterialCost { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<MaterialPrice> MaterialPrice { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<ProgramBranchMapping> ProgramBranchMappings { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionCost> OptionCost { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionPrice> OptionPrice { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionPricingOld> OptionPricingOld { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<OptionRetail> OptionRetail { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<Client> Stores { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<UserBranchDivisionAssignment> UserBranchDivisionAssignments { get; set; }
        [InverseProperty("Branch")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
