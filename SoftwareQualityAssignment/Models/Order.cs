using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.Models
{
    public class Order
    {

        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string CreatedDate { get; set; }
        public string PaymentPaidDate { get; set; }
        public string DispatchedDate { get; set; }
        public IList<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public Customer Customers { get; set; }

    }
}
