using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookRepo : Repo, IRepo<Book, int, Book>
    {
        public Book Create(Book obj)
        {
            myDbContext.Books.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Books.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Book> Read()
        {
            return myDbContext.Books.ToList();
        }

        public Book Read(int id)
        {
            return myDbContext.Books.Find(id);
        }

        public Book Update(Book obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
