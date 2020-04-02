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
    [Route("api/Customers")]
    public class CustomersController : ControllerBase
    {
        private readonly Database _database;
        public CustomersController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {

            IEnumerable<Customers> Customers = _database.Customers.ToList();
            return Ok(Customers);
        }

    }
}
