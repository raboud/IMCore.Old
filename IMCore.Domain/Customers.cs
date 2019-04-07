using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Customers
    {
        public Customers()
        {
            MeasureCompCustData = new HashSet<MeasureCompCustData>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
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
        [Column("QBCustomerID")]
        [StringLength(50)]
        public string QbcustomerId { get; set; }
        [Column("AddressID")]
        public int? AddressId { get; set; }
        [StringLength(102)]
        public string Name { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Customers")]
        public virtual Address AddressNavigation { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MeasureCompCustData> MeasureCompCustData { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
