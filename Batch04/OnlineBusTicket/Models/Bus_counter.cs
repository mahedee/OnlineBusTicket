using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_counter
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busCounterId { get; set; }
        public string busCounterName { get; set; }
        public int locationId { get; set; }
        [ForeignKey("locationId")]

        public virtual Bus_location objLocation { get; set; }
    }
}