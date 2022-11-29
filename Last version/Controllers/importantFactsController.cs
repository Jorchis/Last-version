using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JWST_PWEB.Models;
using Last_version.Data;

namespace Last_version.Controllers
{
    public class importantFactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public importantFactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: importantFacts
        public async Task<IActionResult> Index()
        {
              return View(await _context.importantFacts.ToListAsync());
        }

        // GET: importantFacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.importantFacts == null)
            {
                return NotFound();
            }

            var importantFacts = await _context.importantFacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importantFacts == null)
            {
                return NotFound();
            }

            return View(importantFacts);
        }

        // GET: importantFacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: importantFacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IFTitle,IFText,pictureURL,userID")] importantFacts importantFacts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(importantFacts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(importantFacts);
        }

        // GET: importantFacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.importantFacts == null)
            {
                return NotFound();
            }

            var importantFacts = await _context.importantFacts.FindAsync(id);
            if (importantFacts == null)
            {
                return NotFound();
            }
            return View(importantFacts);
        }

        // POST: importantFacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IFTitle,IFText,pictureURL,userID")] importantFacts importantFacts)
        {
            if (id != importantFacts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importantFacts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!importantFactsExists(importantFacts.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(importantFacts);
        }

        // GET: importantFacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.importantFacts == null)
            {
                return NotFound();
            }

            var importantFacts = await _context.importantFacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importantFacts == null)
            {
                return NotFound();
            }

            return View(importantFacts);
        }

        // POST: importantFacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.importantFacts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.importantFacts'  is null.");
            }
            var importantFacts = await _context.importantFacts.FindAsync(id);
            if (importantFacts != null)
            {
                _context.importantFacts.Remove(importantFacts);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool importantFactsExists(int id)
        {
          return _context.importantFacts.Any(e => e.Id == id);
        }
    }
}
