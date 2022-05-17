using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Table("InternetBankingRequest")]
    public partial class InternetBankingRequest
    {
        [Key]
        [Column("RequestID")]
        [StringLength(10)]
        public string RequestId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string StatusOfRequest { get; set; } = null!;
        public bool StatusValue { get; set; }
    }
}
