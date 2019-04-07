using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class SubContractorsDivisionAssignments
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("SubContractorId")]
        public int SubContractorId { get; set; }
        [Column("DivisionId")]
        public int DivisionId { get; set; }
        [Column("SubDivisionId")]
        public int? SubDivisionId { get; set; }
    }
}
