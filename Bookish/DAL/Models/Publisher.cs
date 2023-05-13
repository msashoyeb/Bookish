using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public double AmountOfMoney { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public Publisher()
        {
            Books = new List<Book>();
        }
    }
}
