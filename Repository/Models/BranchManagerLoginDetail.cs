using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class BranchManagerLoginDetail
    {
        [Column("BMID")]
        [StringLength(50)]
        [Unicode(false)]
        public string Bmid { get; set; } = null!;
        [Key]
        [Column("BMname")]
        [StringLength(50)]
        public string Bmname { get; set; } = null!;
        [Column("BMpassword")]
        [StringLength(50)]
        public string Bmpassword { get; set; } = null!;
    }
}
