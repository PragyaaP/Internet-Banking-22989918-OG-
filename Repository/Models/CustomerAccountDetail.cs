using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class CustomerAccountDetail
    {
        [Key]
        [Column("SBAccountNumber")]
        [StringLength(50)]
        public string SbaccountNumber { get; set; } = null!;
        [Column("CIFNumber", TypeName = "numeric(18, 0)")]
        public decimal Cifnumber { get; set; }
        [StringLength(10)]
        public string BranchCode { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string AccountType { get; set; } = null!;
        public double Balance { get; set; }
        [Column(TypeName = "date")]
        public DateTime AccountStartDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AccountStatus { get; set; } = null!;
    }
}
