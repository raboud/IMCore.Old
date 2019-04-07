using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class CompanyInfo
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        [StringLength(13)]
        public string Phone1 { get; set; }
        [StringLength(13)]
        public string Phone2 { get; set; }
        [StringLength(13)]
        public string Fax1 { get; set; }
        [StringLength(13)]
        public string Fax2 { get; set; }
        [StringLength(15)]
        public string VendorNumber { get; set; }
        [Column(TypeName = "image")]
        public byte[] WaiverSignature { get; set; }
        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }
        [Column("QRCodePrefix")]
        [StringLength(1)]
        public string QrcodePrefix { get; set; }
        [StringLength(13)]
        public string TollFree { get; set; }
    }
}
