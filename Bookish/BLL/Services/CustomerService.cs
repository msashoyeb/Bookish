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
  public  class CustomerService
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Read();
            return Convert(data);
        }
        public static CustomerDTO Get(int id)
        {
            return Convert(DataAccessFactory.CustomerData().Read(id));
        }
        public static bool Create(CustomerDTO customerDTO)
        {
            var data = Convert(customerDTO);
            var res = DataAccessFactory.CustomerData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(CustomerDTO customerDTO)
        {
            var data = Convert(customerDTO);
            var res = DataAccessFactory.CustomerData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CustomerData().Delete(id);
        }
        static List<CustomerDTO> Convert(List<Customer> customers)
        {
            var data = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                data.Add(Convert(customer));
            }
            return data;
        }
        static Customer Convert(CustomerDTO customerDTO)
        {
            return new Customer()
            {
                Id = customerDTO.Id,
                Name = customerDTO.Name,
                AmountOfMoney = customerDTO.AmountOfMoney,
                AdminId = customerDTO.AdminId
            };
        }
        static CustomerDTO Convert(Customer customer)
        {
            return new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                AmountOfMoney = customer.AmountOfMoney,
                AdminId = customer.AdminId
            };
        }
    }
}
