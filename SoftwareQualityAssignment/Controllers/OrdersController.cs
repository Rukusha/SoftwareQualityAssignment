using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SoftwareQualityAssignment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SoftwareQualityAssignment.Controllers
{
    [ApiController]
    [Route("api/Orders")]
    public class OrdersController : ControllerBase
    {
        private readonly Database _database;
        public OrdersController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            IEnumerable<Orders> Orders = _database.Orders.ToList();
            return Ok(Orders);
        }

    }
}
