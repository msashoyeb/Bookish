using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public class AdminService
    {

        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Read();
            return Convert(data);
        }
        public static AdminDTO Get(int id)
        {
            return Convert(DataAccessFactory.AdminData().Read(id));
        }
        public static bool Create(AdminDTO AdminDTO)
        {
            var data = Convert(AdminDTO);
            var res = DataAccessFactory.AdminData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(AdminDTO AdminDTO)
        {
            var data = Convert(AdminDTO);
            var res = DataAccessFactory.AdminData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }
        static List<AdminDTO> Convert(List<Admin> admins)
        {
            var data = new List<AdminDTO>();
            foreach (var admin in admins)
            {
                data.Add(Convert(admin));
            }
            return data;
        }
        static Admin Convert(AdminDTO adminDTO)
        {
            return new Admin()
            {
                Id = adminDTO.Id,
                Name = adminDTO.Name,
                AmountOfMoney= adminDTO.AmountOfMoney
               
            };
        }
        static AdminDTO Convert(Admin admin)
        {
            return new AdminDTO()
            {
                Id = admin.Id,
                Name = admin.Name,
                AmountOfMoney = admin.AmountOfMoney
            };
        }

    }
}
