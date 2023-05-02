using DAL.Interfaces;
using DAL.Models;
using DAL.Repos.CustomerRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
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

    }
}
