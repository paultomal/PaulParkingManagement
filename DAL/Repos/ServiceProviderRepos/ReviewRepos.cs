using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceProviderRepos
{
    internal class ReviewRepos : Repo, IRepo<Review, string, Review>
    {
        public Review Create(Review obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Review> Read()
        {
            return db.Reviews.ToList(); ;
        }

        public Review Read(string id)
        {
            return db.Reviews.Find(id);
        }

        public Review Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
