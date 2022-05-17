using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(50)]
        public string AdminName { get; set; } = null!;
        [StringLength(50)]
        public string AdminPassword { get; set; } = null!;
    }
}
