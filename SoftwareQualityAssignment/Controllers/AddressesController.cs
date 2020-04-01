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
    [Route("api/Addresses")]
    public class AddressesController: ControllerBase
    {
        private readonly Database _database;
        public AddressesController(Database database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            IEnumerable<Addresses> Addresses = _database.Addresses.ToList();
            return Ok(Addresses);
        }

    }
}
