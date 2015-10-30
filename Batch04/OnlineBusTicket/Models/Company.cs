using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class Company
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int companyId { get; set; }
        public string companName { get; set; }
        public string companyLogo { get; set; }
        public string companyFavicon { get; set; }
        public virtual ICollection<Bus> objBus { get; set; }
    }
}