using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class StoreContacts
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [Column("TitleID")]
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
        public virtual Departments Department { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("StoreContacts")]
        public virtual Stores Store { get; set; }
    }
}
