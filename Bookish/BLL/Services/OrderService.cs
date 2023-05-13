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
   public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            return Convert(data);
        }
        public static OrderDTO Get(int id)
        {
            return Convert(DataAccessFactory.OrderData().Read(id));
        }
        public static bool Create(OrderDTO orderDTO)
        {
            var data = Convert(orderDTO);
            var res = DataAccessFactory.OrderData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(OrderDTO orderDTO)
        {
            var data = Convert(orderDTO);
            var res = DataAccessFactory.OrderData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }
        static List<OrderDTO> Convert(List<Order> orders)
        {
            var data = new List<OrderDTO>();
            foreach (var order in orders)
            {
                data.Add(Convert(order));
            }
            return data;
        }
        static Order Convert(OrderDTO orderDTO)
        {
            return new Order()
            {
                Id = orderDTO.Id,
                OrderDate = orderDTO.OrderDate,
                CartId = orderDTO.CartId
            };
        }
        static OrderDTO Convert(Order order)
        {
            return new OrderDTO()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                CartId = order.CartId
            };
        }

    }
}
