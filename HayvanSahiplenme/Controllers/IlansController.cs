using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HayvanSahiplenme.Data;
using HayvanSahiplenme.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HayvanSahiplenme.Controllers
{
    public class IlansController : Controller
    {
        private readonly UserManager<Kullanici> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
   

        //public IlansController(UserManager<Kullanici> userManager)
        //{
        //    _userManager = userManager;
        //}
        public IlansController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<Kullanici> userManager)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
            _userManager = userManager;
           
        }

        // GET: Ilans
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ilans.Include(i => i.Cins).Include(i => i.Kullanici);
            return View(await applicationDbContext.ToListAsync());
        }
       
        public IActionResult Ilanlarim()
        {
            string id = _userManager.GetUserId(HttpContext.User);
            var ilan = (from iln in _context.Ilans
                        where iln.Kullanici.Id == id
                        orderby iln.IlanId descending
                        select iln).ToList();

            return View(ilan);
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
            List<string> cinsiyet = new List<string>();
            cinsiyet.Add("Erkek");
            cinsiyet.Add("Dişi");
            ViewData["Cinsiyet"] = new SelectList(cinsiyet);

            List<string> asiDurumu = new List<string>();
            asiDurumu.Add("Yapıldı");
            asiDurumu.Add("Yapılmadı");
            ViewData["AsiDurumu"] = new SelectList(asiDurumu);

            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd");
            ViewData["UserId"] = new SelectList(_context.Kullanici, "Id", "Id");
            return View();
        }

        // POST: Ilans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IlanId,İlanBaslik,İlanBaslikIng,HayvanAd,CinsId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,Aciklama,AciklamaIng,ImageFile")] Ilan ilan)
        {
            if (ModelState.IsValid)
            {
                string wwwrootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ilan.ImageFile.FileName);
                string extension = Path.GetExtension(ilan.ImageFile.FileName);
                ilan.Fotograf = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwrootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ilan.ImageFile.CopyToAsync(fileStream);
                }


                ilan.UserId = _userManager.GetUserId(HttpContext.User);
                ilan.Tarih = DateTime.Now;

                _context.Add(ilan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Ilanlarim));
            }
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            ViewData["UserId"] = new SelectList(_context.Kullanici, "Id", "Id", ilan.UserId);
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
            List<string> cinsiyet = new List<string>();
            cinsiyet.Add("Erkek");
            cinsiyet.Add("Dişi");
            ViewData["Cinsiyet"] = new SelectList(cinsiyet);

            List<string> asiDurumu = new List<string>();
            asiDurumu.Add("Yapıldı");
            asiDurumu.Add("Yapılmadı");
            ViewData["AsiDurumu"] = new SelectList(asiDurumu);

            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            //ViewData["UserId"] = new SelectList(_context.Kullanici, "Id", "Id", ilan.UserId);
            return View(ilan);
        }

        // POST: Ilans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Tarih,IlanId,İlanBaslik,İlanBaslikIng,HayvanAd,CinsId,Cinsiyet,CinsiyetIng,Yas,AsiDurumu,AsiDurumuIng,Aciklama,AciklamaIng,Fotograf,ImageFile,UserId")] Ilan ilan)
        {
            if (id != ilan.IlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string wwwrootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(ilan.ImageFile.FileName);
                    string extension = Path.GetExtension(ilan.ImageFile.FileName);
                    ilan.Fotograf = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwrootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ilan.ImageFile.CopyToAsync(fileStream);
                    }

                    //ilan.Tarih = DateTime.Now;
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
                return RedirectToAction(nameof(Ilanlarim));
            }
            ViewData["CinsId"] = new SelectList(_context.Cins, "CinsId", "CinsAd", ilan.CinsId);
            //ViewData["UserId"] = new SelectList(_context.Kullanici, "Id", "Id", ilan.UserId);
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
            return RedirectToAction(nameof(Ilanlarim));
        }

        private bool IlanExists(int id)
        {
            return _context.Ilans.Any(e => e.IlanId == id);
        }
    }
}
