namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaulParkingManagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentMethod = c.String(nullable: false),
                        PaymentAmount = c.String(nullable: false),
                        CustomerID = c.String(maxLength: 128),
                        ProviderID = c.String(maxLength: 128),
                        ReservationID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Reservations", t => t.ReservationID)
                .ForeignKey("dbo.ServiceProviders", t => t.ProviderID)
                .Index(t => t.CustomerID)
                .Index(t => t.ProviderID)
                .Index(t => t.ReservationID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.String(nullable: false, maxLength: 128),
                        CheckInDateTime = c.String(nullable: false, maxLength: 100),
                        CheckOutDateTime = c.String(nullable: false, maxLength: 100),
                        CustomerID = c.String(maxLength: 128),
                        ParkingID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.ParkingSpots", t => t.ParkingID)
                .Index(t => t.CustomerID)
                .Index(t => t.ParkingID);
            
            CreateTable(
                "dbo.ParkingSpots",
                c => new
                    {
                        ParkingID = c.String(nullable: false, maxLength: 128),
                        Location = c.String(nullable: false),
                        Capacity = c.Int(nullable: false),
                        PriceParHour = c.Int(nullable: false),
                        AvailableSpots = c.Int(nullable: false),
                        ProviderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ParkingID)
                .ForeignKey("dbo.ServiceProviders", t => t.ProviderID)
                .Index(t => t.ProviderID);
            
            CreateTable(
                "dbo.ServiceProviders",
                c => new
                    {
                        ProviderID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProviderID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.String(nullable: false, maxLength: 128),
                        Rating = c.String(nullable: false),
                        Comment = c.String(nullable: false),
                        CustomerID = c.String(maxLength: 128),
                        ProviderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.ServiceProviders", t => t.ProviderID)
                .Index(t => t.CustomerID)
                .Index(t => t.ProviderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "ProviderID", "dbo.ServiceProviders");
            DropForeignKey("dbo.Payments", "ReservationID", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "ParkingID", "dbo.ParkingSpots");
            DropForeignKey("dbo.ParkingSpots", "ProviderID", "dbo.ServiceProviders");
            DropForeignKey("dbo.Reviews", "ProviderID", "dbo.ServiceProviders");
            DropForeignKey("dbo.Reviews", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Payments", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Reviews", new[] { "ProviderID" });
            DropIndex("dbo.Reviews", new[] { "CustomerID" });
            DropIndex("dbo.ParkingSpots", new[] { "ProviderID" });
            DropIndex("dbo.Reservations", new[] { "ParkingID" });
            DropIndex("dbo.Reservations", new[] { "CustomerID" });
            DropIndex("dbo.Payments", new[] { "ReservationID" });
            DropIndex("dbo.Payments", new[] { "ProviderID" });
            DropIndex("dbo.Payments", new[] { "CustomerID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.ServiceProviders");
            DropTable("dbo.ParkingSpots");
            DropTable("dbo.Reservations");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Admins");
        }
    }
}
