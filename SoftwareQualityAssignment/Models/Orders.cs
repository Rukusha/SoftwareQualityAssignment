using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareQualityAssignment.models
{
    public class Orders
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string CreatedDate { get; set; }
        public string PaymentPaidDate { get; set; }
        public string DispatchedDate { get; set; }

    }
}
