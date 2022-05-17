using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Keyless]
    [Table("NEFTFundTransfer")]
    public partial class NeftfundTransfer
    {
        [Column("LoginID")]
        [StringLength(50)]
        public string LoginId { get; set; } = null!;
        [StringLength(50)]
        public string? BeneficiaryAccountNumber { get; set; }
    }
}
