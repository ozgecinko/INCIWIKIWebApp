using Inciwiki.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            var dil = CultureInfo.CurrentCulture;
            string yabanciDil = dil.ToString();
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Where(i => i.IhtiyacId ==  id).Where(i => i.Icerik.Language == yabanciDil);
            return View(applicationDbContext.ToList());
        }

        public IActionResult Icerikler()
        {
            var dil = CultureInfo.CurrentCulture;
            string yabanciDil = dil.ToString();
            var applicationDbContext = _context.Icerik.Where(i => i.Language == yabanciDil).ToList();
            return View(applicationDbContext);
        }

    }


}
