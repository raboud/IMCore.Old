using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class InstallationCrew
    {
        public InstallationCrew()
        {
            InstallationCrewType = new HashSet<InstallationCrewType>();
            WorkOrder = new HashSet<WorkOrder>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CrewName { get; set; }
        [Column("OwnerId")]
        public int OwnerId { get; set; }
        [Column("LeadId")]
        public int LeadId { get; set; }
        [Column("BranchId")]
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public bool InstallationManager { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("InstallationCrew")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("LeadId")]
        [InverseProperty("InstallationCrewLead")]
        public virtual SubContractor Lead { get; set; }
        [ForeignKey("OwnerId")]
        [InverseProperty("InstallationCrewOwner")]
        public virtual SubContractor Owner { get; set; }
        [InverseProperty("Crew")]
        public virtual ICollection<InstallationCrewType> InstallationCrewType { get; set; }
        [InverseProperty("Crew")]
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
