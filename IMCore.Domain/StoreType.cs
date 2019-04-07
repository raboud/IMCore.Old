using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class StoreType
    {
        public StoreType()
        {
            ClientTypeReports = new HashSet<ClientTypeReports>();
            MaterialType = new HashSet<MaterialType>();
            Stores = new HashSet<Stores>();
        }

        [Column("StoreTypeId")]
        public int StoreTypeId { get; set; }
        [StringLength(50)]
        public string StoreTypeName { get; set; }
        [StringLength(50)]
        public string ImageName { get; set; }
        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }
        [Column("QBClass")]
        [StringLength(50)]
        public string Qbclass { get; set; }

        [InverseProperty("ClientType")]
        public virtual ICollection<ClientTypeReports> ClientTypeReports { get; set; }
        [InverseProperty("StoreType")]
        public virtual ICollection<MaterialType> MaterialType { get; set; }
        [InverseProperty("StoreType")]
        public virtual ICollection<Stores> Stores { get; set; }
    }
}
