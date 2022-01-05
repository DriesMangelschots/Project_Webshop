using Microsoft.EntityFrameworkCore;
using Project_Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Data
{
    public class ProjectWebshopContext: DbContext
    {
    
            public ProjectWebshopContext(DbContextOptions<ProjectWebshopContext> options)
                : base(options)
            {

            }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Orderline> Orderlines { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Newsletter> Newsletters { get; set; }

            //database
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Orderline>().ToTable("Orderline");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Newsletter>().ToTable("Newsletter");





        }



    }
}
