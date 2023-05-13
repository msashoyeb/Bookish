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
  public  class ReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewData().Read();
            return Convert(data);
        }
        public static ReviewDTO Get(int id)
        {
            return Convert(DataAccessFactory.ReviewData().Read(id));
        }
        public static bool Create(ReviewDTO reviewDTO)
        {
            var data = Convert(reviewDTO);
            var res = DataAccessFactory.ReviewData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(ReviewDTO reviewDTO)
        {
            var data = Convert(reviewDTO);
            var res = DataAccessFactory.ReviewData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ReviewData().Delete(id);
        }
        static List<ReviewDTO> Convert(List<Review> reviews)
        {
            var data = new List<ReviewDTO>();
            foreach (var review in reviews)
            {
                data.Add(Convert(review));
            }
            return data;
        }
        static Review Convert(ReviewDTO reviewDTO)
        {
            return new Review()
            {
                Id = reviewDTO.Id,
                Opinion = reviewDTO.Opinion,
                BookId = reviewDTO.BookId
            };
        }
        static ReviewDTO Convert(Review review)
        {
            return new ReviewDTO()
            {
                Id = review.Id,
                Opinion = review.Opinion,
                BookId = review.BookId
            };
        }

    }
}
