using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HayvanSahiplenme.Models;

namespace HayvanSahiplenme.Controllers
{
    public class HayvansController : Controller
    {
        private readonly HayvanContext _context;

        public HayvansController(HayvanContext context)
        {
            _context = context;
        }

        // GET: Hayvans
        public async Task<IActionResult> Index()
        {
            var hayvanContext = _context.Hayvan.Include(h => h.Cins);
            return View(await hayvanContext.ToListAsync());
        }

        // GET: Hayvans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hayvan = await _context.Hayvan
                .Include(h => h.Cins)
                .FirstOrDefaultAsync(m => m.HayvanId == id);
            if (hayvan == null)
            {
                return NotFound();
            }

            return View(hayvan);
        }

        // GET: Hayvans/Create
        public IActionResult Create()
        {
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsId");
            return View();
        }

        // POST: Hayvans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HayvanId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,CinsId")] Hayvan hayvan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hayvan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsId", hayvan.CinsId);
            return View(hayvan);
        }

        // GET: Hayvans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hayvan = await _context.Hayvan.FindAsync(id);
            if (hayvan == null)
            {
                return NotFound();
            }
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsId", hayvan.CinsId);
            return View(hayvan);
        }

        // POST: Hayvans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HayvanId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,CinsId")] Hayvan hayvan)
        {
            if (id != hayvan.HayvanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hayvan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HayvanExists(hayvan.HayvanId))
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
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsId", hayvan.CinsId);
            return View(hayvan);
        }

        // GET: Hayvans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hayvan = await _context.Hayvan
                .Include(h => h.Cins)
                .FirstOrDefaultAsync(m => m.HayvanId == id);
            if (hayvan == null)
            {
                return NotFound();
            }

            return View(hayvan);
        }

        // POST: Hayvans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hayvan = await _context.Hayvan.FindAsync(id);
            _context.Hayvan.Remove(hayvan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HayvanExists(int id)
        {
            return _context.Hayvan.Any(e => e.HayvanId == id);
        }
    }
}
