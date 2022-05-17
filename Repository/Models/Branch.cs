using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Table("Branch")]
    public partial class Branch
    {
        public Branch()
        {
            BranchManagerDetails = new HashSet<BranchManagerDetail>();
        }

        [Key]
        [Column("BID")]
        [StringLength(10)]
        public string Bid { get; set; } = null!;
        [StringLength(50)]
        public string Bname { get; set; } = null!;
        [Column("IFSC")]
        [StringLength(50)]
        public string Ifsc { get; set; } = null!;
        [StringLength(50)]
        public string City { get; set; } = null!;
        [StringLength(50)]
        public string State { get; set; } = null!;

        [InverseProperty("BidNavigation")]
        public virtual ICollection<BranchManagerDetail> BranchManagerDetails { get; set; }
    }
}
