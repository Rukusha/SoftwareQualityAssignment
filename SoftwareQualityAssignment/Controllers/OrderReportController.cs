using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareQualityAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SoftwareQualityAssignment.Controllers
{
    [ApiController]
    [Route("api/OrdersReport")]
    public class OrderReportController : ControllerBase
    {
        private readonly Database _database;
        public OrderReportController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {

            List<OrderTotal> orderTotals = new List<OrderTotal>();

            IEnumerable<Order> Orders = _database.Orders.Include(x => x.OrderLines).ThenInclude(x => x.Product).Include(x => x.Customers)
                .OrderBy(x => x.Customers)
                .ToList();
            foreach( Order item in Orders)
            {
                OrderTotal individualOrder = new OrderTotal();

                individualOrder.FirstName = item.Customers.FirstName;
                individualOrder.LastName = item.Customers.LastName;

                individualOrder.CreatedDate = item.CreatedDate;
                individualOrder.OrderLines = item.OrderLines;

                decimal? total = 0;
                decimal? Sub = 0;
                List<decimal?> SubTotal = new List<decimal?>();


                foreach (OrderLine orderlines in item.OrderLines)
                {
                     Sub = orderlines.Quantity * orderlines.Product.Price;
                     total +=  Sub;
                     SubTotal.Add(Sub);

                }
                individualOrder.Price = total;
                individualOrder.SubTotal = SubTotal;
                orderTotals.Add(individualOrder);
            }

            return Ok(orderTotals);
        }

    }
}
