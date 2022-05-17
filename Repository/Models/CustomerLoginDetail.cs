using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class CustomerLoginDetail
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal RegisteredMobileNo { get; set; }
        [Key]
        [Column("LoginID")]
        [StringLength(50)]
        public string LoginId { get; set; } = null!;
        [StringLength(50)]
        public string Password { get; set; } = null!;
    }
}
