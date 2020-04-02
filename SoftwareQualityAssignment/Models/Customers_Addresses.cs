using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.models
{
    public class Customers_Addresses
    {
        public DbSet<Customers> Customers { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DbSet<Addresses> Addresses { get; set; }

        public int CustomerID { get; set; }
        public string Street { get; set; }
        public string CityTown { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
