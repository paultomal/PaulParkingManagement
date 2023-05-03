using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceProviderRepos
{
    internal class PaymentRepos : Repo, IRepo<Payment, string, Payment>
    {
        public Payment Create(Payment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Read()
        {
            return db.Payments.ToList();
        }

        public Payment Read(string id)
        {
            return db.Payments.Find(id);
        }

        public Payment Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
