using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HayvanSahiplenme.Data;
using HayvanSahiplenme.Models;
using Microsoft.AspNetCore.Authorization;

namespace HayvanSahiplenme.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Turs
       
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tur.ToListAsync());
        }

        // GET: Turs/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur
                .FirstOrDefaultAsync(m => m.TurId == id);
            if (tur == null)
            {
                return NotFound();
            }

            return View(tur);
        }

        // GET: Turs/Create
        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("TurId,TurAd,TurAdIng")] Tur tur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tur);
        }

        // GET: Turs/Edit/5
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur.FindAsync(id);
            if (tur == null)
            {
                return NotFound();
            }
            return View(tur);
        }

        // POST: Turs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(int id, [Bind("TurId,TurAd,TurAdIng")] Tur tur)
        {
            if (id != tur.TurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurExists(tur.TurId))
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
            return View(tur);
        }

        // GET: Turs/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tur = await _context.Tur
                .FirstOrDefaultAsync(m => m.TurId == id);
            if (tur == null)
            {
                return NotFound();
            }

            return View(tur);
        }

        // POST: Turs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tur = await _context.Tur.FindAsync(id);
            _context.Tur.Remove(tur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurExists(int id)
        {
            return _context.Tur.Any(e => e.TurId == id);
        }
    }
}
