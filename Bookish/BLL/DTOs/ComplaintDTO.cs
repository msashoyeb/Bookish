using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
   public class ComplaintDTO
    {

        public int Id { get; set; }
        
        public string Complaintment { get; set; }

        public int AdminId { get; set; }
    }
}
