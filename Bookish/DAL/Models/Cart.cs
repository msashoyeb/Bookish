using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public Cart()
        {
            Orders = new List<Order>();
        }
    }
}
