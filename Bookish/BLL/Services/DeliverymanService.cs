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
    public class DeliverymanService
    {
        public static List<DeliverymanDTO> Get()
        {
            var data = DataAccessFactory.DeliverymanData().Read();
            return Convert(data);
        }
        public static DeliverymanDTO Get(int id)
        {
            return Convert(DataAccessFactory.DeliverymanData().Read(id));
        }
        public static bool Create(DeliverymanDTO deliverymanDTO)
        {
            var data = Convert(deliverymanDTO);
            var res = DataAccessFactory.DeliverymanData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(DeliverymanDTO deliverymanDTO)
        {
            var data = Convert(deliverymanDTO);
            var res = DataAccessFactory.DeliverymanData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DeliverymanData().Delete(id);
        }
        static List<DeliverymanDTO> Convert(List<Deliveryman> deliverymans)
        {
            var data = new List<DeliverymanDTO>();
            foreach (var deliveryman in deliverymans)
            {
                data.Add(Convert(deliveryman));
            }
            return data;
        }
        static Deliveryman Convert(DeliverymanDTO deliverymanDTO)
        {
            return new Deliveryman()
            {
                Id = deliverymanDTO.Id,
                Name = deliverymanDTO.Name,
                AmountOfMoney = deliverymanDTO.AmountOfMoney,
            };
        }
        static DeliverymanDTO Convert(Deliveryman deliveryman)
        {
            return new DeliverymanDTO()
            {
                Id = deliveryman.Id,
                Name = deliveryman.Name,
                AmountOfMoney = deliveryman.AmountOfMoney,
            };
        }
    }

}
