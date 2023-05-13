using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HelplineService
    {
        public static List<HelplineDTO> Get()
        {
            var data = DataAccessFactory.HelplineData().Read();
            return Convert(data);
        }
        public static HelplineDTO Get(int id)
        {
            return Convert(DataAccessFactory.HelplineData().Read(id));
        }
        public static bool Create(HelplineDTO helplineDTO)
        {
            var data = Convert(helplineDTO);
            var res = DataAccessFactory.HelplineData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(HelplineDTO helplineDTO)
        {
            var data = Convert(helplineDTO);
            var res = DataAccessFactory.HelplineData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.HelplineData().Delete(id);
        }
        static List<HelplineDTO> Convert(List<Helpline> helplines)
        {
            var data = new List<HelplineDTO>();
            foreach (var helpline in helplines)
            {
                data.Add(Convert(helpline));
            }
            return data;
        }
        static Helpline Convert(HelplineDTO helplineDTO)
        {
            return new Helpline()
            {
                Id = helplineDTO.Id,
                DepartmentName = helplineDTO.DepartmentName,
                Number = helplineDTO.DepartmentName,
                AdminId = helplineDTO.AdminId,
            };
        }
        static HelplineDTO Convert(Helpline helpline)
        {
            return new HelplineDTO()
            {
                Id = helpline.Id,
                DepartmentName = helpline.DepartmentName,
                Number = helpline.DepartmentName,
                AdminId = helpline.AdminId,
            };
        }
    }
}
