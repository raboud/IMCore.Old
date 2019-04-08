using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("StoreContacts")]
    public partial class ClientContact
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column("DepartmentId")]
        public int? DepartmentId { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [Column("TitleId")]
        public int? TitleId { get; set; }
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(30)]
        public string AltPhoneNumber { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        public bool EmailStatusReport { get; set; }
        public bool EmailBilling { get; set; }
        public bool EmailNotes { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("StoreContacts")]
        public virtual Department Department { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("StoreContacts")]
        public virtual Client Store { get; set; }
    }
}
