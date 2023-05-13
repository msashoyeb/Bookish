using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RatingRepo : Repo, IRepo<Rating, int, Rating>
    {
        public Rating Create(Rating obj)
        {
            myDbContext.Ratings.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Ratings.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Rating> Read()
        {
            return myDbContext.Ratings.ToList();
        }

        public Rating Read(int id)
        {
            return myDbContext.Ratings.Find(id);
        }

        public Rating Update(Rating obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
