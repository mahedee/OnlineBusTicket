using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busId { get; set; }
        public string busNo { get; set; }
        public int busCapacity { get; set; }
        public int busStatus { get; set; }
        public int companyId { get; set; }
        [ForeignKey("companyId")]
        public virtual Company objCompany { get; set; }
        public virtual ICollection<Bus_seat> objSeat { get; set; }
        public virtual ICollection<Bus_route> objRoute { get; set; }

    }
}