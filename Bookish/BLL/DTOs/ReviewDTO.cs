using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
  public  class ReviewDTO
    { 
        public int Id { get; set; }   
        public string Opinion { get; set; }
        public int BookId { get; set; }

    }
}
