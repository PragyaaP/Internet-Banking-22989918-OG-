using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Table("Registration")]
    public partial class Registration
    {
        [Column("SBAccountNumber")]
        [StringLength(50)]
        public string SbaccountNumber { get; set; } = null!;
        [Column("CIFNumber", TypeName = "numeric(18, 0)")]
        public decimal Cifnumber { get; set; }
        [StringLength(10)]
        public string BranchCode { get; set; } = null!;
        [Key]
        [Column(TypeName = "numeric(18, 0)")]
        public decimal RegisteredMobileNo { get; set; }
        [Column("RequestID")]
        [StringLength(10)]
        public string RequestId { get; set; } = null!;
    }
}
