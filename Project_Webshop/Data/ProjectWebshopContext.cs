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
                modelBuilder.Entity<Customer>().ToTable("Customer");
                modelBuilder.Entity<Customer>().ToTable("Order");
                modelBuilder.Entity<Customer>().ToTable("Orderline");
                modelBuilder.Entity<Customer>().ToTable("Product");
                modelBuilder.Entity<Customer>().ToTable("Newsletter");





            }


        
    }
}
