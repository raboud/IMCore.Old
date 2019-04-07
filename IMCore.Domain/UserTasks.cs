using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserTasks
    {
        [Key]
        [Column("UserTaskID")]
        public int UserTaskId { get; set; }
        [Column("JobID")]
        public int? JobId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("UserTaskTypeID")]
        public int UserTaskTypeId { get; set; }
        [Column("AddedByID")]
        public int AddedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddedDate { get; set; }
        [Column("AssignedToID")]
        public int? AssignedToId { get; set; }
        [Column("CompletedByID")]
        public int? CompletedById { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        [Column("OrderID")]
        public int? OrderId { get; set; }

        [ForeignKey("AddedById")]
        [InverseProperty("UserTasksAddedBy")]
        public virtual Employees AddedBy { get; set; }
        [ForeignKey("AssignedToId")]
        [InverseProperty("UserTasksAssignedTo")]
        public virtual Employees AssignedTo { get; set; }
        [ForeignKey("CompletedById")]
        [InverseProperty("UserTasksCompletedBy")]
        public virtual Employees CompletedBy { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("UserTasks")]
        public virtual Orders Order { get; set; }
        [ForeignKey("UserTaskTypeId")]
        [InverseProperty("UserTasks")]
        public virtual UserTaskTypes UserTaskType { get; set; }
    }
}
