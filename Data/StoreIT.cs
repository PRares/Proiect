using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PascanRares_Project.Models;

namespace PascanRares_Project.Data
{
    public class StoreIT : DbContext
    {
        public StoreIT(DbContextOptions<StoreIT> options) :
       base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Bill> Bills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Laptop>().ToTable("Laptop");
            modelBuilder.Entity<Bill>().ToTable("Bill");
        }

       
    }
}
