using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, int, Admin>
    {
        public Admin Create(Admin obj)
        {
            myDbContext.Admins.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Admins.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Admin> Read()
        {
            return myDbContext.Admins.ToList();
        }

        public Admin Read(int id)
        {
            return myDbContext.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }



}
