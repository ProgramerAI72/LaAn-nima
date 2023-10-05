using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaAnonima.Data;
using LaAnónima.Models;

namespace LaAnónima.Controllers
{
    public class PasilloesController : Controller
    {
        private readonly LaAnonimaContext _context;

        public PasilloesController(LaAnonimaContext context)
        {
            _context = context;
        }

        // GET: Pasilloes
        public async Task<IActionResult> Index()
        {
              return _context.Pasillo != null ? 
                          View(await _context.Pasillo.ToListAsync()) :
                          Problem("Entity set 'LaAnonimaContext.Pasillo'  is null.");
        }

        // GET: Pasilloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pasillo == null)
            {
                return NotFound();
            }

            return View(pasillo);
        }

        // GET: Pasilloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pasilloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Id")] Pasillo pasillo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pasillo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pasillo);
        }

        // GET: Pasilloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo.FindAsync(id);
            if (pasillo == null)
            {
                return NotFound();
            }
            return View(pasillo);
        }

        // POST: Pasilloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nombre,Id")] Pasillo pasillo)
        {
            if (id != pasillo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pasillo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasilloExists(pasillo.Id))
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
            return View(pasillo);
        }

        // GET: Pasilloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pasillo == null)
            {
                return NotFound();
            }

            return View(pasillo);
        }

        // POST: Pasilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pasillo == null)
            {
                return Problem("Entity set 'LaAnonimaContext.Pasillo'  is null.");
            }
            var pasillo = await _context.Pasillo.FindAsync(id);
            if (pasillo != null)
            {
                _context.Pasillo.Remove(pasillo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasilloExists(int id)
        {
          return (_context.Pasillo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
