using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_seat
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int seatId { get; set; }
        public string seatName { get; set; }
        public int busId { get; set; }
        [ForeignKey("busId")]
        public virtual Bus objBus { get; set; }

    }
}