using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DeliverymanOrderDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int DeliverymanId { get; set; }
        public int OrderId { get; set; }

    }
}
