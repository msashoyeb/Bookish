using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deliveryman> Deliverymans { get; set; }
        public DbSet<DeliverymanOrder> DeliverymanOrders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Helpline> Helplines { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

//enable-migrations
//add-migration AllTableCreation
//update-database -Verbose