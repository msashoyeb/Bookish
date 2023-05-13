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
  public  class CartService
    {
        public static List<CartDTO> Get()
        {
            var data = DataAccessFactory.CartData().Read();
            return Convert(data);
        }
        public static CartDTO Get(int id)
        {
            return Convert(DataAccessFactory.CartData().Read(id));
        }
        public static bool Create(CartDTO cartDTO)
        {
            var data = Convert(cartDTO);
            var res = DataAccessFactory.CartData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(CartDTO cartDTO)
        {
            var data = Convert(cartDTO);
            var res = DataAccessFactory.CartData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CartData().Delete(id);
        }
        static List<CartDTO> Convert(List<Cart> carts)
        {
            var data = new List<CartDTO>();
            foreach (var cart in carts)
            {
                data.Add(Convert(cart));
            }
            return data;
        }
        static Cart Convert(CartDTO cartDTO)
        {
            return new Cart()
            {
                Id = cartDTO.Id,
                BookId = cartDTO.BookId,
                CustomerId = cartDTO.CustomerId
            };
        }
        static CartDTO Convert(Cart cart)
        {
            return new CartDTO()
            {
                Id = cart.Id,
                BookId = cart.BookId,
                CustomerId = cart.CustomerId
            };
        }

    }
}
