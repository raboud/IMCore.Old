using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ContactTitles
    {
        public ContactTitles()
        {
            DepartmentsContactTitles = new HashSet<DepartmentsContactTitles>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }

        [InverseProperty("ContactTitles")]
        public virtual ICollection<DepartmentsContactTitles> DepartmentsContactTitles { get; set; }
    }
}
