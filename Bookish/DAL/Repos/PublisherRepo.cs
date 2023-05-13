using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PublisherRepo : Repo, IRepo<Publisher, int, Publisher>
    {
        public Publisher Create(Publisher obj)
        {
            myDbContext.Publishers.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Publishers.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Publisher> Read()
        {
            return myDbContext.Publishers.ToList();
        }

        public Publisher Read(int id)
        {
            return myDbContext.Publishers.Find(id);
        }

        public Publisher Update(Publisher obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }

    }
}