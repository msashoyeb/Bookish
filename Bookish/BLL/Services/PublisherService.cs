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
  public  class PublisherService
    {

        public static List<PublisherDTO> Get()
        {
            var data = DataAccessFactory.PublisherData().Read();
            return Convert(data);
        }
        public static PublisherDTO Get(int id)
        {
            return Convert(DataAccessFactory.PublisherData().Read(id));
        }
        public static bool Create(PublisherDTO publisherDTO)
        {
            var data = Convert(publisherDTO);
            var res = DataAccessFactory.PublisherData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(PublisherDTO publisherDTO)
        {
            var data = Convert(publisherDTO);
            var res = DataAccessFactory.PublisherData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PublisherData().Delete(id);
        }
        static List<PublisherDTO> Convert(List<Publisher> publishers)
        {
            var data = new List<PublisherDTO>();
            foreach (var publisher in publishers)
            {
                data.Add(Convert(publisher));
            }
            return data;
        }
        static Publisher Convert(PublisherDTO publisherDTO)
        {
            return new Publisher()
            {
                Id = publisherDTO.Id,
                Name = publisherDTO.Name,
                AmountOfMoney = publisherDTO.AmountOfMoney
            };
        }
        static PublisherDTO Convert(Publisher publisher)
        {
            return new PublisherDTO()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                AmountOfMoney = publisher.AmountOfMoney
            };
        }
    }
}
