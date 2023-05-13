using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, int, Customer>
    {
        public Customer Create(Customer obj)
        {
            myDbContext.Customers.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Customers.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Customer> Read()
        {
            return myDbContext.Customers.ToList();
        }

        public Customer Read(int id)
        {
            return myDbContext.Customers.Find(id);
        }

        public Customer Update(Customer obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}