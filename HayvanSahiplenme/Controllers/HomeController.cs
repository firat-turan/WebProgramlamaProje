using HayvanSahiplenme.Data;
using HayvanSahiplenme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            //List<Ilan> ilan = db.Ilans.Include(ilan => ilan.İlanBaslik).ToList();

            var ilan = (from iln in _db.Ilans
                         orderby iln.IlanId descending
                         select iln).Take(20).ToList();
            return View(ilan);
        }
        public IActionResult Ilanlar()
        {
            //List<Ilan> ilan = db.Ilans.Include(ilan => ilan.İlanBaslik).ToList();

            var ilan = (from iln in _db.Ilans
                        orderby iln.IlanId descending
                        select iln).ToList();
            return View(ilan);
        }
        public IActionResult KopekIlanlari()
        {
            //List<Ilan> ilan = db.Ilans.Include(ilan => ilan.İlanBaslik).ToList();

            var ilan = (from iln in _db.Ilans
                         where iln.Cins.TurId==1
                         orderby iln.IlanId descending
                         select iln).ToList();
            return View(ilan);
        }
        public IActionResult KediIlanlari()
        {
            //List<Ilan> ilan = db.Ilans.Include(ilan => ilan.İlanBaslik).ToList();

            var ilan = (from iln in _db.Ilans
                        where iln.Cins.TurId == 2
                        orderby iln.IlanId descending
                        select iln).ToList();
            return View(ilan);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilan = await _db.Ilans
                .Include(i => i.Cins.Tur)
                .Include(i => i.Kullanici)
                .FirstOrDefaultAsync(m => m.IlanId == id);
            if (ilan == null)
            {
                return NotFound();
            }

            return View(ilan);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
