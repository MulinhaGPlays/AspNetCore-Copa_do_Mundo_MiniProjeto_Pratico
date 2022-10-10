using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CopaDoMundo.Data;
using Copa_do_Mundo.Models;

namespace CopaDoMundo
{
    public class CopaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CopaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Copa
        public async Task<IActionResult> Index()
        {
              return _context.Areas != null ? 
                          View(await _context.Areas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Areas'  is null.");
        }

        // GET: Copa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Areas == null)
            {
                return NotFound();
            }

            var areaModel = await _context.Areas
                .FirstOrDefaultAsync(m => m.IDArea == id);
            if (areaModel == null)
            {
                return NotFound();
            }

            return View(areaModel);
        }

        // GET: Copa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Copa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDArea,ValorIngresso")] AreaModel areaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(areaModel);
        }

        // GET: Copa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Areas == null)
            {
                return NotFound();
            }

            var areaModel = await _context.Areas.FindAsync(id);
            if (areaModel == null)
            {
                return NotFound();
            }
            return View(areaModel);
        }

        // POST: Copa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDArea,ValorIngresso")] AreaModel areaModel)
        {
            if (id != areaModel.IDArea)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaModelExists(areaModel.IDArea))
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
            return View(areaModel);
        }

        // GET: Copa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Areas == null)
            {
                return NotFound();
            }

            var areaModel = await _context.Areas
                .FirstOrDefaultAsync(m => m.IDArea == id);
            if (areaModel == null)
            {
                return NotFound();
            }

            return View(areaModel);
        }

        // POST: Copa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Areas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Areas'  is null.");
            }
            var areaModel = await _context.Areas.FindAsync(id);
            if (areaModel != null)
            {
                _context.Areas.Remove(areaModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaModelExists(int id)
        {
          return (_context.Areas?.Any(e => e.IDArea == id)).GetValueOrDefault();
        }
    }
}
