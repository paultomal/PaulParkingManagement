using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceProviderRepos
{
    internal class ParkingSpotRepos : Repo, IRepo<ParkingSpot, string, ParkingSpot>
    {
        public ParkingSpot Create(ParkingSpot obj)
        {
            db.ParkingSpots.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ps = Read(id);
            db.ParkingSpots.Remove(ps);
            return db.SaveChanges() > 0;
        }

        public List<ParkingSpot> Read()
        {
            return db.ParkingSpots.ToList();
        }

        public ParkingSpot Read(string id)
        {
            return db.ParkingSpots.Find(id);
        }

        public ParkingSpot Update(ParkingSpot obj)
        {
            var ps = Read(obj.ParkingID);
            db.Entry(ps).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
