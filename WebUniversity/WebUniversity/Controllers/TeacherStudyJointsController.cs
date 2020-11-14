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
    public class TeacherStudyJointsController : Controller
    {
        private readonly WebUniversityContext _context;

        public TeacherStudyJointsController(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: TeacherStudyJoints
        public async Task<IActionResult> Index()
        {
            var webUniversityContext = _context.TeacherStudyJoint.Include(t => t.Study).Include(t => t.Teacher);
            return View(await webUniversityContext.ToListAsync());
        }

        // GET: TeacherStudyJoints/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherStudyJoint = await _context.TeacherStudyJoint
                .Include(t => t.Study)
                .Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherStudyJoint == null)
            {
                return NotFound();
            }

            return View(teacherStudyJoint);
        }

        // GET: TeacherStudyJoints/Create
        public IActionResult Create()
        {
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id");
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id");
            return View();
        }

        // POST: TeacherStudyJoints/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeacherId,StudyId,Hours")] TeacherStudyJoint teacherStudyJoint)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherStudyJoint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id", teacherStudyJoint.StudyId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id", teacherStudyJoint.TeacherId);
            return View(teacherStudyJoint);
        }

        // GET: TeacherStudyJoints/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherStudyJoint = await _context.TeacherStudyJoint.FindAsync(id);
            if (teacherStudyJoint == null)
            {
                return NotFound();
            }
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id", teacherStudyJoint.StudyId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id", teacherStudyJoint.TeacherId);
            return View(teacherStudyJoint);
        }

        // POST: TeacherStudyJoints/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TeacherId,StudyId,Hours")] TeacherStudyJoint teacherStudyJoint)
        {
            if (id != teacherStudyJoint.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherStudyJoint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherStudyJointExists(teacherStudyJoint.Id))
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
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Id", teacherStudyJoint.StudyId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id", teacherStudyJoint.TeacherId);
            return View(teacherStudyJoint);
        }

        // GET: TeacherStudyJoints/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherStudyJoint = await _context.TeacherStudyJoint
                .Include(t => t.Study)
                .Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherStudyJoint == null)
            {
                return NotFound();
            }

            return View(teacherStudyJoint);
        }

        // POST: TeacherStudyJoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var teacherStudyJoint = await _context.TeacherStudyJoint.FindAsync(id);
            _context.TeacherStudyJoint.Remove(teacherStudyJoint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherStudyJointExists(long id)
        {
            return _context.TeacherStudyJoint.Any(e => e.Id == id);
        }
    }
}
