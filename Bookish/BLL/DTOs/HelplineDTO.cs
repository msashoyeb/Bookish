using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HelplineDTO
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Number { get; set; }
        public int AdminId { get; set; }

    }
}
