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
    public class DeliverymanOrderService
    {
        public static List<DeliverymanOrderDTO> Get()
        {
            var data = DataAccessFactory.DeliverymanOrderData().Read();
            return Convert(data);
        }
        public static DeliverymanOrderDTO Get(int id)
        {
            return Convert(DataAccessFactory.DeliverymanOrderData().Read(id));
        }
        public static bool Create(DeliverymanOrderDTO deliverymanOrderDTO)
        {
            var data = Convert(deliverymanOrderDTO);
            var res = DataAccessFactory.DeliverymanOrderData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(DeliverymanOrderDTO deliverymanOrderDTO)
        {
            var data = Convert(deliverymanOrderDTO);
            var res = DataAccessFactory.DeliverymanOrderData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DeliverymanOrderData().Delete(id);
        }
        static List<DeliverymanOrderDTO> Convert(List<DeliverymanOrder> deliverymanOrders)
        {
            var data = new List<DeliverymanOrderDTO>();
            foreach (var deliverymanOrder in deliverymanOrders)
            {
                data.Add(Convert(deliverymanOrder));
            }
            return data;
        }
        static DeliverymanOrder Convert(DeliverymanOrderDTO deliverymanOrderDTO)
        {
            return new DeliverymanOrder()
            {
                Id = deliverymanOrderDTO.Id,
                Status = deliverymanOrderDTO.Status,
                DeliverymanId = deliverymanOrderDTO.DeliverymanId,
                OrderId = deliverymanOrderDTO.OrderId,
            };
        }
        static DeliverymanOrderDTO Convert(DeliverymanOrder deliverymanOrder)
        {
            return new DeliverymanOrderDTO()
            {
                Id = deliverymanOrder.Id,
                Status = deliverymanOrder.Status,
                DeliverymanId = deliverymanOrder.DeliverymanId,
                OrderId = deliverymanOrder.OrderId,
            };
        }
    }
}
