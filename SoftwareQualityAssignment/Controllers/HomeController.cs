using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftwareQualityAssignment.models;

namespace SoftwareQualityAssignment.Controllers
{    
    [Controller]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly Database _context;

        public HomeController(Database context)
        {
            _context = context;
        }

        // GET: index
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }
        //public async Task<IActionResult> GetAllAddresses()
        //{
        //    return View(await _context.Addresses.ToListAsync());
        //}



        //// GET: index/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customers = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (customers == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customers);
        //}

        //// GET: index/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: index/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,EmailAddress")] Customers customers)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(customers);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(customers);
        //}

        //// GET: index/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customers = await _context.Customers.FindAsync(id);
        //    if (customers == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(customers);
        //}

        //// POST: index/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,EmailAddress")] Customers customers)
        //{
        //    if (id != customers.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(customers);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CustomersExists(customers.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(customers);
        //}

        //// GET: index/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customers = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (customers == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customers);
        //}

        //// POST: index/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var customers = await _context.Customers.FindAsync(id);
        //    _context.Customers.Remove(customers);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CustomersExists(int id)
        //{
        //    return _context.Customers.Any(e => e.ID == id);
        //}
    }
}
