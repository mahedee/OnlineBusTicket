namespace OnlineBusTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        busId = c.Int(nullable: false, identity: true),
                        busNo = c.String(),
                        busCapacity = c.Int(nullable: false),
                        busStatus = c.Int(nullable: false),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busId)
                .ForeignKey("dbo.Companies", t => t.companyId, cascadeDelete: true)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        companyId = c.Int(nullable: false, identity: true),
                        companName = c.String(),
                        companyLogo = c.String(),
                        companyFavicon = c.String(),
                    })
                .PrimaryKey(t => t.companyId);
            
            CreateTable(
                "dbo.Bus_route",
                c => new
                    {
                        busRouteId = c.Int(nullable: false, identity: true),
                        busFrom = c.String(),
                        busTo = c.String(),
                        busId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busRouteId);
            
            CreateTable(
                "dbo.Bus_seat",
                c => new
                    {
                        seatId = c.Int(nullable: false, identity: true),
                        seatName = c.String(),
                        busId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.seatId)
                .ForeignKey("dbo.Buses", t => t.busId, cascadeDelete: true)
                .Index(t => t.busId);
            
            CreateTable(
                "dbo.Bus_booking",
                c => new
                    {
                        busBookingId = c.Int(nullable: false, identity: true),
                        busId = c.Int(nullable: false),
                        seatId = c.Int(nullable: false),
                        counterId = c.Int(nullable: false),
                        busSchedulId = c.Int(nullable: false),
                        travelDate = c.String(),
                        sessionId = c.String(),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busBookingId);
            
            CreateTable(
                "dbo.Bus_counter",
                c => new
                    {
                        busCounterId = c.Int(nullable: false, identity: true),
                        busCounterName = c.String(),
                        locationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busCounterId)
                .ForeignKey("dbo.Bus_location", t => t.locationId, cascadeDelete: true)
                .Index(t => t.locationId);
            
            CreateTable(
                "dbo.Bus_location",
                c => new
                    {
                        locationId = c.Int(nullable: false, identity: true),
                        locationName = c.String(),
                    })
                .PrimaryKey(t => t.locationId);
            
            CreateTable(
                "dbo.Bus_receipt",
                c => new
                    {
                        busReceiptId = c.Int(nullable: false, identity: true),
                        busTransactionId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busReceiptId);
            
            CreateTable(
                "dbo.Bus_route_via",
                c => new
                    {
                        busRouteViaId = c.Int(nullable: false, identity: true),
                        busId = c.Int(nullable: false),
                        locationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busRouteViaId);
            
            CreateTable(
                "dbo.Bus_schedule",
                c => new
                    {
                        busScheduleId = c.Int(nullable: false, identity: true),
                        from = c.String(),
                        to = c.String(),
                        departure = c.String(),
                        arrival = c.String(),
                        busId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busScheduleId)
                .ForeignKey("dbo.Buses", t => t.busId, cascadeDelete: true)
                .Index(t => t.busId);
            
            CreateTable(
                "dbo.Bus_setting",
                c => new
                    {
                        seatBlockDuration = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.seatBlockDuration);
            
            CreateTable(
                "dbo.Bus_transaction",
                c => new
                    {
                        busTransactionId = c.Int(nullable: false, identity: true),
                        sessionId = c.String(),
                        amount = c.String(),
                        sender = c.String(),
                        receiver = c.String(),
                        transDate = c.String(),
                        transCode = c.String(),
                        transStatus = c.String(),
                    })
                .PrimaryKey(t => t.busTransactionId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Bus_routeBus",
                c => new
                    {
                        Bus_route_busRouteId = c.Int(nullable: false),
                        Bus_busId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bus_route_busRouteId, t.Bus_busId })
                .ForeignKey("dbo.Bus_route", t => t.Bus_route_busRouteId, cascadeDelete: true)
                .ForeignKey("dbo.Buses", t => t.Bus_busId, cascadeDelete: true)
                .Index(t => t.Bus_route_busRouteId)
                .Index(t => t.Bus_busId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Bus_schedule", "busId", "dbo.Buses");
            DropForeignKey("dbo.Bus_counter", "locationId", "dbo.Bus_location");
            DropForeignKey("dbo.Bus_seat", "busId", "dbo.Buses");
            DropForeignKey("dbo.Bus_routeBus", "Bus_busId", "dbo.Buses");
            DropForeignKey("dbo.Bus_routeBus", "Bus_route_busRouteId", "dbo.Bus_route");
            DropForeignKey("dbo.Buses", "companyId", "dbo.Companies");
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Bus_schedule", new[] { "busId" });
            DropIndex("dbo.Bus_counter", new[] { "locationId" });
            DropIndex("dbo.Bus_seat", new[] { "busId" });
            DropIndex("dbo.Bus_routeBus", new[] { "Bus_busId" });
            DropIndex("dbo.Bus_routeBus", new[] { "Bus_route_busRouteId" });
            DropIndex("dbo.Buses", new[] { "companyId" });
            DropTable("dbo.Bus_routeBus");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Bus_transaction");
            DropTable("dbo.Bus_setting");
            DropTable("dbo.Bus_schedule");
            DropTable("dbo.Bus_route_via");
            DropTable("dbo.Bus_receipt");
            DropTable("dbo.Bus_location");
            DropTable("dbo.Bus_counter");
            DropTable("dbo.Bus_booking");
            DropTable("dbo.Bus_seat");
            DropTable("dbo.Bus_route");
            DropTable("dbo.Companies");
            DropTable("dbo.Buses");
        }
    }
}
