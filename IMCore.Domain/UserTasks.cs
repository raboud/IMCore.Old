using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserTasks
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
