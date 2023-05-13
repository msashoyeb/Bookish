using BLL.DTOs;
using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Book, int, Book> BookData()
        {
            return new BookRepo();
        }

        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<Cart, int, Cart> CartData()
        {
            return new CartRepo();
        }

        public static IRepo<Complaint, int, Complaint> ComplaintData()
        {
            return new ComplaintRepo();
        }
        public static IRepo<Customer, int, Customer> CustomerData()
        {
            return new CustomerRepo();
        }

        public static IRepo<Publisher, int, Publisher> PublisherData()
        {
            return new PublisherRepo();
        }
        public static IRepo<Rating, int, Rating> RatingData()
        {
            return new RatingRepo();
        }

        public static IRepo<Review, int, Review> ReviewData()
        {
            return new ReviewRepo(); 
        }


        public static IRepo<Order, int, Order> OrderData()
        {
            return new OrderRepo();
        }

        public static IRepo<Deliveryman, int, Deliveryman> DeliverymanData()
        {
            return new DeliverymanRepo();
        }

        public static IRepo<DeliverymanOrder, int, DeliverymanOrder> DeliverymanOrderData()
        {
            return new DeliverymanOrderRepo();
        }

        public static IRepo<Helpline, int, Helpline> HelplineData()
        {
            return new HelplineRepo();
        }
    }
}
