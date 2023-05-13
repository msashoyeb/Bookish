using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, Order>
    {
        public Order Create(Order obj)
        {
            myDbContext.Orders.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Orders.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Order> Read()
        {
            return myDbContext.Orders.ToList();
        }

        public Order Read(int id)
        {
            return myDbContext.Orders.Find(id);
        }

        public Order Update(Order obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
