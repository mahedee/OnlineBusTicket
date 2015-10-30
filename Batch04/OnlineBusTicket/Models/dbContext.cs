using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineBusTicket.Models
{
    public class dbContext : IdentityDbContext<ApplicationUser>
    {
        public dbContext()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Bus_booking> busBookin { get; set; }
        public DbSet<Bus_counter> busCounter { get; set; }
        public DbSet<Bus_location> busLocation { get; set; }
        public DbSet<Bus_receipt> BusReceipt { get; set; }
        public DbSet<Bus_route_via> busRouteVia { get; set; }
        public DbSet<Bus_route> busRoute { get; set; }
        public DbSet<Bus_schedule> busSchedule { get; set; }
        public DbSet<Bus_seat> busSeat { get; set; }
        public DbSet<Bus_setting> BusSetting { get; set; }
        public DbSet<Bus_transaction> BusTrans { get; set; }
        
    }
   
}