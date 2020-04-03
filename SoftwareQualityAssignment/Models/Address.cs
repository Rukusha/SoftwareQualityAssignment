using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.Models
{
    public class Address
    {
        public int ID { get; set; }
        public int? CustomerID { get; set; }
        public string Street { get; set; }
        public string CityTown { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
