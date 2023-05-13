using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class ReviewRepo : Repo, IRepo<Review, int, Review>
    {
        public Review Create(Review obj)
        {
            myDbContext.Reviews.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Reviews.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Review> Read()
        {
            return myDbContext.Reviews.ToList();
        }

        public Review Read(int id)
        {
            return myDbContext.Reviews.Find(id);
        }

        public Review Update(Review obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
