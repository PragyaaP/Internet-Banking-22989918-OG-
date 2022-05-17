using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Internet_Banking_22989918.Repository.Models
{
    [Keyless]
    [Table("Transaction")]
    public partial class Transaction
    {
        [Column("LoginID")]
        [StringLength(50)]
        public string LoginId { get; set; } = null!;
        [Column("ReceiverSBAccountNumber")]
        [StringLength(50)]
        public string ReceiverSbaccountNumber { get; set; } = null!;

        [ForeignKey("LoginId")]
        public virtual CustomerLoginDetail Login { get; set; } = null!;
        [ForeignKey("ReceiverSbaccountNumber")]
        public virtual CustomerTransactionDetail ReceiverSbaccountNumberNavigation { get; set; } = null!;
    }
}
