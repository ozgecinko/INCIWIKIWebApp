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

        public IActionResult Index(int id)
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Where(i => i.IhtiyacId ==  id);
            return View(applicationDbContext.ToList());
        }

        public IActionResult Ihtiyaclar()
        {
            var applicationDbContext = _context.Ihtiyac.ToList();
            return View(applicationDbContext);
        }

        public IActionResult Icerikler()
        {
            var applicationDbContext = _context.Icerik.ToList();
            return View(applicationDbContext);
        }


        //public async Task<IActionResult> Nemlendirici()
        //{
        //    var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
        //    return View(await applicationDbContext.ToListAsync());
        //}

    }


}
