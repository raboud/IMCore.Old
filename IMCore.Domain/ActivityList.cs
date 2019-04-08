using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("ActivityList")]
    public partial class Activity
    {
        public Activity()
        {
            ActivityData = new HashSet<ActivityData>();
            ActivityPonoteMapping = new HashSet<ActivityPonoteMapping>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("ActivityTypeId")]
        public int ActivityTypeId { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedById")]
        public int? CreatedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FollowUpDate { get; set; }
        [Column("ClosedById")]
        public int? ClosedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosedDate { get; set; }

        [ForeignKey("ActivityTypeId")]
        [InverseProperty("ActivityList")]
        public virtual ActivityTypes ActivityType { get; set; }
        [ForeignKey("ClosedById")]
        [InverseProperty("ActivityListClosedBy")]
        public virtual User ClosedBy { get; set; }
        [ForeignKey("CreatedById")]
        [InverseProperty("ActivityListCreatedBy")]
        public virtual User CreatedBy { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("ActivityList")]
        public virtual Order Order { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ActivityData> ActivityData { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ActivityPonoteMapping> ActivityPonoteMapping { get; set; }
    }
}
