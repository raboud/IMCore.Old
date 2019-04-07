using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class SubContractorsDivisionAssignments
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("SubContractorID")]
        public int SubContractorId { get; set; }
        [Column("DivisionID")]
        public int DivisionId { get; set; }
        [Column("SubDivisionID")]
        public int? SubDivisionId { get; set; }
    }
}
