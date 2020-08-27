using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FluxoCaixa03.Data;
using FluxoCaixa03.Models;

namespace FluxoCaixa03.Controllers
{
    public class FcclassesController : Controller
    {
        private readonly FluxoCaixa03Context _context;

        public FcclassesController(FluxoCaixa03Context context)
        {
            _context = context;
        }

        // GET: Fcclasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fcclasse.ToListAsync());
        }

        // GET: Fcclasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fcclasse = await _context.Fcclasse
                .FirstOrDefaultAsync(m => m.id_classe == id);
            if (fcclasse == null)
            {
                return NotFound();
            }

            return View(fcclasse);
        }

        // GET: Fcclasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fcclasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_classe,nm_classe")] Fcclasse fcclasse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fcclasse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fcclasse);
        }

        // GET: Fcclasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fcclasse = await _context.Fcclasse.FindAsync(id);
            if (fcclasse == null)
            {
                return NotFound();
            }
            return View(fcclasse);
        }

        // POST: Fcclasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_classe,nm_classe")] Fcclasse fcclasse)
        {
            if (id != fcclasse.id_classe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fcclasse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FcclasseExists(fcclasse.id_classe))
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
            return View(fcclasse);
        }

        // GET: Fcclasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fcclasse = await _context.Fcclasse
                .FirstOrDefaultAsync(m => m.id_classe == id);
            if (fcclasse == null)
            {
                return NotFound();
            }

            return View(fcclasse);
        }

        // POST: Fcclasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fcclasse = await _context.Fcclasse.FindAsync(id);
            _context.Fcclasse.Remove(fcclasse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FcclasseExists(int id)
        {
            return _context.Fcclasse.Any(e => e.id_classe == id);
        }
    }
}
