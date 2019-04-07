﻿using System;
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

        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CrewName { get; set; }
        [Column("OwnerID")]
        public int OwnerId { get; set; }
        [Column("LeadID")]
        public int LeadId { get; set; }
        [Column("BranchID")]
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public bool InstallationManager { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("InstallationCrew")]
        public virtual Market Branch { get; set; }
        [ForeignKey("LeadId")]
        [InverseProperty("InstallationCrewLead")]
        public virtual SubContractors Lead { get; set; }
        [ForeignKey("OwnerId")]
        [InverseProperty("InstallationCrewOwner")]
        public virtual SubContractors Owner { get; set; }
        [InverseProperty("Crew")]
        public virtual ICollection<InstallationCrewType> InstallationCrewType { get; set; }
        [InverseProperty("Crew")]
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
    }
}