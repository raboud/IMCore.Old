using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
	

	[Table("StoreType")]
	public partial class ClientType
    {
        public ClientType()
        {
            ClientTypeReports = new HashSet<ClientTypeReport>();
            Programs = new HashSet<Program>();
            Stores = new HashSet<Client>();
        }

        [Column("StoreTypeId")]
        public int Id { get; set; }
        [StringLength(50)]
		[Column("StoreTypeName")]
        public string Name { get; set; }
        [StringLength(50)]
        public string ImageName { get; set; }
        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }
        [Column("QBClass")]
        [StringLength(50)]
        public string Qbclass { get; set; }

        [InverseProperty("ClientType")]
        public virtual ICollection<ClientTypeReport> ClientTypeReports { get; set; }
        [InverseProperty("StoreType")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("StoreType")]
        public virtual ICollection<Client> Stores { get; set; }
    }
}
