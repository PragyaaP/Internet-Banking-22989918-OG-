using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class BranchManagerDetail
    {
        [Key]
        [Column("BMID")]
        [StringLength(50)]
        public string Bmid { get; set; } = null!;
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string Address { get; set; } = null!;
        [Column(TypeName = "numeric(18, 0)")]
        public decimal PhoneNo { get; set; }
        [Column("BID")]
        [StringLength(10)]
        public string Bid { get; set; } = null!;

        [ForeignKey("Bid")]
        [InverseProperty("BranchManagerDetails")]
        public virtual Branch BidNavigation { get; set; } = null!;
    }
}
