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
            IEnumerable<Customer> Customers = _database.Customers.Include(x => x.Addresses).ToList();
            return Ok(Customers);
        }

    }
}
