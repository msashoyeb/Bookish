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
   public class RatingService
    {
        public static List<RatingDTO> Get()
        {
            var data = DataAccessFactory.RatingData().Read();
            return Convert(data);
        }
        public static RatingDTO Get(int id)
        {
            return Convert(DataAccessFactory.RatingData().Read(id));
        }
        public static bool Create(RatingDTO ratingDTO)
        {
            var data = Convert(ratingDTO);
            var res = DataAccessFactory.RatingData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(RatingDTO ratingDTO)
        {
            var data = Convert(ratingDTO);
            var res = DataAccessFactory.RatingData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.RatingData().Delete(id);
        }
        static List<RatingDTO> Convert(List<Rating> ratings)
        {
            var data = new List<RatingDTO>();
            foreach (var rating in ratings)
            {
                data.Add(Convert(rating));
            }
            return data;
        }
        static Rating Convert(RatingDTO ratingDTO)
        {
            return new Rating()
            {
                Id = ratingDTO.Id,
                Point = ratingDTO.Point,
                BookId = ratingDTO.BookId
            };
        }
        static RatingDTO Convert(Rating rating)
        {
            return new RatingDTO()
            {
                Id = rating.Id,
                Point = rating.Point,
                BookId = rating.BookId
            };
        }


    }
}
