using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("PONotes")]
    public partial class PONote
    {
        public PONote()
        {
            ActivityPonoteMapping = new HashSet<ActivityPonoteMapping>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("NoteTypeId")]
        public int NoteTypeId { get; set; }
        [Column("SpokeWithId")]
        public int SpokeWithId { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeEntered { get; set; }
        public string NoteText { get; set; }
        [Column("EnteredByUserId")]
        public int? EnteredByUserId { get; set; }
        public bool CustomerToCallBack { get; set; }
        public bool Scheduled { get; set; }
        public bool UnScheduled { get; set; }
        [Column("ScheduledAM")]
        public bool? ScheduledAM { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ScheduledDate { get; set; }
        public bool Deleted { get; set; }
        [Column("SentViaXML")]
        public bool SentViaXML { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeSent { get; set; }

		[ForeignKey("EnteredByUserId")]
		[InverseProperty("Ponotes")]
		public virtual User EnteredByUser { get; set; }

        public virtual SpokeWith SpokeWith { get; set; }

        [ForeignKey("NoteTypeId")]
        [InverseProperty("Ponotes")]
        public virtual NoteType NoteType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("Ponotes")]
        public virtual Order Order { get; set; }
        [InverseProperty("Ponote")]
        public virtual ICollection<ActivityPonoteMapping> ActivityPonoteMapping { get; set; }
    }
}
