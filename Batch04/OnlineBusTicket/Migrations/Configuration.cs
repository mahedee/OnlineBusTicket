namespace OnlineBusTicket.Migrations
{
    using OnlineBusTicket.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineBusTicket.Models.dbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnlineBusTicket.Models.dbContext context)
        {
              //This method will be called after migrating to the latest version.

              //You can use the DbSet<T>.AddOrUpdate() helper extension method 
              //to avoid creating duplicate seed data. E.g.
            
              //  context.People.AddOrUpdate(
              //    p => p.FullName,
              //    new Person { FullName = "Andrew Peters" },
              //    new Person { FullName = "Brice Lambson" },
              //    new Person { FullName = "Rowan Miller" }
              //  );
            context.Bus.AddOrUpdate(
              p => p.busNo,
              new Bus { busNo = "40", busCapacity = 30, busStatus = 1, companyId = 1 }


            );
        }
    }
}
