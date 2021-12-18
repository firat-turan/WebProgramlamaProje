using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HayvanSahiplenme.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace HayvanSahiplenme.Controllers
{
    public class IlansController : Controller
    {
        private readonly HayvanContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public IlansController(HayvanContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Ilans
        public async Task<IActionResult> Index()
        {
            var hayvanContext = _context.Ilans.Include(i => i.Cins).Include(i => i.Kullanici);
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
                .Include(i => i.Cins)
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
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd");
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "Ad");
            return View();
        }

        // POST: Ilans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IlanId,İlanBaslik,İlanBaslikIng,HayvanAd,CinsId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,Aciklama,AciklamaIng,ImageFile,KullaniciId")] Ilan ilan)
        {
            if (ModelState.IsValid)
            {
                string wwwrootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ilan.ImageFile.FileName);
                string extension = Path.GetExtension(ilan.ImageFile.FileName);
                ilan.Fotograf = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwrootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path,FileMode.Create))
                {
                    await ilan.ImageFile.CopyToAsync(fileStream);
                }

                ilan.Tarih = DateTime.Now;
                _context.Add(ilan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "Ad", ilan.KullaniciId);
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
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "Ad", ilan.KullaniciId);
            return View(ilan);
        }

        // POST: Ilans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IlanId,İlanBaslik,İlanBaslikIng,HayvanAd,CinsId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,Aciklama,AciklamaIng,Fotograf,KullaniciId")] Ilan ilan)
        {
            if (id != ilan.IlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ilan.Tarih = DateTime.Now;
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
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanici, "KullaniciId", "Ad", ilan.KullaniciId);
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
                .Include(i => i.Cins)
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

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", ilan.Fotograf);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

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
