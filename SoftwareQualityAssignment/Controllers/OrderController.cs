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
    [Route("api/Orders")]
    public class OrderController : ControllerBase
    {
        private readonly Database _database;
        public OrderController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            IEnumerable<Order> Orders = _database.Orders.Include(x => x.OrderLines).ThenInclude(x => x.Product).ToList();
            return Ok(Orders);
        }

    }
}
