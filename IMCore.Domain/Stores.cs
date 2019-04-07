using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Stores
    {
        public Stores()
        {
            DepartmentsStoresAssignments = new HashSet<DepartmentsStoresAssignments>();
            StoreContacts = new HashSet<StoreContacts>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("StoreTypeId")]
        public int StoreTypeId { get; set; }
        [StringLength(50)]
        public string StoreNumber { get; set; }
        [StringLength(255)]
        public string BillingAddress { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [StringLength(30)]
        public string StorePhoneNumber { get; set; }
        [StringLength(30)]
        public string DirectPhoneNumber { get; set; }
        [StringLength(30)]
        public string Extension { get; set; }
        [StringLength(30)]
        public string FaxNumber { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        public int MarketId { get; set; }
        [Required]
        public bool? Active { get; set; }
        [StringLength(50)]
        public string StoreNickName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public short? MarketNumber { get; set; }
        [Column("XMLSourceId")]
        public int XmlsourceId { get; set; }
        [Required]
        public bool? IncludeInStatusReportAll { get; set; }
        [Column("AccountRepId")]
        public int? AccountRepId { get; set; }
        [Column("AccountCoorId")]
        public int? AccountCoorId { get; set; }

        [ForeignKey("AccountCoorId")]
        [InverseProperty("StoresAccountCoor")]
        public virtual Employees AccountCoor { get; set; }
        [ForeignKey("AccountRepId")]
        [InverseProperty("StoresAccountRep")]
        public virtual Employees AccountRep { get; set; }
        [ForeignKey("MarketId")]
        [InverseProperty("Stores")]
        public virtual Market Market { get; set; }
        [ForeignKey("StoreTypeId")]
        [InverseProperty("Stores")]
        public virtual StoreType StoreType { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<DepartmentsStoresAssignments> DepartmentsStoresAssignments { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<StoreContacts> StoreContacts { get; set; }
    }
}
