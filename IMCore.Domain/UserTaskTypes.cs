using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class UserTaskTypes
    {
        public UserTaskTypes()
        {
            UserTasks = new HashSet<UserTasks>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int? Priority { get; set; }

        [InverseProperty("UserTaskType")]
        public virtual ICollection<UserTasks> UserTasks { get; set; }
    }
}
