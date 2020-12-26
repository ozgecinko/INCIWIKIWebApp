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
    public class IhtiyacController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IhtiyacController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ihtiyac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ihtiyac.ToListAsync());
        }

        // GET: Ihtiyac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyac = await _context.Ihtiyac
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ihtiyac == null)
            {
                return NotFound();
            }

            return View(ihtiyac);
        }

        // GET: Ihtiyac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ihtiyac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IhtiyacAdi")] Ihtiyac ihtiyac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ihtiyac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ihtiyac);
        }

        // GET: Ihtiyac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyac = await _context.Ihtiyac.FindAsync(id);
            if (ihtiyac == null)
            {
                return NotFound();
            }
            return View(ihtiyac);
        }

        // POST: Ihtiyac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IhtiyacAdi")] Ihtiyac ihtiyac)
        {
            if (id != ihtiyac.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ihtiyac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IhtiyacExists(ihtiyac.Id))
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
            return View(ihtiyac);
        }

        // GET: Ihtiyac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ihtiyac = await _context.Ihtiyac
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ihtiyac == null)
            {
                return NotFound();
            }

            return View(ihtiyac);
        }

        // POST: Ihtiyac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ihtiyac = await _context.Ihtiyac.FindAsync(id);
            _context.Ihtiyac.Remove(ihtiyac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IhtiyacExists(int id)
        {
            return _context.Ihtiyac.Any(e => e.Id == id);
        }
    }
}
