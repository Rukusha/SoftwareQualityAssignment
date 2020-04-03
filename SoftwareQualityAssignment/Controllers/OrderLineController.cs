using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SoftwareQualityAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SoftwareQualityAssignment.Controllers
{
    [ApiController]
    [Route("api/OrderLines")]
    public class OrderLinesController : ControllerBase
    {
        private readonly Database _database;
        public OrderLinesController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllOrderLines()
        {
            IEnumerable<OrderLine> OrderLines = _database.OrderLines.ToList();
            return Ok(OrderLines);
        }

    }
}
