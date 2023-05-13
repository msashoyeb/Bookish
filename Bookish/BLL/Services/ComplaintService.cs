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
   public class ComplaintService
    {
        public static List<ComplaintDTO> Get()
        {
            var data = DataAccessFactory.ComplaintData().Read();
            return Convert(data);
        }
        public static ComplaintDTO Get(int id)
        {
            return Convert(DataAccessFactory.ComplaintData().Read(id));
        }
        public static bool Create(ComplaintDTO complaintDTO)
        {
            var data = Convert(complaintDTO);
            var res = DataAccessFactory.ComplaintData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(ComplaintDTO complaintDTO)
        {
            var data = Convert(complaintDTO);
            var res = DataAccessFactory.ComplaintData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ComplaintData().Delete(id);
        }
        static List<ComplaintDTO> Convert(List<Complaint> complaints)
        {
            var data = new List<ComplaintDTO>();
            foreach (var complaint in complaints)
            {
                data.Add(Convert(complaint));
            }
            return data;
        }
        static Complaint Convert(ComplaintDTO complaintDTO)
        {
            return new Complaint()
            {
                Id = complaintDTO.Id,
                Complaintment = complaintDTO.Complaintment,
                AdminId = complaintDTO.AdminId
            };
        }
        static ComplaintDTO Convert(Complaint complaint)
        {
            return new ComplaintDTO()
            {
                Id = complaint.Id,
                Complaintment = complaint.Complaintment,
                AdminId = complaint.AdminId
            };
        }


    }
}
