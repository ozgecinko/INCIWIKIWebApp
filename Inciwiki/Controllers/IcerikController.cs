using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inciwiki.Data;
using Inciwiki.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Inciwiki.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IcerikController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public IcerikController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Icerik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Icerik.ToListAsync());
        }
        

        // GET: Icerik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }


        // GET: Icerik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Icerik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,IcerikAdi,Aciklamasi,IcerikResmi,Puani")] Icerik icerik)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(icerik);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(icerik);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IcerikAdi,Aciklamasi,IcerikResmi,Puani,Language")] Icerik icerik)
        {
            if (ModelState.IsValid)
            {

                //******
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"img\ingredients");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                icerik.IcerikResmi = @"\img\ingredients\" + fileName + extension;

                _context.Add(icerik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(icerik);
        }


        // GET: Icerik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik.FindAsync(id);
            if (icerik == null)
            {
                return NotFound();
            }
            return View(icerik);
        }

        // POST: Icerik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IcerikAdi,Aciklamasi,IcerikResmi,Puani,Language")] Icerik icerik)
        {
            if (id != icerik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(icerik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IcerikExists(icerik.Id))
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
            return View(icerik);
        }


        // GET: Icerik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icerik = await _context.Icerik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (icerik == null)
            {
                return NotFound();
            }

            return View(icerik);
        }

        // POST: Icerik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var icerik = await _context.Icerik.FindAsync(id);
            _context.Icerik.Remove(icerik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IcerikExists(int id)
        {
            return _context.Icerik.Any(e => e.Id == id);
        }
    }
}
