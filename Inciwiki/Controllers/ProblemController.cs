using Inciwiki.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Controllers
{
    public class ProblemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProblemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Akne()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Antibakteriyel()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Antioksidan()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> CiltIyilestirici()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> CiltAydinlatici()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> HucreYenileyici()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Nemlendirici()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Surfaktan()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Yatistirici()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> GunesKorumasi()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult Index()
        {
            var ihtiyacList = (from g in _context.Ihtiyac
                            select new IhtiyacDTO
                            {
                                IhtiyacID = g.Id,
                                Adi = g.IhtiyacAdi
                            }).ToList();


            foreach (var item in ihtiyacList)
            {
                item.Icerikler = GetirIcerikListesi(item.IhtiyacID);
            }
            var vizyon = ihtiyacList.ToList();

            return View(vizyon);
        }

            public string GetirIcerikListesi(int? FKIhtiyacID)
        {
            string Icerikler = "";

            var icerikList = (from a in _context.IhtiyacIcerik
                             .Where(x => x.Id == FKIhtiyacID)
                             select new
                             {
                                 IcerikID = a.IcerikId,
                                 Icerik = a.Icerik.IcerikAdi,
                                 Resim = a.Icerik.IcerikResmi,
                                 Aciklama = a.Icerik.Aciklamasi
                             }).ToList();

            foreach (var item in icerikList)
            {
                Icerikler += "" + item.Icerik + " ;";
            }
            return Icerikler;
        }

    }

    public class IhtiyacDTO
    {
        public string Adi { get; internal set; }
        public int IhtiyacID { get; internal set; }
        public string Icerikler { get; internal set; }
    }

}
