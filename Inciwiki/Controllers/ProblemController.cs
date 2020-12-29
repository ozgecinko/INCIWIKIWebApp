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

            var db = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            var akneKarsiti = await db.OrderBy(x => x.IhtiyacId == 1).ToListAsync();     
            return View(akneKarsiti);
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
    }

}
