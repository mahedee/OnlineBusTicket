using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_location
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int locationId { get; set; }
        public string locationName { get; set; }
        
        public virtual ICollection<Bus_counter> objCounter { get; set; }
    }
}