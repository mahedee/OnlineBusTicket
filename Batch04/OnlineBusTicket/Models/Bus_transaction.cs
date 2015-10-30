using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busTransactionId { get; set;}
        public string sessionId { get; set; }
        public string amount { get; set; }
        public string sender { get; set; }
        public string receiver { get; set; }
        public string transDate { get; set; }
        public string transCode { get; set; }
        public string transStatus { get; set; }

    }
}