using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.Models
{
    public class Database : DbContext
    {
        // DbSet for Addresses class
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public Database(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().Property(e => e.CustomerID).HasColumnName("CustomerID");

            // Set the Id field as the primary key
            modelBuilder.Entity<Address>().HasKey(x => x.ID);
            // Map the Addresses class to the Addresses table
            modelBuilder.Entity<Address>().ToTable("Addresses");

            // Set the Id field as the primary key
            modelBuilder.Entity<Customer>().HasKey(x => x.ID);
            // Map the Addresses class to the Customers table
            modelBuilder.Entity<Customer>().ToTable("Customers");

            // Set the Id field as the primary key
            modelBuilder.Entity<OrderLine>().HasKey(x => x.ID);
            // Map the Addresses class to the OrderLines table
            modelBuilder.Entity<OrderLine>().ToTable("OrderLines");

            // Set the Id field as the primary key
            modelBuilder.Entity<Order>().HasKey(x => x.ID);
            // Map the Addresses class to the Orders table
            modelBuilder.Entity<Order>().ToTable("Orders");
        }

    }
}