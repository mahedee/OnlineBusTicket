using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_schedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busScheduleId { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public int busId { get; set; }
         public virtual Bus objBus { get; set; }
    }
}