﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActivityTypes
    {
        public ActivityTypes()
        {
            ActivityList = new HashSet<ActivityList>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool RequirePermissionToView { get; set; }

        [InverseProperty("ActivityType")]
        public virtual ICollection<ActivityList> ActivityList { get; set; }
    }
}