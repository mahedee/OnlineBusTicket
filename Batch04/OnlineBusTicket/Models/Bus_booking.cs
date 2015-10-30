using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Bus_booking
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int busBookingId { get; set; }
        public int busId { get; set; }
        public int seatId { get; set; }
        public int counterId { get; set; }
        public int busSchedulId { get; set; }
        public string travelDate { get; set; }
        public string sessionId { get; set; }
        public int userId { get; set; }

    }
}