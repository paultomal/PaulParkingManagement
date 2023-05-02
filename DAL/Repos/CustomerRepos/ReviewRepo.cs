using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class ReviewRepo : Repo, IRepo<Review, string, Review>
    {
        public Review Create(Review obj)
        {
            db.Reviews.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Reviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Review> Read()
        {
            return db.Reviews.ToList();
        }

        public Review Read(string id)
        {
            return db.Reviews.Find(id);
        }

        public Review Update(Review obj)
        {
            var ex = Read(obj.ReviewID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
