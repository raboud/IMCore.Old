using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("MeasureCompCustData")]
    public partial class MeasureCompCustomers
    {
		[Column("Id")]
        public int Id { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }
        [StringLength(50)]
        public string HomePhone { get; set; }
        [StringLength(50)]
        public string BusinessPhone { get; set; }
        [StringLength(50)]
        public string CellPhone { get; set; }
        [StringLength(50)]
        public string Pager { get; set; }
        [StringLength(100)]
        public string CrossStreetDir1 { get; set; }
        [StringLength(100)]
        public string CrossStreet1 { get; set; }
        [StringLength(50)]
        public string CrossStreetDir2 { get; set; }
        [StringLength(50)]
        public string CrossStreet2 { get; set; }
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("MeasureCompCustData")]
        public virtual Customer Customer { get; set; }
    }
}
