using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Division
    {
        public Division()
        {
            ItemCosting = new HashSet<ItemCosting>();
            Programs = new HashSet<Program>();
            UserMarketDivisionAssignments = new HashSet<UserMarketDivisionAssignments>();
            UserPermissions = new HashSet<UserPermissions>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("Division")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("VendorId")]
        public int? VendorId { get; set; }
        [Column("DivisionGroupId")]
        public int DivisionGroupId { get; set; }
        [Required]
        public bool? PrintStatusReport { get; set; }
        [Required]
        public bool? MarkBilledWhenPaid { get; set; }
        [Required]
        public bool? Active { get; set; }

        [ForeignKey("DivisionGroupId")]
        [InverseProperty("Division")]
        public virtual DivisionGroups DivisionGroup { get; set; }
        [InverseProperty("Division")]
        public virtual ICollection<ItemCosting> ItemCosting { get; set; }
        [InverseProperty("Division")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("Division")]
        public virtual ICollection<UserMarketDivisionAssignments> UserMarketDivisionAssignments { get; set; }
        [InverseProperty("Division")]
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
