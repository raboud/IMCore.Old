using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class ActivityList
    {
        public ActivityList()
        {
            ActivityData = new HashSet<ActivityData>();
            ActivityPonoteMapping = new HashSet<ActivityPonoteMapping>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column("ActivityTypeID")]
        public int ActivityTypeId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedByID")]
        public int? CreatedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FollowUpDate { get; set; }
        [Column("ClosedByID")]
        public int? ClosedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosedDate { get; set; }

        [ForeignKey("ActivityTypeId")]
        [InverseProperty("ActivityList")]
        public virtual ActivityTypes ActivityType { get; set; }
        [ForeignKey("ClosedById")]
        [InverseProperty("ActivityListClosedBy")]
        public virtual Employees ClosedBy { get; set; }
        [ForeignKey("CreatedById")]
        [InverseProperty("ActivityListCreatedBy")]
        public virtual Employees CreatedBy { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("ActivityList")]
        public virtual Orders Order { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ActivityData> ActivityData { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ActivityPonoteMapping> ActivityPonoteMapping { get; set; }
    }
}
