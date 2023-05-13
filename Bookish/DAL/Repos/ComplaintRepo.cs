using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ComplaintRepo : Repo, IRepo<Complaint, int, Complaint>
    {
        public Complaint Create(Complaint obj)
        {
            myDbContext.Complaints.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Complaints.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Complaint> Read()
        {
            return myDbContext.Complaints.ToList();
        }

        public Complaint Read(int id)
        {
            return myDbContext.Complaints.Find(id);
        }

        public Complaint Update(Complaint obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}