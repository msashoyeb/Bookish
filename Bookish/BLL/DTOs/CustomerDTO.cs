using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
  public  class CustomerDTO
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        
        public double AmountOfMoney { get; set; }

        
        public int AdminId { get; set; }



    }
}
