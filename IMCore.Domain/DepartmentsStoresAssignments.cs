using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DepartmentsStoresAssignments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("StoreID")]
        public int? StoreId { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [StringLength(30)]
        public string FaxNumber { get; set; }
        [StringLength(1024)]
        public string Notes { get; set; }
        [StringLength(30)]
        public string AltFaxNumber { get; set; }
        public int? FaxStatusReportTo { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("DepartmentsStoresAssignments")]
        public virtual Departments Department { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("DepartmentsStoresAssignments")]
        public virtual Stores Store { get; set; }
    }
}
