using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PPMContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        
/*        public DbSet<Token> Tokens { get; set; }
*/    }
}
