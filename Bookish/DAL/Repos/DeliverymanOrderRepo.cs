using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DeliverymanOrderRepo : Repo, IRepo<DeliverymanOrder, int, DeliverymanOrder>
    {
        public DeliverymanOrder Create(DeliverymanOrder obj)
        {
            myDbContext.DeliverymanOrders.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.DeliverymanOrders.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<DeliverymanOrder> Read()
        {
            return myDbContext.DeliverymanOrders.ToList();
        }

        public DeliverymanOrder Read(int id)
        {
            return myDbContext.DeliverymanOrders.Find(id);
        }

        public DeliverymanOrder Update(DeliverymanOrder obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
