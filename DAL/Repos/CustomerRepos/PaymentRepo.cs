using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class PaymentRepo : Repo, IRepo<Payment, int, Payment>
    {
        public Payment Create(Payment obj)
        {
            db.Payments.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Payments.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Payment> Read()
        {
            return db.Payments.ToList();
        }

        public Payment Read(int id)
        {
            return db.Payments.Find(id);
        }

        public Payment Update(Payment obj)
        {
            var ex = Read(obj.PaymentId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}

