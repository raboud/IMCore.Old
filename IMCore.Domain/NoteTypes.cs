using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	[Table("NoteTypes")]
    public partial class NoteType
    {
        public NoteType()
        {
            Ponotes = new HashSet<PONote>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string NoteTypeDescription { get; set; }
        public bool ShowInList { get; set; }
        public bool ShowEmployees { get; set; }
        public bool ShowSpokeWith { get; set; }
        public bool RequireSpokeWith { get; set; }
        public bool EnableSchedulingInfo { get; set; }
        public bool CanSendToExpeditor { get; set; }
        [Required]
        public bool? ShowStoreManagement { get; set; }
        [Required]
        public bool? PermissionRequiredToSelect { get; set; }
        public byte? DisplayOrder { get; set; }

        [InverseProperty("NoteType")]
        public virtual ICollection<PONote> Ponotes { get; set; }
    }
}
