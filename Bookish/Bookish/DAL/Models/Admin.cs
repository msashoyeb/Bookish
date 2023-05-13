using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public double AmountOfMoney { get; set; }

        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<Helpline> Helplines { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public Admin()
        {
            Complaints = new List<Complaint>();
            Helplines = new List<Helpline>();
            Customers = new List<Customer>();
        }
    }
}
