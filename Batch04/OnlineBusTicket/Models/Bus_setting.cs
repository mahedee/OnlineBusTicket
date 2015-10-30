using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_setting
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public string seatBlockDuration { get; set; }
    }
}