using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customers>();
            Orders = new HashSet<Orders>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("Address")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(13)]
        public string PhoneNumber1 { get; set; }
        [StringLength(13)]
        public string PhoneNumber2 { get; set; }
        [Column(TypeName = "text")]
        public string Notes { get; set; }
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [InverseProperty("AddressNavigation")]
        public virtual ICollection<Customers> Customers { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
