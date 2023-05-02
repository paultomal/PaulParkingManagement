namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PPMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PPMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 5; i++)
            {
                context.Admins.AddOrUpdate(new Models.Admin
                {
                    Id = i,
                    Username = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Password = Guid.NewGuid().ToString().Substring(0, 4)
                });
            }
            for (int i = 1; i <= 5; i++)
            {
                context.ServiceProviders.AddOrUpdate(new Models.ServiceProvider
                {
                    ProviderID = "" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = Guid.NewGuid().ToString().Substring(0, 12),
                    Location = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 4)
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                context.Customers.AddOrUpdate(new Models.Customer
                {
                    CustomerID = "" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = Guid.NewGuid().ToString().Substring(0, 12),
                    Password = Guid.NewGuid().ToString().Substring(0, 4)
                });
            }
        }
    }
}
