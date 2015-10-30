using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_route
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busRouteId { get; set; }
        public string busFrom { get; set; }
        public string busTo { get; set; }
        public int busId { get; set; }
        public virtual ICollection<Bus> objBus { get; set; }
    }
}