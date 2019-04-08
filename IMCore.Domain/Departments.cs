using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("Departments")]
    public partial class Department
    {
        public Department()
        {
            DepartmentsContactTitles = new HashSet<DepartmentsContactTitles>();
            DepartmentsStoresAssignments = new HashSet<DepartmentsStoresAssignments>();
            StoreContacts = new HashSet<ClientContact>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(30)]
        public string DepartmentName { get; set; }

        [InverseProperty("Departments")]
        public virtual ICollection<DepartmentsContactTitles> DepartmentsContactTitles { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<DepartmentsStoresAssignments> DepartmentsStoresAssignments { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<ClientContact> StoreContacts { get; set; }
    }
}
