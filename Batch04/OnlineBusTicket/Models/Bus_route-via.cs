using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_route_via
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busRouteViaId { get; set; }
        public int busId { get; set; }
        public int locationId { get; set; }
    }
}