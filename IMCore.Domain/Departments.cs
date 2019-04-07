using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Departments
    {
        public Departments()
        {
            DepartmentsContactTitles = new HashSet<DepartmentsContactTitles>();
            DepartmentsStoresAssignments = new HashSet<DepartmentsStoresAssignments>();
            StoreContacts = new HashSet<StoreContacts>();
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
        public virtual ICollection<StoreContacts> StoreContacts { get; set; }
    }
}
