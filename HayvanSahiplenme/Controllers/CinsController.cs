using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HayvanSahiplenme.Data;
using HayvanSahiplenme.Models;

namespace HayvanSahiplenme.Controllers
{
    public class CinsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CinsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cins
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cins.Include(c => c.Tur);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cins = await _context.Cins
                .Include(c => c.Tur)
                .FirstOrDefaultAsync(m => m.CinsId == id);
            if (cins == null)
            {
                return NotFound();
            }

            return View(cins);
        }

        // GET: Cins/Create
        public IActionResult Create()
        {
            ViewData["TurId"] = new SelectList(_context.Tur, "TurId", "TurAd");
            return View();
        }

        // POST: Cins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CinsId,CinsAd,CinsAdIng,TurId")] Cins cins)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurId"] = new SelectList(_context.Tur, "TurId", "TurAd", cins.TurId);
            return View(cins);
        }

        // GET: Cins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cins = await _context.Cins.FindAsync(id);
            if (cins == null)
            {
                return NotFound();
            }
            ViewData["TurId"] = new SelectList(_context.Tur, "TurId", "TurAd", cins.TurId);
            return View(cins);
        }

        // POST: Cins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CinsId,CinsAd,CinsAdIng,TurId")] Cins cins)
        {
            if (id != cins.CinsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cins);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinsExists(cins.CinsId))
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
            ViewData["TurId"] = new SelectList(_context.Tur, "TurId", "TurAd", cins.TurId);
            return View(cins);
        }

        // GET: Cins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cins = await _context.Cins
                .Include(c => c.Tur)
                .FirstOrDefaultAsync(m => m.CinsId == id);
            if (cins == null)
            {
                return NotFound();
            }

            return View(cins);
        }

        // POST: Cins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cins = await _context.Cins.FindAsync(id);
            _context.Cins.Remove(cins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CinsExists(int id)
        {
            return _context.Cins.Any(e => e.CinsId == id);
        }
    }
}
