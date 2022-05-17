using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class AddingBeneficiaryDetail
    {
        [StringLength(50)]
        public string BeneficiaryName { get; set; } = null!;
        [Key]
        [StringLength(50)]
        public string BeneficiaryAccountNumber { get; set; } = null!;
        [StringLength(50)]
        public string BeneficiaryBankName { get; set; } = null!;
        [Column("BeneficiaryIFSC")]
        [StringLength(50)]
        public string BeneficiaryIfsc { get; set; } = null!;
        public double TransferLimit { get; set; }
    }
}
