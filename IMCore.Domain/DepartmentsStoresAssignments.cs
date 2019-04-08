using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class DepartmentsStoresAssignments
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column("DepartmentId")]
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
        public virtual Department Department { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("DepartmentsStoresAssignments")]
        public virtual Client Store { get; set; }
    }
}
