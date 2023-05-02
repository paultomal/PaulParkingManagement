using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class CustomerRepo : Repo, IRepo<Customer, string, Customer>
    {
        public Customer Create(Customer obj)
        {
            db.Customers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Customers.Remove(ex);
            return db.SaveChanges() > 0 ;
        }

        public List<Customer> Read()
        {
            return db.Customers.ToList();
        }

        public Customer Read(string id)
        {
            return db.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var ex = Read(obj.CustomerID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
