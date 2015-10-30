using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_receipt
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busReceiptId { get; set; }
        public int busTransactionId { get; set; }
        public int userId { get; set; }
    }
}