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
    public class IlansController : Controller
    {
        private readonly HayvanContext _context;

        public IlansController(HayvanContext context)
        {
            _context = context;
        }

        // GET: Ilans
        public async Task<IActionResult> Index()
        {
            var hayvanContext = _context.Ilans.Include(i => i.Hayvan).Include(i => i.Kullanici);
            return View(await hayvanContext.ToListAsync());
        }

        // GET: Ilans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilan = await _context.Ilans
                .Include(i => i.Hayvan)
                .Include(i => i.Kullanici)
                .FirstOrDefaultAsync(m => m.IlanId == id);
            if (ilan == null)
            {
                return NotFound();
            }

            return View(ilan);
        }

        // GET: Ilans/Create
        public IActionResult Create()
        {
            ViewData["HayvanId"] = new SelectList(_context.Hayvan, "HayvanId", "HayvanId");
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId");
            return View();
        }

        // POST: Ilans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IlanId,Tarih,İlanBaslik,İlanBaslikIng,Aciklama,AciklamaIng,Fotograf,HayvanId,KullaniciId")] Ilan ilan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ilan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HayvanId"] = new SelectList(_context.Hayvan, "HayvanId", "HayvanId", ilan.HayvanId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
            return View(ilan);
        }

        // GET: Ilans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilan = await _context.Ilans.FindAsync(id);
            if (ilan == null)
            {
                return NotFound();
            }
            ViewData["HayvanId"] = new SelectList(_context.Hayvan, "HayvanId", "HayvanId", ilan.HayvanId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
            return View(ilan);
        }

        // POST: Ilans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IlanId,Tarih,İlanBaslik,İlanBaslikIng,Aciklama,AciklamaIng,Fotograf,HayvanId,KullaniciId")] Ilan ilan)
        {
            if (id != ilan.IlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ilan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IlanExists(ilan.IlanId))
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
            ViewData["HayvanId"] = new SelectList(_context.Hayvan, "HayvanId", "HayvanId", ilan.HayvanId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "KullaniciId", ilan.KullaniciId);
            return View(ilan);
        }

        // GET: Ilans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilan = await _context.Ilans
                .Include(i => i.Hayvan)
                .Include(i => i.Kullanici)
                .FirstOrDefaultAsync(m => m.IlanId == id);
            if (ilan == null)
            {
                return NotFound();
            }

            return View(ilan);
        }

        // POST: Ilans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ilan = await _context.Ilans.FindAsync(id);
            _context.Ilans.Remove(ilan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IlanExists(int id)
        {
            return _context.Ilans.Any(e => e.IlanId == id);
        }
    }
}
