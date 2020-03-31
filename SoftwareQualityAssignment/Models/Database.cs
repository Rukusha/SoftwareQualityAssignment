using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.models
{
    public class Database : DbContext
    {
        // DbSet for Addresses class
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderLines> OrderLines { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public Database(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set the Id field as the primary key
            modelBuilder.Entity<Addresses>().HasKey(x => x.ID);
            // Map the Addresses class to the Addresses table
            modelBuilder.Entity<Addresses>().ToTable("Addresses");

            // Set the Id field as the primary key
            modelBuilder.Entity<Customers>().HasKey(x => x.ID);
            // Map the Addresses class to the Customers table
            modelBuilder.Entity<Customers>().ToTable("Customers");

            // Set the Id field as the primary key
            modelBuilder.Entity<OrderLines>().HasKey(x => x.ID);
            // Map the Addresses class to the OrderLines table
            modelBuilder.Entity<OrderLines>().ToTable("OrderLines");

            // Set the Id field as the primary key
            modelBuilder.Entity<Orders>().HasKey(x => x.ID);
            // Map the Addresses class to the Orders table
            modelBuilder.Entity<Orders>().ToTable("Orders");
        }

    }
}