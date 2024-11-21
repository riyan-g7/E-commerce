using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Admin> admin { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Cover_type> cover { get; set; }
        public DbSet<Company> company { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Order_items> order_items { get; set; }
    }
}
