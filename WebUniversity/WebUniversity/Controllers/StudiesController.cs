using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUniversity;
using WebUniversity.Models;

namespace WebUniversity.Controllers
{
    public class StudiesController : Controller
    {
        private readonly WebUniversityContext _context;

        public StudiesController(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: Studies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Study.ToListAsync());
        }

        // GET: Studies/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study
                .FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // GET: Studies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Study study)
        {
            if (ModelState.IsValid)
            {
                _context.Add(study);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(study);
        }

        // GET: Studies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study.FindAsync(id);
            if (study == null)
            {
                return NotFound();
            }
            return View(study);
        }

        // POST: Studies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Title")] Study study)
        {
            if (id != study.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(study);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudyExists(study.Id))
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
            return View(study);
        }

        // GET: Studies/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study
                .FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // POST: Studies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var study = await _context.Study.FindAsync(id);
            _context.Study.Remove(study);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudyExists(long id)
        {
            return _context.Study.Any(e => e.Id == id);
        }
    }
}
