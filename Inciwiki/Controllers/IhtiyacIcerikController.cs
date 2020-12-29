using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inciwiki.Data;
using Inciwiki.Models;

namespace Inciwiki.Controllers
{
    public class IhtiyacIcerikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IhtiyacIcerikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IhtiyacIcerik
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: IhtiyacIcerik
        public async Task<IActionResult> List()
        {
            var applicationDbContext = _context.IhtiyacIcerik.Include(i => i.Icerik).Include(i => i.Ihtiyac);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: IhtiyacIcerik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyacIcerik = await _context.IhtiyacIcerik
                .Include(i => i.Icerik)
                .Include(i => i.Ihtiyac)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ihtiyacIcerik == null)
            {
                return NotFound();
            }

            return View(ihtiyacIcerik);
        }

        // GET: IhtiyacIcerik/Create
        public IActionResult Create()
        {
            ViewData["IcerikId"] = new SelectList(_context.Icerik, "Id", "IcerikAdi");
            ViewData["IhtiyacId"] = new SelectList(_context.Ihtiyac, "Id", "IhtiyacAdi");
            return View();
        }

        // POST: IhtiyacIcerik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IhtiyacId,IcerikId")] IhtiyacIcerik ihtiyacIcerik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ihtiyacIcerik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IcerikId"] = new SelectList(_context.Icerik, "Id", "IcerikAdi", ihtiyacIcerik.IcerikId);
            ViewData["IhtiyacId"] = new SelectList(_context.Ihtiyac, "Id", "IhtiyacAdi", ihtiyacIcerik.IhtiyacId);
            return View(ihtiyacIcerik);
        }

        // GET: IhtiyacIcerik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyacIcerik = await _context.IhtiyacIcerik.FindAsync(id);
            if (ihtiyacIcerik == null)
            {
                return NotFound();
            }
            ViewData["IcerikId"] = new SelectList(_context.Icerik, "Id", "IcerikAdi", ihtiyacIcerik.IcerikId);
            ViewData["IhtiyacId"] = new SelectList(_context.Ihtiyac, "Id", "IhtiyacAdi", ihtiyacIcerik.IhtiyacId);
            return View(ihtiyacIcerik);
        }

        // POST: IhtiyacIcerik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IhtiyacId,IcerikId")] IhtiyacIcerik ihtiyacIcerik)
        {
            if (id != ihtiyacIcerik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ihtiyacIcerik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IhtiyacIcerikExists(ihtiyacIcerik.Id))
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
            ViewData["IcerikId"] = new SelectList(_context.Icerik, "Id", "IcerikAdi", ihtiyacIcerik.IcerikId);
            ViewData["IhtiyacId"] = new SelectList(_context.Ihtiyac, "Id", "IhtiyacAdi", ihtiyacIcerik.IhtiyacId);
            return View(ihtiyacIcerik);
        }

        // GET: IhtiyacIcerik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyacIcerik = await _context.IhtiyacIcerik
                .Include(i => i.Icerik)
                .Include(i => i.Ihtiyac)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ihtiyacIcerik == null)
            {
                return NotFound();
            }

            return View(ihtiyacIcerik);
        }

        // POST: IhtiyacIcerik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ihtiyacIcerik = await _context.IhtiyacIcerik.FindAsync(id);
            _context.IhtiyacIcerik.Remove(ihtiyacIcerik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IhtiyacIcerikExists(int id)
        {
            return _context.IhtiyacIcerik.Any(e => e.Id == id);
        }
    }
}
