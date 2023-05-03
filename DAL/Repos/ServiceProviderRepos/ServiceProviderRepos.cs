using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceProviderRepos
{
    internal class ServiceProviderRepos : Repo, IRepo<ServiceProvider, string, ServiceProvider>
    {
        public ServiceProvider Create(ServiceProvider obj)
        {
            db.ServiceProviders.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null; 
        }

        public bool Delete(string id)
        {
            var sp = Read(id);
            db.ServiceProviders.Remove(sp);
            return db.SaveChanges() > 0; 
        }

        public List<ServiceProvider> Read()
        {
            return db.ServiceProviders.ToList();
        }

        public ServiceProvider Read(string id)
        {
            return db.ServiceProviders.Find(id);
        }

        public ServiceProvider Update(ServiceProvider obj)
        {
            var sp = Read(obj.Name);
            db.Entry(sp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
