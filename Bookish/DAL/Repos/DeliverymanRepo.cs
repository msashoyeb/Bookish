using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DeliverymanRepo : Repo, IRepo<Deliveryman, int, Deliveryman>
    {
        public Deliveryman Create(Deliveryman obj)
        {
            myDbContext.Deliverymans.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Deliverymans.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Deliveryman> Read()
        {
            return myDbContext.Deliverymans.ToList();
        }

        public Deliveryman Read(int id)
        {
            return myDbContext.Deliverymans.Find(id);
        }

        public Deliveryman Update(Deliveryman obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
