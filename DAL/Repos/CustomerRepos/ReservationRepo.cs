using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class ReservationRepo : Repo, IRepo<Reservation, String, Reservation>
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
            var ex = Read(obj.ReservationID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
