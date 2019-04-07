using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DepartmentsContactTitles
    {
        [Column("DepartmentsId")]
        public int DepartmentsId { get; set; }
        [Column("ContactTitlesId")]
        public int ContactTitlesId { get; set; }
        public bool? Required { get; set; }

        [ForeignKey("ContactTitlesId")]
        [InverseProperty("DepartmentsContactTitles")]
        public virtual ContactTitles ContactTitles { get; set; }
        [ForeignKey("DepartmentsId")]
        [InverseProperty("DepartmentsContactTitles")]
        public virtual Departments Departments { get; set; }
    }
}
