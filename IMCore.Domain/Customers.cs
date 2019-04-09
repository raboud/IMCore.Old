using IMCore.TypesAndInterfaces.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IMCore.Domain
{
	[Table("Customers")]
	public partial class Customer
    {
        public Customer()
        {
            MeasureCompCustData = new HashSet<MeasureCompCustomers>();
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
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
        [StringLength(50)]
        public string WorkNumber { get; set; }
        [Column(TypeName = "text")]
        public string Directions { get; set; }
        [StringLength(50)]
        public string Extension { get; set; }
        public int? LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDateTime { get; set; }
        [StringLength(13)]
        public string MobileNumber { get; set; }
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        [Column("QBCustomerId")]
        [StringLength(50)]
        public string QbcustomerId { get; set; }
        [Column("AddressId")]
        public int? AddressId { get; set; }
        [StringLength(102)]
        public string Name { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Customers")]
        public virtual Address AddressNavigation { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MeasureCompCustomers> MeasureCompCustData { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Order> Orders { get; set; }

		[NotMapped]
		public string LastNameCommaFirstName
		{
			get
			{
				return (LastName.IsEmpty() ? "" : (LastName.Trim() + ", ")) + (FirstName.IsEmpty() ? "" : FirstName.Trim());
			}
		}

		[NotMapped]
		public string FirstNameSpaceLastName
		{
			get
			{
				return (FirstName.IsEmpty() ? "" : (FirstName.Trim() + " ")) + (LastName.IsEmpty() ? "" : LastName.Trim()).Trim();
			}
		}

		public string GetFormattedSiteAddress()
		{
			StringBuilder formattedSiteAddress = new StringBuilder();

			formattedSiteAddress.AppendLine(this.Address.SafeTrim());
			if (this.Address2.IsValid())
			{
				formattedSiteAddress.AppendLine(this.Address2.SafeTrim());
			}
			formattedSiteAddress.AppendFormat("{0}, {1}  {2}\r\n", this.City.SafeTrim(),
												this.State.SafeTrim(), this.ZipCode.SafeTrim());

			return formattedSiteAddress.ToString();
		}

		public string GetFormattedCustomerAndSiteAddress()
		{
			StringBuilder formattedSiteAddress = new StringBuilder();
			if (!string.IsNullOrEmpty(this.CompanyName)) formattedSiteAddress.AppendLine(this.CompanyName);
			if (!string.IsNullOrEmpty(this.FirstNameSpaceLastName)) formattedSiteAddress.AppendLine(this.FirstNameSpaceLastName);
			formattedSiteAddress.AppendLine(this.Address.SafeTrim());
			if (this.Address2.IsValid())
			{
				formattedSiteAddress.AppendLine(this.Address2.SafeTrim());
			}
			formattedSiteAddress.AppendFormat("{0}, {1}  {2}\r\n", this.City.SafeTrim(),
												this.State.SafeTrim(), this.ZipCode.SafeTrim());

			formattedSiteAddress.Append("Email: ");
			formattedSiteAddress.Append(this.EmailAddress.IsValid()
											? this.EmailAddress.SafeTrim()
											: "<NO EMAIL ADDRESS ON FILE>");

			return formattedSiteAddress.ToString();
		}

		[NotMapped]
		public bool LastNameValid
		{
			get { return !string.IsNullOrEmpty(this.LastName) || !string.IsNullOrEmpty(this.CompanyName); }
		}

		[NotMapped]
		public bool FirstNameValid
		{
			get { return !string.IsNullOrEmpty(this.FirstName) || !string.IsNullOrEmpty(this.CompanyName); }
		}

		[NotMapped]
		public bool AddressValid
		{
			get { return !string.IsNullOrEmpty(this.Address); }
		}

		[NotMapped]
		public bool CityValid
		{
			get { return !string.IsNullOrEmpty(this.City); }
		}

		[NotMapped]
		public bool StateValid
		{
			get { return !string.IsNullOrEmpty(this.State); }
		}

		[NotMapped]
		public bool IsValid
		{
			get
			{
				return this.FirstNameValid && this.LastNameValid && this.AddressValid;
			}
		}
	}


}
