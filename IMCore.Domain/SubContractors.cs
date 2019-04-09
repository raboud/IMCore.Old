using IMCore.TypesAndInterfaces.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("SubContractors")]
    public partial class SubContractor
    {
        public SubContractor()
        {
            Bill = new HashSet<Bill>();
            BillDetails = new HashSet<BillDetail>();
            InstallationCrewLead = new HashSet<InstallationCrew>();
            InstallationCrewOwner = new HashSet<InstallationCrew>();
            OrderCustomDetails = new HashSet<OrderCustom>();
            Payroll = new HashSet<Payroll>();
        }

        [Key]
        [Column("SubContractorId")]
        public int SubContractorId { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [StringLength(30)]
        public string HomePhoneNumber { get; set; }
        [StringLength(30)]
        public string CellPhoneNumber { get; set; }
        [StringLength(30)]
        public string Pager { get; set; }
        [Column("SSN")]
        [StringLength(50)]
        public string Ssn { get; set; }
        [Column("WorkmansCompInsuranceOK")]
        public bool? WorkmansCompInsuranceOk { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BackgroundChkDateApproved { get; set; }
        public bool BackgroundCheckPassed { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        [Column(TypeName = "money")]
        public decimal? Retainage { get; set; }
        public double? SavingsRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? RetainageRate { get; set; }
        [Required]
        public bool? Helper { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InsuranceRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InsuranceDollarAmount { get; set; }
        [StringLength(50)]
        public string BadgeStatus { get; set; }
        [Required]
        public bool? BackgroundRptRequested { get; set; }
        public int? AssignedTo { get; set; }
        public int? BranchId { get; set; }
        public int Status { get; set; }
        [Column("StateId")]
        public int StateId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WorkmansCompInsuranceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LiabilityInsuranceDate { get; set; }
        [StringLength(255)]
        public string PictureFilename { get; set; }
        [Column("LiabilityInsuranceOK")]
        public bool? LiabilityInsuranceOk { get; set; }
        [Column("QBSubContractorId")]
        [StringLength(50)]
        public string QbsubContractorId { get; set; }
        [Required]
        [StringLength(82)]
        public string Name { get; set; }

		[ForeignKey("BranchId")]
		public Branch Branch { get; set; }

        [InverseProperty("Owner")]
        public virtual ICollection<Bill> Bill { get; set; }
        [InverseProperty("BackChargeOwner")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        [InverseProperty("Lead")]
        public virtual ICollection<InstallationCrew> InstallationCrewLead { get; set; }
        [InverseProperty("Owner")]
        public virtual ICollection<InstallationCrew> InstallationCrewOwner { get; set; }
        [InverseProperty("SubContractor")]
        public virtual ICollection<OrderCustom> OrderCustomDetails { get; set; }
        [InverseProperty("SubContractor")]
        public virtual ICollection<Payroll> Payroll { get; set; }

		[NotMapped]
		public string LastNameCommaFirstName
		{
			get
			{
				return (LastName.IsEmpty() ? "" : (LastName + ", ")) + (FirstName.IsEmpty() ? "" : FirstName);
			}
		}

		[NotMapped]
		public bool LiabilityExpired
		{
			get
			{
				return this.LiabilityInsuranceDate == null || (this.LiabilityInsuranceDate.Value < DateTime.Now) || !(this.LiabilityInsuranceOk ?? false);
			}
		}

		[NotMapped]
		public bool WorkmansCompExpired
		{
			get
			{
				return this.WorkmansCompInsuranceDate == null || (this.WorkmansCompInsuranceDate < DateTime.Now) || !(this.WorkmansCompInsuranceOk ?? false);
			}
		}

	}
}
