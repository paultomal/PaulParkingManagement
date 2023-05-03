using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceProviderRepos
{
    internal class ReservationRepos : Repo, IRepo<Reservation, string, Reservation>
    {
        public Reservation Create(Reservation obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> Read()
        {
            return db.Reservations.ToList();
        }

        public Reservation Read(string id)
        {
            return db.Reservations.Find(id);
        }

        public Reservation Update(Reservation obj)
        {
            throw new NotImplementedException();
        }
    }
}
