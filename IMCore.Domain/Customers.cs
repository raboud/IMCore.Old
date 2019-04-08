using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
