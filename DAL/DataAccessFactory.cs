using DAL.Interfaces;
using DAL.Models;
using DAL.Repos.CustomerRepos;
using DAL.Repos.ServiceProviderRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        // Customer
       public static IRepo<Customer, string, Customer> CustomerData()
        {
            return new CustomerRepo();
        }
       public static IRepo<Review, string, Review> ReviewData()
        {
            return new ReviewRepo();
        }
        public static IRepo<Payment, int, Payment> PaymentData()
        {
            return new PaymentRepo();
        }
        public static IRepo<Reservation, string, Reservation> ReservationData()
        {
            return new ReservationRepo();
        }
        //ServiceProvider
        public static IRepo<ServiceProvider, string, ServiceProvider> ServiceProviderData()
        {
            return new ServiceProviderRepos();
        }
        public static IRepo<Review, string, Review> ReviewsData()
        {
            return new ReviewRepos();
        }
        public static IRepo<ParkingSpot, string, ParkingSpot> ParkingSpotsData()
        {
            return new ParkingSpotRepos();
        }
        public static IRepo<Reservation, string, Reservation> ReservationsData()
        {
            return new ReservationRepos();
        }
        public static IRepo<Payment, string, Payment> PaymentsData()
        {
            return new PaymentRepos();
        }

    }
}
