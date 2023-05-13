using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HelplineRepo : Repo, IRepo<Helpline, int, Helpline>
    {
        public Helpline Create(Helpline obj)
        {
            myDbContext.Helplines.Add(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            myDbContext.Helplines.Remove(ex);
            return myDbContext.SaveChanges() > 0;
        }

        public List<Helpline> Read()
        {
            return myDbContext.Helplines.ToList();
        }

        public Helpline Read(int id)
        {
            return myDbContext.Helplines.Find(id);
        }

        public Helpline Update(Helpline obj)
        {
            var ex = Read(obj.Id);
            myDbContext.Entry(ex).CurrentValues.SetValues(obj);
            if (myDbContext.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
