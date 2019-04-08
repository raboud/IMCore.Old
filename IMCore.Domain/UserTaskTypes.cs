using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("UserTaskTypes")]
    public partial class UserTaskType
    {
        public UserTaskType()
        {
            UserTasks = new HashSet<UserTask>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int? Priority { get; set; }

        [InverseProperty("UserTaskType")]
        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
