using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CartRepo : Repo, IRepo<Cart, int, Cart>
    {
        public Cart Create(Cart obj)
        {
            myDbContext.Carts.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Carts.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Cart> Read()
        {
            return myDbContext.Carts.ToList();
        }

        public Cart Read(int id)
        {
            return myDbContext.Carts.Find(id);
        }

        public Cart Update(Cart obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }


    }
}
