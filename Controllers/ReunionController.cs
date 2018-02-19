using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto_Web_ll.Models;

namespace Proyecto_Web_ll.Controllers
{
    public class ReunionController : Controller
    {
        private readonly MvcToyotaContext _context;

        public ReunionController(MvcToyotaContext context)
        {
            _context = context;
        }

        // GET: Reunion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reunion.ToListAsync());
        }

        // GET: Reunion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunion = await _context.Reunion
                .SingleOrDefaultAsync(m => m.ID == id);
            if (reunion == null)
            {
                return NotFound();
            }

            return View(reunion);
        }

        // GET: Reunion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reunion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Id_Cliente,Titulo,EnrollmentDate,Virtual,Id_Usuario")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reunion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reunion);
        }

        // GET: Reunion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunion = await _context.Reunion.SingleOrDefaultAsync(m => m.ID == id);
            if (reunion == null)
            {
                return NotFound();
            }
            return View(reunion);
        }

        // POST: Reunion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Id_Cliente,Titulo,EnrollmentDate,Virtual,Id_Usuario")] Reunion reunion)
        {
            if (id != reunion.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reunion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReunionExists(reunion.ID))
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
            return View(reunion);
        }

        // GET: Reunion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunion = await _context.Reunion
                .SingleOrDefaultAsync(m => m.ID == id);
            if (reunion == null)
            {
                return NotFound();
            }

            return View(reunion);
        }

        // POST: Reunion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reunion = await _context.Reunion.SingleOrDefaultAsync(m => m.ID == id);
            _context.Reunion.Remove(reunion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReunionExists(int id)
        {
            return _context.Reunion.Any(e => e.ID == id);
        }
    }
}
