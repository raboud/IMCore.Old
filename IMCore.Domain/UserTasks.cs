using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("UserTasks")]
    public partial class UserTask
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("JobId")]
        public int? JobId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("UserTaskTypeId")]
        public int UserTaskTypeId { get; set; }
        [Column("AddedById")]
        public int AddedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddedDate { get; set; }
        [Column("AssignedToId")]
        public int? AssignedToId { get; set; }
        [Column("CompletedById")]
        public int? CompletedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }

        [ForeignKey("AddedById")]
        [InverseProperty("UserTasksAddedBy")]
        public virtual User AddedBy { get; set; }
        [ForeignKey("AssignedToId")]
        [InverseProperty("UserTasksAssignedTo")]
        public virtual User AssignedTo { get; set; }
        [ForeignKey("CompletedById")]
        [InverseProperty("UserTasksCompletedBy")]
        public virtual User CompletedBy { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("UserTasks")]
        public virtual Order Order { get; set; }
        [ForeignKey("UserTaskTypeId")]
        [InverseProperty("UserTasks")]
        public virtual UserTaskType UserTaskType { get; set; }
    }
}
