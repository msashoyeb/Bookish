using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliverymanOrder
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        [ForeignKey("Deliveryman")]
        public int DeliverymanId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Deliveryman Deliveryman { get; set; }
        public virtual Order Order { get; set; }
    }
}
