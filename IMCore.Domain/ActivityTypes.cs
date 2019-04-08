using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActivityTypes
    {
        public ActivityTypes()
        {
            ActivityList = new HashSet<Activity>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool RequirePermissionToView { get; set; }

        [InverseProperty("ActivityType")]
        public virtual ICollection<Activity> ActivityList { get; set; }
    }
}
