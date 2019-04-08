using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class Payroll
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime PayDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Installer { get; set; }
        public int? SubContractorId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("PONumber")]
        [StringLength(10)]
        public string Ponumber { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        public int? OrderId { get; set; }
        [Column(TypeName = "money")]
        public decimal? PayAmount { get; set; }
        [StringLength(50)]
        public string Comments { get; set; }
        [StringLength(50)]
        public string Chargeback { get; set; }
        public bool NoRetainage { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("Payroll")]
        public virtual Order Order { get; set; }
        [ForeignKey("SubContractorId")]
        [InverseProperty("Payroll")]
        public virtual SubContractor SubContractor { get; set; }
    }
}
