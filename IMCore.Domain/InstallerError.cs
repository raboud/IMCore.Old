using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("Installer Error")]
    public partial class InstallerError
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
    }
}
