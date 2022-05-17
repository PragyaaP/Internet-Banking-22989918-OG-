using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    public partial class CustomerTransactionDetail
    {
        [Key]
        [Column("ReceiverSBAccountNumber")]
        [StringLength(50)]
        public string ReceiverSbaccountNumber { get; set; } = null!;
        public double TransferAmount { get; set; }
    }
}
